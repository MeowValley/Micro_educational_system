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
    public partial class manageclass : Form
    {
        private string cid;
        public manageclass(string cid)
        {
            InitializeComponent();
            this.cid = cid;
        }

        private void manageclass_Load(object sender, EventArgs e)
        {
            DataSet ds = Method.course(cid);
            DataSet ds2 =Method.course_cname(cid);
            Course.DataSource = ds.Tables["course"];
            uiLabel1.Text = "当前课表隶属班级：" + ds2.Tables["cname"].Rows[0][0];
            if (Method.bzexist(cid))
            {

            }
            else
            {
                MessageBox.Show("当前课表暂无备注，已自动创建");
                Method.coursebz(cid);
            }
            
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            for (int i =0; i < Course.Rows.Count; i++)
            {
                try
                {
                    Method.updatecourse(cid, Course.Rows[i].Cells["星期一"].Value.ToString(), Course.Rows[i].Cells["星期二"].Value.ToString(), Course.Rows[i].Cells["星期三"].Value.ToString(), Course.Rows[i].Cells["星期四"].Value.ToString(), Course.Rows[i].Cells["星期五"].Value.ToString(), Course.Rows[i].Cells["星期六"].Value.ToString(), Course.Rows[i].Cells["星期日"].Value.ToString(), Course.Rows[i].Cells["时间"].Value.ToString());

                }
                catch
                {
                    
                }
                
            }
            MessageBox.Show("更新成功");
        }

        private void uiRichTextBox1_MouseDown(object sender, MouseEventArgs e)
        {
            uiRichTextBox1.Text = "";
        }

        private void uiButton1_Click(object sender, EventArgs e)
        {
            if (Method.updatebz(uiRichTextBox1.Text, cid))
            {
                MessageBox.Show("更新成功！");
            }
            else
            {
                MessageBox.Show("发生未知错误，更新失败");
            }
        }
    }
}
