using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SocketServer
{
    public partial class Main : Form
    {
        private int port = 5000;
        SocketCtrl sc = null;
        public Main()
        {
            InitializeComponent();
        }


        public void showMsg(string msg)
        {
            this.Invoke(new MethodInvoker(delegate
            {
                txtMsg.AppendText(Environment.NewLine);
                txtMsg.AppendText(msg);
                txtMsg.ScrollToCaret();
            }));
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            sc = new SocketCtrl(port);
            sc.showMsg = showMsg;
            sc.startListen();

            workTimer.Enabled = true;
        }

        private int dataCount = 1;
        private void btnSend_Click(object sender, EventArgs e)
        {
            StringBuilder bul = new StringBuilder();
            bul.Append("数据计数:");
            bul.Append(dataCount.ToString());
            byte[] data = Encoding.Unicode.GetBytes(bul.ToString());

            sc.send(txtDestinationIP.Text, Convert.ToInt32(txtDestinationPort.Text), data);
            ++dataCount;
        }

        private void workTimer_Tick(object sender, EventArgs e)
        {
            btnSend_Click(null, null);
        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            SocketCtrl.stopListen();
        }

    }
}
