using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using Satelliteeducationsystem.通知;
using System.Security.Cryptography;
using System.Net.Sockets;

namespace Satelliteeducationsystem.teacher
{
    public partial class teacherMainForm : Form
    {
        private Timer Timer1;
        private int currentIndex = 0; // 当前图片索引
        private int imageCount;       // 图片总数
        public string identity;
        public string account;
        public string tid;
        public string cid;
        public string name;
        private TcpListener tcpListener;

        public teacherMainForm(string identity, string account)
        {
            InitializeComponent();
            this.identity = identity;
            this.account = account;
            imageCount = carousel1.Image.Count;
            tcpListener = new TcpListener(888);//创建监听对象
            // 初始化计时器
            Timer1 = new Timer();
            Timer1.Interval = 3000; // 每隔3秒切换图片
            Timer1.Tick += timer2_Tick; // 绑定计时器事件


        }
        public teacherMainForm()
        {
            InitializeComponent();
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

        private void teacherMainForm_Load(object sender, EventArgs e)
        {
            // 窗体加载时启动走马灯
            StartCarousel();
            status1.Text = "当前登录身份:" + identity;

            button1.Visible = false;
            label1.Visible = false;
            
            label3.Visible = false;
            label4.Visible = false;
            label5.Visible = false;
            label6.Visible = false;
            label7.Visible = false;
            label8.Visible = false;
            label9.Visible = false;
            teacherinfo t = Method.query_t_user_info(account);
            this.tid = t.tid;
            this.cid = t.cid;
            this.name = t.tname;
            label1.Text += t.tid;
         
            label3.Text += t.tage;
            label4.Text += t.tphone;
            label5.Text += t.tidcard;
            label6.Text += t.tname;
            label7.Text += t.sex;
            label8.Text += t.temail;
            username.Text += name;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            stuMenu.Visible = true;
            carousel1.Visible = true;
            button1.Visible = false;
            label1.Visible = false;
           
            label3.Visible = false;
            label4.Visible = false;
            label5.Visible = false;
            label6.Visible = false;
            label7.Visible = false;
            label8.Visible = false;
            label9.Visible = false;
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            carousel1.Visible = false;
            stuMenu.Visible = false;
            label1.Visible = true;
            button1.Visible = true;
            label3.Visible = true;
            label4.Visible = true;
            label5.Visible = true;
            label6.Visible = true;
            label7.Visible = true;
            label8.Visible = true;
            label9.Visible = true;
        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            teaModifyPwd teaModifyPwd = new teaModifyPwd(account);
            teaModifyPwd.ShowDialog();
        }

        private void 我的班级ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void 公告ToolStripMenuItem_Click(object sender, EventArgs e)
        {
             FrmNotice notice = new FrmNotice();        
                notice.cid = cid;
            notice.id = tid;
            notice.identity = identity;
                notice.ShowDialog();
           
            
        }

        private void 公共留言板ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            通知.Message message=new 通知.Message();
            message.ShowDialog();
        }

        private void 文件中心ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (fileoperation.creat_directory(tid))
            {
                MessageBox.Show("文件中心资源配置完成!", "成功", MessageBoxButtons.OK);
                FileCenter filecenter = new FileCenter(tid, "个人文件");
                filecenter.ShowDialog();
            }
            else
            {
                MessageBox.Show("文件中心资源配置失败!", "失败", MessageBoxButtons.OK);
            }
        }

        private void 关于本系统ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            About a = new About(identity);
            a.ShowDialog();
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

        private void 退出登录ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("用户:" + account + "\n您即将退出客户端", "提醒", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {

                Login login = new Login();
                this.Close();

                login.Show();

            }
        }

        private void 学生管理ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!Method.whether_teach_class(tid))
            {
                MessageBox.Show("您暂时未被分配班级，请联系管理员", "提醒", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
               managestudent managestudent=new managestudent(cid);
                managestudent.ShowDialog();
            }
        }

        private void 课表管理ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!Method.whether_teach_class(tid))
            {
                MessageBox.Show("您暂时未被分配班级，请联系管理员", "提醒", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                if (Method.courseexist(cid))
                {
                    manageclass manageclass = new manageclass(cid);
                    manageclass.ShowDialog();
                }
                else
                {
                    MessageBox.Show("未检测到课表，已为您创建了一份空课表！");
                    Method.CourseDesign(cid);
                    manageclass manageclass = new manageclass(cid);
                    manageclass.ShowDialog();
                }
            }
        }

        private void 成绩管理ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            teacher.score score = new teacher.score(cid);
            score.ShowDialog();
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            // 切换到下一张图片
            currentIndex = (currentIndex + 1) % imageCount; // 循环切换
            carousel1.SelectIndex = currentIndex;
        }

        private void 聊天ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            chat chat=new chat(tid, tcpListener);
            chat.ShowDialog();
        }

        private void 空闲教室ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            classroom classroom=new classroom();
            classroom.ShowDialog();
        }

        private void 账户管理ToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
