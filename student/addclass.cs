using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Satelliteeducationsystem.student
{
    public partial class addclass : Form
    {
        private string sid;
        private string cid;
        private string account;
        private string identity;
        private string name;
        public addclass(string sid, string account, string identity,string name)
        {
            InitializeComponent();
            this.sid = sid;
            this.account = account;
            this.identity = identity;
            this.name = name;

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            MessageBox.Show("班级编号是由教师发布给学生唯一编号，用于加入班级使用！如果没有编号请联系您的教师。");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (Method.addclass(textBox1.Text,sid,name))
            {
                MessageBox.Show($"您已成功加入班级！编号为{textBox1.Text}");
                
                
            }
            else
            {
                MessageBox.Show("加入失败！无效编号"+textBox1.Text);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            studentMainForm studentMainForm = new studentMainForm(identity,account);
            this.Close();
            studentMainForm.Show();
        }
    }
}
