﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Net;
using System.Net.Sockets;
using System.Collections;
using System.Net.NetworkInformation;
using System.Threading;

namespace OESMonitor.Net
{
    public class OESServer
    {
        private TcpListener listener;
        private IPAddress ip = null;
        private List<DataPort> ports = new List<DataPort>();
        private List<Client> clients = new List<Client>();

        private Queue<DataPort> PortQueue = new Queue<DataPort>();
        private Queue<Client> RequestingQueue = new Queue<Client>();
        private Queue<Client> SubmitingQueue = new Queue<Client>();
        private Queue<int> availablePorts = new Queue<int>();

        //线程同步锁
        private object syncLock = new object();

        //数据端口预定个数
        private int portsRequest = 20;      
        private string archiveDirectory = "D:/";       

        //事件机制处理新的试卷请求
        public delegate void PaperRequestor();
        public event PaperRequestor PaperAllocator;

        //将当前试卷路径填充
        public string currentPaperpath = "D:/EXAM001.rar";

        public OESServer()
        {            
            RetrieveHostIpv4Address();
            if( ip != null )
            {
                listener = new TcpListener(ip, 20000);     //固定服务端监听端口           
                listener.Start();
                listener.BeginAcceptTcpClient(new AsyncCallback(accept_callBack), listener);
                MessageSupervisor.targetFrm.showMessage("Start server: " + listener.LocalEndpoint.ToString());
                
                InitializeDataPorts();
            }
            //else 通知出错处理程序
        }

        public string ARCHIVEDIRECTORY
        {
            set
            {
                if (value.Length != 0)
                    archiveDirectory = value;
            }
        }
        public delegate void UpdatePanel(Client c);
        public void accept_callBack(IAsyncResult asy)
        {
            TcpListener tlistener = (TcpListener)asy.AsyncState;
            TcpClient tclient = tlistener.EndAcceptTcpClient(asy);

            Client client = new Client(tclient);
            MessageSupervisor.mainForm.AddComputer(client);
            client.MessageScheduler += MessageScheduler;

            clients.Add(client);
            listener.BeginAcceptTcpClient(new AsyncCallback(accept_callBack), listener);
        }
        
        private void RetrieveHostIpv4Address()
        {
            //获得所有的ip地址，包括ipv6和ipv4
            IPAddress[] ips = Dns.GetHostAddresses(Dns.GetHostName());
            foreach (IPAddress tip in ips)
            {
                //ipv4的最大长度为15，ipv6为39
                if (tip.ToString().Length <= 15)
                {
                    ip = tip;
                    return;
                }
            }
        }

        private void InitializeDataPorts()
        {
            SearchSparePort();
            for(int i = availablePorts.Count - 1; i >= 0 ; i-- )
            {
                DataPort dport = new DataPort(ip,availablePorts.Dequeue());
                dport.archiveDirectory = archiveDirectory;
                dport.portRecycle += PortRecycler;  //注册回收端口事件
                ports.Add(dport);
                PortQueue.Enqueue(dport);
            }
        }

        //搜索当前空闲端口号
        private void SearchSparePort()
        {
            int start_port = 10005;
            IPGlobalProperties ipgloabalprops = IPGlobalProperties.GetIPGlobalProperties();          
            IPEndPoint[] tcpListInfos = ipgloabalprops.GetActiveTcpListeners();
            TcpConnectionInformation[] tcpConnInfos = ipgloabalprops.GetActiveTcpConnections();
            IPEndPoint[] udpInfos = ipgloabalprops.GetActiveUdpListeners();

            List<int> portNumbers = new List<int>();
            foreach(IPEndPoint tcpl in tcpListInfos)
            {
                portNumbers.Add(tcpl.Port);
            }
            foreach (TcpConnectionInformation tcpi in tcpConnInfos)
            {
                portNumbers.Add(tcpi.LocalEndPoint.Port);
            }
            foreach (IPEndPoint udpl in udpInfos)
            {
                portNumbers.Add(udpl.Port);
            }

            portNumbers.Sort();
            int port = start_port;
            for (int i = 0; i < portNumbers.Count; i++)
            {
                if (portNumbers[i] <= port)
                    continue;

                port++;
                while (port != portNumbers[i])
                {
                    availablePorts.Enqueue(port);
                    port++;
                    if (--portsRequest == 0)
                        return;
                }              
            }            
        }

