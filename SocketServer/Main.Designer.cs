namespace SocketServer
{
    partial class Main
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.gbMsg = new System.Windows.Forms.GroupBox();
            this.txtMsg = new System.Windows.Forms.TextBox();
            this.btnStart = new System.Windows.Forms.Button();
            this.btnStop = new System.Windows.Forms.Button();
            this.btnSend = new System.Windows.Forms.Button();
            this.lblDestinationHost = new System.Windows.Forms.Label();
            this.txtDestinationIP = new System.Windows.Forms.TextBox();
            this.lblDestinationPort = new System.Windows.Forms.Label();
            this.txtDestinationPort = new System.Windows.Forms.TextBox();
            this.workTimer = new System.Windows.Forms.Timer(this.components);
            this.gbMsg.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbMsg
            // 
            this.gbMsg.Controls.Add(this.txtMsg);
            this.gbMsg.Dock = System.Windows.Forms.DockStyle.Right;
            this.gbMsg.Location = new System.Drawing.Point(412, 0);
            this.gbMsg.Name = "gbMsg";
            this.gbMsg.Size = new System.Drawing.Size(475, 279);
            this.gbMsg.TabIndex = 0;
            this.gbMsg.TabStop = false;
            this.gbMsg.Text = "信息";
            // 
            // txtMsg
            // 
            this.txtMsg.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtMsg.Location = new System.Drawing.Point(3, 17);
            this.txtMsg.Multiline = true;
            this.txtMsg.Name = "txtMsg";
            this.txtMsg.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtMsg.Size = new System.Drawing.Size(469, 259);
            this.txtMsg.TabIndex = 0;
            // 
            // btnStart
            // 
            this.btnStart.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnStart.Location = new System.Drawing.Point(111, 216);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(75, 23);
            this.btnStart.TabIndex = 1;
            this.btnStart.Text = "启   动";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // btnStop
            // 
            this.btnStop.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnStop.Location = new System.Drawing.Point(286, 219);
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(75, 23);
            this.btnStop.TabIndex = 2;
            this.btnStop.Text = "停    止";
            this.btnStop.UseVisualStyleBackColor = true;
            this.btnStop.Click += new System.EventHandler(this.btnStop_Click);
            // 
            // btnSend
            // 
            this.btnSend.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnSend.Location = new System.Drawing.Point(111, 166);
            this.btnSend.Name = "btnSend";
            this.btnSend.Size = new System.Drawing.Size(75, 23);
            this.btnSend.TabIndex = 3;
            this.btnSend.Text = "发送数据";
            this.btnSend.UseVisualStyleBackColor = true;
            this.btnSend.Click += new System.EventHandler(this.btnSend_Click);
            // 
            // lblDestinationHost
            // 
            this.lblDestinationHost.AutoSize = true;
            this.lblDestinationHost.Location = new System.Drawing.Point(67, 45);
            this.lblDestinationHost.Name = "lblDestinationHost";
            this.lblDestinationHost.Size = new System.Drawing.Size(77, 12);
            this.lblDestinationHost.TabIndex = 4;
            this.lblDestinationHost.Text = "目标主机IP：";
            // 
            // txtDestinationIP
            // 
            this.txtDestinationIP.Location = new System.Drawing.Point(150, 42);
            this.txtDestinationIP.Name = "txtDestinationIP";
            this.txtDestinationIP.Size = new System.Drawing.Size(203, 21);
            this.txtDestinationIP.TabIndex = 5;
            this.txtDestinationIP.Text = "127.0.0.1";
            // 
            // lblDestinationPort
            // 
            this.lblDestinationPort.AutoSize = true;
            this.lblDestinationPort.Location = new System.Drawing.Point(55, 80);
            this.lblDestinationPort.Name = "lblDestinationPort";
            this.lblDestinationPort.Size = new System.Drawing.Size(89, 12);
            this.lblDestinationPort.TabIndex = 6;
            this.lblDestinationPort.Text = "目标主机端口：";
            // 
            // txtDestinationPort
            // 
            this.txtDestinationPort.Location = new System.Drawing.Point(150, 77);
            this.txtDestinationPort.Name = "txtDestinationPort";
            this.txtDestinationPort.Size = new System.Drawing.Size(203, 21);
            this.txtDestinationPort.TabIndex = 7;
            this.txtDestinationPort.Text = "5000";
            // 
            // workTimer
            // 
            this.workTimer.Tick += new System.EventHandler(this.workTimer_Tick);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(887, 279);
            this.Controls.Add(this.txtDestinationPort);
            this.Controls.Add(this.lblDestinationPort);
            this.Controls.Add(this.txtDestinationIP);
            this.Controls.Add(this.lblDestinationHost);
            this.Controls.Add(this.btnSend);
            this.Controls.Add(this.btnStop);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.gbMsg);
            this.Name = "Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.gbMsg.ResumeLayout(false);
            this.gbMsg.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gbMsg;
        private System.Windows.Forms.TextBox txtMsg;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Button btnStop;
        private System.Windows.Forms.Button btnSend;
        private System.Windows.Forms.Label lblDestinationHost;
        private System.Windows.Forms.TextBox txtDestinationIP;
        private System.Windows.Forms.Label lblDestinationPort;
        private System.Windows.Forms.TextBox txtDestinationPort;
        private System.Windows.Forms.Timer workTimer;
    }
}

