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

namespace Satelliteeducationsystem.通知
{
    public partial class flist : Form
    {
        private string id;
        public flist(string id)
        {
            InitializeComponent();
            this.id = id;
        }

        private void flist_Load(object sender, EventArgs e)
        {
            //string myIP = "";
            //IPAddress[] ip = Dns.GetHostAddresses(Dns.GetHostName());
            //foreach (IPAddress address in ip)
            //{
            //    if (address.AddressFamily == AddressFamily.InterNetwork)
            //    {
            //        myIP = address.ToString() + "\r\n";
            //    }
            //}
            DataSet ds = Method.flist(id);
            list.DataSource = ds.Tables["flist"];
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //string myIP = "";
            //IPAddress[] ip = Dns.GetHostAddresses(Dns.GetHostName());
            //foreach (IPAddress address in ip)
            //{
            //    if (address.AddressFamily == AddressFamily.InterNetwork)
            //    {
            //        myIP = address.ToString() + "\r\n";
            //    }
            //}
            for (int i = 0;i<list.Rows.Count;i++)
            {
                try
                {
                    Method.updateflist(list.Rows[i].Cells["IP"].Value.ToString(), list.Rows[i].Cells["备注"].Value.ToString(), id);
                }
                catch 
                { 
                }
                
            }
            MessageBox.Show("更新成功！");
        }
    }
}
