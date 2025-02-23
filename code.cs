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
    public partial class code : Form
    {
        private string identity;
        private string type;
        public code(string identity, string type)
        {
            InitializeComponent();
            this.identity = identity;
            this.type = type;   
        }

        private void button2_Click(object sender, EventArgs e)
        {
            register register=new register();
            this.Close();
            
            register.Show();

        }

        private void code_Load(object sender, EventArgs e)
        {
            label1.Text += identity;
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            MessageBox.Show("密钥是在您注册教师或者管理员身份时验证身份时输入的，由最高级别管理员下发！如果您没有此密钥，请联系最高权限管理员！");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (Method.VerificationCode(textBox2.Text,type))
            {
                MessageBox.Show("密钥验证成功！您选择的注册身份为:"+type);
               
                if (type.Equals("教师"))
                {
                    register register = new register("1");
                    this.Close();
                    register.Show();
                }
                else if(type.Equals("管理员"))
                {
                    register register = new register("2");
                    this.Close();
                    register.Show();
                }
                
            }
            else
            {
                MessageBox.Show("无效密钥！"+textBox2.Text);
            }
        }
    }
}
