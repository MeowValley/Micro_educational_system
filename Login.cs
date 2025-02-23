using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Satelliteeducationsystem
{
    public partial class Login : Form
    {
        private string code;
        public Login()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            register re = new register();
            re.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("即将退出登录端！", "退出客户端", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
                this.Close();
            else
            {

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (ID.Text.Equals("(请输入手机号,身份证号或电子邮箱)") || Password.Text.Equals("") || codebox.Text.Equals("") || Identity.Text.Equals(""))
            {
                MessageBox.Show("请输入您的账户,密码,身份或者验证码！！", "Warnning", MessageBoxButtons.OK);
            }
            else
            {
                if (Identity.Text.Equals("学生") & Method.query_s_user_login(ID.Text, ID.Text, Password.Text) & codebox.Text.Equals(code))
                {
                    studentMainForm mainForm = new studentMainForm(Identity.Text, ID.Text);
                    this.Hide();
                    mainForm.ShowDialog();
                }
                else if (Identity.Text.Equals("教师") & Method.query_t_user_login(ID.Text, ID.Text, Password.Text) & codebox.Text.Equals(code))
                {

                    teacher.teacherMainForm mainForm = new teacher.teacherMainForm(Identity.Text, ID.Text);
                    this.Hide();
                    mainForm.ShowDialog();
                }
                else if (Identity.Text.Equals("管理员") & Method.query_admin_login(ID.Text, ID.Text, Password.Text) & codebox.Text.Equals(code))
                {

                    admin.adminMainForm mainForm = new admin.adminMainForm(Identity.Text, ID.Text);
                    this.Hide();
                    mainForm.ShowDialog();
                }
                else if (!codebox.Text.Equals(code))
                {
                    MessageBox.Show("验证码错误", "attention", MessageBoxButtons.OK);
                }
                else
                {
                    MessageBox.Show("密码错误！！", "attention", MessageBoxButtons.OK);
                }

            }
        }

        private void ID_MouseClick(object sender, MouseEventArgs e)
        {
            ID.Text = "";
            ID.ForeColor = Color.Black;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            code = Method.GenerateVerificationCode();
            Method.QRcodegenerate(code);
            pictureBox1.ImageLocation = "验证码.png";
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            ForgetPwd forgetPwd = new ForgetPwd();
            this.Hide();
            forgetPwd.Show();
        }
    }
}
