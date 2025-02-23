using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Satelliteeducationsystem.admin
{
    public partial class 管理员管理 : Form
    {
        public 管理员管理()
        {
            InitializeComponent();
        }

        private void 管理员管理_Load(object sender, EventArgs e)
        {
            DataSet ds=Method.admin_admin();
            adminlist.DataSource = ds.Tables["admin"];
        }

        private void button1_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < adminlist.Rows.Count; i++)
            {
                try
                {
                    Method.updateadmin(adminlist.Rows[i].Cells["aid"].Value.ToString(), adminlist.Rows[i].Cells["aname"].Value.ToString(), adminlist.Rows[i].Cells["apassword"].Value.ToString(), adminlist.Rows[i].Cells["aidcard"].Value.ToString(), adminlist.Rows[i].Cells["aemail"].Value.ToString(), adminlist.Rows[i].Cells["aphone"].Value.ToString(), adminlist.Rows[i].Cells["state"].Value.ToString());
                }
                catch
                {

                }
            }
            MessageBox.Show("更新成功！");
        }
    }
}
