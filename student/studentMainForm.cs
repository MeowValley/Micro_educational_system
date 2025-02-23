using Satelliteeducationsystem.student;
using Satelliteeducationsystem.通知;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Satelliteeducationsystem
{
    public partial class studentMainForm : Form
    {
        private Timer Timer1;
        private int currentIndex = 0; // 当前图片索引
        private int imageCount;       // 图片总数
        public string identity;
        public string account;
        public string sid;
        public string cid;
        public string name;
        public string cname;
        private TcpListener tcpListener;
        public studentMainForm(string identity, string account)
        {
            InitializeComponent();
            this.identity = identity;
            this.account = account;
            imageCount = carousel1.Image.Count;

            // 初始化计时器
            Timer1 = new Timer();
            Timer1.Interval = 3000; // 每隔3秒切换图片
            Timer1.Tick += timer1_Tick; // 绑定计时器事件
            tcpListener = new TcpListener(888);//创建监听对象

        }
        private void StartCarousel()
        {
            // 开始循环播放
            if (imageCount > 0) // 确保有图片
            {
                Timer1.Start();
            }
            else
            {
                MessageBox.Show("没有可播放的图片！");
            }
        }

        private void StopCarousel()
        {
            // 停止循环播放
            Timer1.Stop();
        }

        public studentMainForm()
        {
            InitializeComponent();
            
           
        }

        private void studentMainForm_Load(object sender, EventArgs e)
        {

            // 窗体加载时启动走马灯
            StartCarousel();
            status1.Text = "当前登录身份:" + identity;
            
            button1.Visible = false;
            label1.Visible = false;
            label2.Visible = false;
            label3.Visible = false;
            label4.Visible = false;
            label5.Visible = false;
            label6.Visible = false;
            label7.Visible = false;
            label8.Visible = false;
            label9.Visible = false;
            studentinfo s = Method.query_s_user_info(account);
            this.sid = s.sid;
            this.cid = s.cid;
            this.name = s.sname;
            this.cname=s.cname;
            label1.Text += s.sid;
            label2.Text += s.cname;
            label3.Text += s.sage;
            label4.Text += s.sphone;
            label5.Text += s.sidcard;
            label6.Text += s.sname;
            label7.Text += s.sex;
            label8.Text += s.semail;
            username.Text += name;
        }

        private void 关于本系统ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            About a = new About(identity);
            a.ShowDialog();
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {


            carousel1.Visible = false;
            stuMenu.Visible = false;
            label1.Visible = true;
            button1.Visible = true;
            label2.Visible = true;
            label3.Visible = true;
            label4.Visible = true;
            label5.Visible = true;
            label6.Visible = true;
            label7.Visible = true;
            label8.Visible = true;
            label9.Visible = true;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            stuMenu.Visible = true;
            carousel1.Visible=true;
            button1.Visible = false;
            label1.Visible = false;
            label2.Visible = false;
            label3.Visible = false;
            label4.Visible = false;
            label5.Visible = false;
            label6.Visible = false;
            label7.Visible = false;
            label8.Visible = false;
            label9.Visible = false;
        }

        private void 退出登录ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("用户:" + account + "\n您即将退出客户端", "提醒", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {

                Login login = new Login();
                this.Close();

                login.Show();

            }
        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            stuModifyPwd stuModifyPwd = new stuModifyPwd(account);
            stuModifyPwd.ShowDialog();
        }

        private void 文件中心ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (fileoperation.creat_directory(sid))
            {
                MessageBox.Show("文件中心资源配置完成!", "成功", MessageBoxButtons.OK);
                FileCenter filecenter = new FileCenter(sid, "个人文件");
                filecenter.ShowDialog();
            }
            else
            {
                MessageBox.Show("文件中心资源配置失败!", "失败", MessageBoxButtons.OK);
            }
        }

        private void 提交作业ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (cid.Equals("0"))
            {
                MessageBox.Show("您暂时未加入任何班级!");
            }
            else
            {
            FileCenter filecenter = new FileCenter(sid,"作业");
            filecenter.ShowDialog();
            }
                
        }

      

        private void 公共留言板ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            通知.Message message = new 通知.Message();
            message.ShowDialog();
        }

        private void 公告ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmNotice frmNotice = new FrmNotice();
            frmNotice.cid = cid;
            frmNotice.identity = identity;
            frmNotice.ShowDialog();
        }

        private void toolStripMenuItem3_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.paisi.edu.cn/html/988/");
        }

        private void 关于本校ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AboutSchool aboutSchool = new AboutSchool();
            aboutSchool.ShowDialog();
        }

        private void toolStripMenuItem4_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.paisi.edu.cn");
        }

        private void 课表ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Method.courseexist(cid))
            {
                if (MessageBox.Show("绘制课表可能会出现卡顿或延迟，点击确认后就可以开始了哦，请耐心等待。。。", "ATTENTION", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
                {
                MyCourse myCourse = new MyCourse(cid);
                 myCourse.ShowDialog();
             }
            }
            else
            {
                MessageBox.Show("课表暂未公布，无法查看");
            }
                
            
        }

        private void 成绩ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if ((Method.state(sid) == 0)||(Method.state(sid) == 2))
            {
                MessageBox.Show($"成绩未开放查询，请等待！", "ATTEMTION", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                student.score score=new student.score(sid,cid);
                score.ShowDialog();
            }
        }

        private void 教师ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (cid.Equals("0"))
            {
                MessageBox.Show("您暂时未加入任何班级!");
            }
            else
            {
               DataSet ds= Method.classteacherinfo(cid);
                MessageBox.Show($"班级\t{cname}的教师信息如下:\n姓名：{ds.Tables["classteacherinfo"].Rows[0][0].ToString()}\n年龄：{ds.Tables["classteacherinfo"].Rows[0][1].ToString()}\n性别：{ds.Tables["classteacherinfo"].Rows[0][2].ToString()}\n电子邮箱：{ds.Tables["classteacherinfo"].Rows[0][3].ToString()}\n手机号：{ds.Tables["classteacherinfo"].Rows[0][4].ToString()}");
            }
        }

        private void 我的班级ToolStripMenuItem_Click(object sender, EventArgs e)
        {
          
        }

      

        private void 查看作业ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (cid.Equals("0"))
            {
                MessageBox.Show("您暂时未加入任何班级!");
            }           
            else
            {
                if (fileoperation.creat_homework(cid))
                {
                    MessageBox.Show("作业管理中心配置完成！");
                    homework homework = new homework(cid, sid);
                    homework.ShowDialog();
                }
                else
                {
                    MessageBox.Show("一个意外错误导致您无法继续~");
                }
            }
            
        }

        private void 加入班级ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            addclass addclass=new addclass(sid,account,identity,name);    
             this.Hide();
            addclass.ShowDialog();
            
        }

        private void 退出当前班级ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (cid.Equals("0"))
            {
                MessageBox.Show("您暂时未加入任何班级!");
            }
            else
            {

                if (MessageBox.Show($"您确认退出编号为:{cid}的班级吗?", "警告", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
                {
                    if (Method.addclass("0", sid,name))
                    {
                        MessageBox.Show("退出成功!");
                        this.cid = "0";
                    }
                }

            }
           
        }

        private void timer1_Tick(object sender, EventArgs e)
        {


            // 切换到下一张图片
            currentIndex = (currentIndex + 1) % imageCount; // 循环切换
            carousel1.SelectIndex = currentIndex;


        }

        private void 聊天ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            chat chat = new chat(sid,tcpListener);
            chat.ShowDialog();
        }

        private void 空闲教室查询ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            classroom classroom = new classroom();
            classroom.ShowDialog();
        }
    }
}
