using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Sockets;
using System.Net;
using System.Threading;

namespace SocketServer
{
    class SocketCtrl
    {
        private Socket soc = null;
        private IPEndPoint lclEP = null;
        public static bool IsWork = true;
        private byte[] recBuf = new byte[1024];
        public Action<string> showMsg;

        public static void stopListen()
        {
            IsWork = true;
        }

        public SocketCtrl(int udpPort)
        {
            lclEP = new IPEndPoint(IPAddress.Any, udpPort);
            soc = new Socket(AddressFamily.InterNetwork, SocketType.Dgram, ProtocolType.Udp);

        }

        public void startListen()
        {
            IsWork = false;
            Thread t = new Thread(new ThreadStart(doWork));
            t.IsBackground = true;
            t.Start();
        }

        private void doWork()
        {
            int recv = 0;
            soc.Bind(lclEP);
            showMsg("启动监听。。。\r\n");
            while (!IsWork)
            {
                recv = soc.Receive(recBuf);
                showMsg(Encoding.Unicode.GetString(recBuf, 0, recv));
            }
        }

        public void send(IPEndPoint sendTarget, byte[] data)
        {
            soc.SendTo(data, sendTarget);
        }

        public void send(string destIp, int destPort, byte[] data)
        {
            IPEndPoint ep = new IPEndPoint(IPAddress.Parse(destIp), destPort);
            soc.SendTo(data, ep);
        }
    }
}
