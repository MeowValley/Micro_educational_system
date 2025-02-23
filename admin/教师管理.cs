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
    public partial class 教师管理 : Form
    {
        
        public 教师管理()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < teacherlist.Rows.Count; i++)
            {
                try
                {
                    Method.updateteacher(teacherlist.Rows[i].Cells["tid"].Value.ToString(), teacherlist.Rows[i].Cells["tname"].Value.ToString(), teacherlist.Rows[i].Cells["tpassword"].Value.ToString(), teacherlist.Rows[i].Cells["tidcard"].Value.ToString(), teacherlist.Rows[i].Cells["sex"].Value.ToString(), teacherlist.Rows[i].Cells["temail"].Value.ToString(),teacherlist.Rows[i].Cells["tphone"].Value.ToString(),teacherlist.Rows[i].Cells["tage"].Value.ToString(),teacherlist.Rows[i].Cells["cid"].Value.ToString());
                }
                catch
                {

                }
            }
            MessageBox.Show("更新成功！");
        }

        private void 教师管理_Load(object sender, EventArgs e)
        {
            DataSet ds = Method.teacher_admin();
            teacherlist.DataSource = ds.Tables["teacher_admin"];
           
        }
    }
}
