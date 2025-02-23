using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Satelliteeducationsystem.admin
{
    public partial class 学生管理 : Form
    {
       
        public 学生管理()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < studentlist.Rows.Count; i++)
            {
                try
                {
                    Method.updatestudent(studentlist.Rows[i].Cells["sid"].Value.ToString(), studentlist.Rows[i].Cells["sname"].Value.ToString(), studentlist.Rows[i].Cells["spassword"].Value.ToString(), studentlist.Rows[i].Cells["sidcard"].Value.ToString(), studentlist.Rows[i].Cells["sex"].Value.ToString(), studentlist.Rows[i].Cells["semail"].Value.ToString(), studentlist.Rows[i].Cells["sphone"].Value.ToString(), studentlist.Rows[i].Cells["sage"].Value.ToString(), studentlist.Rows[i].Cells["cid"].Value.ToString(), studentlist.Rows[i].Cells["state"].Value.ToString());
                }
                catch
                {

                }
            }
            MessageBox.Show("更新成功！");
        }

        private void 学生管理_Load(object sender, EventArgs e)
        {
            DataSet ds = Method.student_admin();
            studentlist.DataSource = ds.Tables["student_admin"];
          
        }
    }
}
