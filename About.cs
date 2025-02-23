using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Sockets;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Satelliteeducationsystem
{
    public partial class About : Form
    {
        public string identity;
        public About(string identity)
        {
            InitializeComponent();
            this.identity = identity;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void About_Load(object sender, EventArgs e)
        {
            IPAddress[] ip = Dns.GetHostAddresses(Dns.GetHostName());
            foreach (IPAddress address in ip)
            {
                if (address.AddressFamily == AddressFamily.InterNetwork)
                {
                    label1.Text = address.ToString() + "\r\n";
                }
            }
            label3.Text = "当前端口:\t" + identity + "端";
        }
    }
}
