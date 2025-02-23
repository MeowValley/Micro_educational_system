using Sunny.UI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Forms;

namespace Satelliteeducationsystem.通知
{
    public partial class FrmNotice : Form
    {
        public string cid;
        public string identity;
        public string id;

        public FrmNotice()
        {
            InitializeComponent();
        }

        private void FrmNotice_Load(object sender, EventArgs e)
        {
            if (identity.Equals("学生"))
            {
               

                DataSet ds = Method.sysnotice();
                for (int i = 0; i < ds.Tables["notice"].Rows.Count; i++)
                {
                    sysnotice.Text += $"\t第{i + 1}条通知:\t" + ds.Tables["notice"].Rows[i][0].ToString() + "\n\n" + "\t\t\t\t\t\t\t时间：" + ds.Tables["notice"].Rows[i][1].ToString() + "\n";
                }
                if (cid==null)
                {
                    MessageBox.Show("您暂时未被分配班级，将无法查看班级公告，请联系管理员", "提醒", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
                else
                {
                    DataSet ds1 = Method.classnotice(cid);
                    for (int i = 0; i < ds1.Tables["classnotice"].Rows.Count; i++)
                    {
                        classnotice.Text += $"\t第{i + 1}条通知:\t" + ds1.Tables["classnotice"].Rows[i][0].ToString() + "\n\n" + "\t\t\t\t\t\t\t时间：" + ds1.Tables["classnotice"].Rows[i][1].ToString() + "\n";
                    }
                }
            }
            if (identity.Equals("教师"))
            {
                tabPage3.Visible = true;
            
            DataSet ds = Method.sysnotice();
            for (int i = 0; i < ds.Tables["notice"].Rows.Count; i++)
            {
                sysnotice.Text += $"\t第{i + 1}条通知:\t" + ds.Tables["notice"].Rows[i][0].ToString() + "\n\n" + "\t\t\t\t\t\t\t时间：" + ds.Tables["notice"].Rows[i][1].ToString() + "\n";
            }
            if (!Method.whether_teach_class(id))
            {
                MessageBox.Show("您暂时未被分配班级，将无法查看和发布班级公告，请联系管理员", "提醒", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            else
            {
                DataSet ds1 = Method.classnotice(cid);
                for (int i = 0; i < ds1.Tables["classnotice"].Rows.Count; i++)
                {
                    classnotice.Text += $"\t第{i + 1}条通知:\t" + ds1.Tables["classnotice"].Rows[i][0].ToString() + "\n\n" + "\t\t\t\t\t\t\t时间：" + ds1.Tables["classnotice"].Rows[i][1].ToString() + "\n";
                }
            }
            }


            if (identity.Equals("管理员"))
            {
                tabPage2.Visible = false;
                
                tabPage4.Visible = true;
            
            DataSet ds2 = Method.sysnotice();
            for (int i = 0; i < ds2.Tables["notice"].Rows.Count; i++)
            {
                    sysnotice.Text += $"\t第{i + 1}条通知:\t" + ds2.Tables["notice"].Rows[i][0].ToString() + "\n\n" + "\t\t\t\t\t\t\t时间：" + ds2.Tables["notice"].Rows[i][1].ToString() + "\n";
            }
            }




        }

        private void tabs1_MouseClick(object sender, MouseEventArgs e)
        {
            
        }

        private void tabPage3_Click(object sender, EventArgs e)
        {

        }

        private void send_Click(object sender, EventArgs e)
        {
            if (cid == null)
            {
                MessageBox.Show("您暂时未被分配班级，无法查看和发布班级公告，请联系管理员", "提醒", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                if (Method.insertclassnotice(cid,richTextBox1.Text,id))
                    {
                    MessageBox.Show("公告发布成功！");
                    classnotice.Text = "";
                    DataSet ds1 = Method.classnotice(cid);
                    for (int i = 0; i < ds1.Tables["classnotice"].Rows.Count; i++)
                        classnotice.Text += $"\t第{i + 1}条通知:\t" + ds1.Tables["classnotice"].Rows[i][0].ToString() + "\n\n" + "\t\t\t\t\t\t\t时间：" + ds1.Tables["classnotice"].Rows[i][1].ToString() + "\n";

                }
                else
                {
                    MessageBox.Show("未知错误，请检查数据库!");
                }
                
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (Method.insertsystemnotice(id, richTextBox2.Text))
            {
                MessageBox.Show("公告发布成功！");
                DataSet ds1 = Method.sysnotice();
                sysnotice.Text = "";
                for (int i = 0; i < ds1.Tables["notice"].Rows.Count; i++)
                    sysnotice.Text += $"\t第{i + 1}条通知:\t" + ds1.Tables["notice"].Rows[i][0].ToString() + "\n\n" + "\t\t\t\t\t\t\t时间：" + ds1.Tables["notice"].Rows[i][1].ToString() + "\n";

            }
            else
            {
                MessageBox.Show("未知错误，请检查数据库!");
            }
        }

        private void tabs1_SelectedIndexChanged(object sender, AntdUI.IntEventArgs e)
        {

        }
    }
}
