﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Server
{
    public partial class FrmServer : Form
    {

        private Server s;
        public FrmServer()
        {
            InitializeComponent();
        }

        private void FrmServer_Load(object sender, EventArgs e)
        {
            btnStart.Enabled = true;
            btnStop.Enabled = false;
            lblStatus.ForeColor = System.Drawing.Color.Red;


        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            try
            {
                s = new Server();
                s.Start();
                Thread thread = new Thread(s.Listen);
                thread.IsBackground = true;
                thread.Start();
                btnStart.Enabled = false;
                btnStop.Enabled = true;
                lblStatus.Text = "Status: Server is running.";
                lblStatus.ForeColor = System.Drawing.Color.DarkOliveGreen;
                s.Users.ListChanged += Users_ListChanged;
            }
            catch (SocketException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Users_ListChanged(object sender, ListChangedEventArgs e)
        {
            dgvClients.Invoke(new Action(() => dgvClients.DataSource = s.Users.ToList()));
        }

        private void FrmServer_FormClosed(object sender, FormClosedEventArgs e)
        {
            Environment.Exit(0);
        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            s.Stop();
            btnStart.Enabled = true;
            btnStop.Enabled = false;
            lblStatus.Text = "Status: Server not running.";
            lblStatus.ForeColor = System.Drawing.Color.Red;
        }
    }
}
