using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Satelliteeducationsystem.teacher
{
    public partial class managestudent : Form
    {
        private string cid;
        public managestudent(string cid)
        {
            InitializeComponent();
            this.cid = cid;
        }

        private void managestudent_Load(object sender, EventArgs e)
        {
            DataSet ds = Method.managestudent(cid);
            studentlist.DataSource = ds.Tables["student"];
            DataSet ds2 = Method.course_cname(cid);
            uiLabel1.Text = "当前数据隶属班级：" + ds2.Tables["cname"].Rows[0][0];

        }

        private void button1_Click(object sender, EventArgs e)
        {
            for(int i = 0; i < studentlist.Rows.Count; i++)
            {
                try
                {
                    Method.updatestudent(studentlist.Rows[i].Cells["sid"].Value.ToString(), studentlist.Rows[i].Cells["sname"].Value.ToString(), studentlist.Rows[i].Cells["spassword"].Value.ToString(), studentlist.Rows[i].Cells["sidcard"].Value.ToString(), studentlist.Rows[i].Cells["sex"].Value.ToString(), studentlist.Rows[i].Cells["semail"].Value.ToString(), studentlist.Rows[i].Cells["sphone"].Value.ToString(), studentlist.Rows[i].Cells["sage"].Value.ToString(), studentlist.Rows[i].Cells["state"].Value.ToString());
                }
                catch
                {

                }
            }
            MessageBox.Show("更新成功！");
        }
    }
}