        private void PortRecycler(DataPort port)
        {
            PortQueue.Enqueue(port);

            MessageSupervisor.targetFrm.showMessage("Port Recycled: " + port.ip.ToString() + ":" + port.localPort.ToString());

            Client tclient;
            while ((RequestingQueue.Count != 0) && (PortQueue.Count != 0))
            {
                tclient = RequestingQueue.Dequeue();
                tclient.port = PortQueue.Dequeue();
                MessageSupervisor.targetFrm.showMessage("Requesting Allocate Port: " + tclient.port.portInfo() + " ---> " + tclient.clientInfo());

                tclient.sendData();
            }
            while ((SubmitingQueue.Count != 0) && (PortQueue.Count != 0))
            {
                tclient = SubmitingQueue.Dequeue();
                tclient.port = PortQueue.Dequeue();
                MessageSupervisor.targetFrm.showMessage("Submitting Allocate Port: " + tclient.port.portInfo() + " ---> " + tclient.clientInfo());
                //接收数据
                tclient.ReceiveData();
            }
        }

        //中断所有服务
        public void EndService()
        {
            foreach (Client c in clients)
            {
                c.EndAllConnection();
            }
        }

        private void MessageScheduler(Client client)
        {
            lock(syncLock)
            {
                string[] msgs;
            //此为临界区，需要加锁，解锁，也许可以通过整合到Client类中提高一点效率
                switch (client.msg_type)
                {
                    case 0:
                        //请求发送试卷
                        //PaperAllocator();
                        Console.WriteLine(Thread.CurrentThread.Name);
                        //获取考试对应试卷
                        //client.computer.Student
                        client.paperPath = currentPaperpath;
                        if (PortQueue.Count != 0)
                        {
                            client.port = PortQueue.Dequeue();
                            client.port.paperDelivered += client.port_paperDelivered;
                            MessageSupervisor.targetFrm.showMessage("Requesting Allocate Port: " + client.port.portInfo() + " ---> " + client.clientInfo());
                            client.sendData();
                        }
                        else
                        {
                            RequestingQueue.Enqueue(client);
                            MessageSupervisor.targetFrm.showMessage("Client: " + client.clientInfo() + " Wait for Requesting");
                        }
                        break;

                    case 1:
                        //确定文件名函数client.fileName = ;
                        client.FetchData();
                        break;

                    case 2:
                        msgs = client.msg.Split(new char[] { '$' });
                        client.remoteIP = IPAddress.Parse(msgs[0]);
                        client.remotePort = Convert.ToInt32(msgs[1]);
                        if (PortQueue.Count != 0)
                        {
                            client.port = PortQueue.Dequeue();
                            MessageSupervisor.targetFrm.showMessage("Submitting Allocate Port: " + client.port.portInfo() + " ---> " + client.clientInfo());
                            client.ReceiveData();
                        }
                        else
                        {
                            SubmitingQueue.Enqueue(client);
                            MessageSupervisor.targetFrm.showMessage("Client: " + client.clientInfo() + " Wait for Submitting");
                        }
                        break;

                    case 3:
                        {
                            msgs = client.msg.Split(new char[] { '$' });
                            client.computer.Student = new global::OESMonitor.Model.Student(msgs[0], "", msgs[1], msgs[2]);
                            //验证学生是否可以考试
                            
                            client.Login(true);
                            break;
                        }

                    case 4:
                        {
                            msgs = client.msg.Split(new char[] { '$' });
                            switch (Convert.ToInt32(msgs[0]))
                            {
                                case 0:
                                    client.computer.State = 3;
                                    break;
                                case 1:
                                    client.computer.State = 6;
                                    break;
                                case 2:
                                    client.computer.State = 7;
                                    break;
                                case 3:
                                    client.computer.State = 8;
                                    break;
                            }
                            break;
                        }
                    case 5:
                        {
                            client.computer.State = 1;
                            break;
                        }
                    case -1:
                        if (client.EndConnection())
                            client.EndService();
                        break;

                    case -2:
                        client.EndService();
                        break;

                    default:
                        //网络出错程序
                        break;
                }
            }
        }

    }
}
