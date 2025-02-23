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
    public partial class register : Form
    {
        public string codestate="0";
        public register()
        {
            InitializeComponent();
        }
        public  register(string codestate)
        {
            InitializeComponent();
            this.codestate = codestate;
        }

        private void register_Load(object sender, EventArgs e)
        {
            
             if(codestate.Equals("1"))
            {
                Identity.Text = "教师";
            }
            else if (Identity.Equals("2"))
            {
                Identity.Text = "管理员";
            }
            else if(codestate.Equals("0"))
            {
                Identity.Text = "学生";
            }
        }

        private void next_Click(object sender, EventArgs e)
        {
           
            if (UserName.Text.Equals("") || Password.Text.Equals("") || FirmPassword.Text.Equals("") || Email.Text.Equals("") || Phone.Text.Equals(""))
            {
                MessageBox.Show("以上字段不能为空", "WARNING", MessageBoxButtons.OK);
            }
            else
            {
                string identity = Identity.Text;
                string username = UserName.Text;
                string sex = "";
                if (Meal.Checked)
                {
                    sex = "男";
                }
                else if (Femael.Checked)
                {
                    sex = "女";
                }
                string age = Age.Text;
                string idcard = IDcard.Text;
                string password = Password.Text;
                string email = Email.Text;
                string phone = Phone.Text;

                if (identity.Equals("学生"))
                {
                    if (!Method.query_s_user_exist(phone, email, idcard))
                    {
                        if (Method.insert_s_user(username, sex, age, idcard, password, email, phone) & FirmPassword.Text.Equals(password))
                        {
                            MessageBox.Show(string.Format("注册成功，您的信息如下：\n用户名：{0}\n性别：{1}\n手机号：{2}\n电子邮箱：{3}\n\n您的身份为{4}", username, sex, phone, email, identity));
                        }
                        else
                        {
                            MessageBox.Show("出现未知错误，如您的两次密码不一致等");
                        }
                    }
                    else
                    {
                        MessageBox.Show("该用户已存在，请勿重复注册！！！", "警告", MessageBoxButtons.OK);

                    }
                }
                else if (identity.Equals("教师"))
                {
                    
                    if (!Method.query_t_user_exist(phone, email, idcard))
                    {
                        if (Method.insert_t_user(username, sex, age, idcard, password, email, phone) & FirmPassword.Text.Equals(password))
                        {
                            MessageBox.Show(string.Format("注册成功，您的信息如下：\n用户名：{0}\n性别：{1}\n手机号：{2}\n电子邮箱：{3}\n\n您的身份为{4}", username, sex, phone, email, identity));
                        }
                        else
                        {
                            MessageBox.Show("出现未知错误，如您的两次密码不一致等");
                        }
                    }
                    else
                    {
                        MessageBox.Show("该用户已存在，请勿重复注册！！！", "警告", MessageBoxButtons.OK);
                    }
                }
                else if (identity.Equals("管理员"))
                {
                    if (!Method.query_admin_exist(phone, email, idcard))
                    {
                        if (Method.insert_admin(username, password, idcard, email, phone) & FirmPassword.Text.Equals(password))
                        {
                            MessageBox.Show(string.Format("注册成功，您的信息如下：\n用户名：{0}\n手机号：{1}\n电子邮箱：{2}\n\n您的身份为{3}", username, phone, email, identity));
                        }
                        else
                        {
                            MessageBox.Show("出现未知错误,如您的两次密码不一致等");
                        }
                    }
                    else
                    {
                        MessageBox.Show("该用户已存在，请勿重复注册！！！", "警告", MessageBoxButtons.OK);
                    }
                }
            }





        }

        private void back_Click(object sender, EventArgs e)
        {
            this.Close();
            Login login = new Login();
            login.ShowDialog();
        }

        private void Identity_SelectionChangeCommitted(object sender, EventArgs e)
        {

        }

        private void Identity_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (Identity.Text.Equals("教师")&&codestate.Equals("0"))
            {
                code code = new code(Identity.Text,"教师");
                this.Hide();
                code.ShowDialog();
                
            }
            else if(Identity.Text.Equals("管理员")&&codestate.Equals("0"))
            {
                code code = new code(Identity.Text,"管理员");
                this.Hide();
                code.ShowDialog();
                
            }
        }
    }
}
