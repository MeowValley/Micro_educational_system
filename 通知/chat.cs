using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Satelliteeducationsystem.通知
{
    public partial class chat : Form
    {
        private Thread td;     //声明线程对象
        private TcpListener tcpListener;    //声明监听对象
        private static string message = "";  //记录发送的消息
        private string id;
        public chat(string id, TcpListener tcpListener)
        {
            InitializeComponent();
            this.id = id;
            this.tcpListener = tcpListener;
        }
        private void StartListen()
        {
            Random random = new Random();
            message = "";//清空消息
            
            tcpListener.Start();//开始监听
            while (true)
            {
                TcpClient tcpclient = tcpListener.AcceptTcpClient();//接受连接请求
                NetworkStream nstrean= tcpclient.GetStream();//获取数据流
                byte[] mbyte = new byte[1024];//建立缓存
                int i = nstrean.Read(mbyte, 0, mbyte.Length);//将数据流写入缓存
                message = Encoding.Default.GetString(mbyte, 0, i);//记录发送的消息

            }
        }
        private void chat_Load(object sender, EventArgs e)
        {
            td = new Thread(new ThreadStart(this.StartListen));   //创建线程类对象
            td.Start();                                          //启动线程
            timer1.Start();                                 //启动计时器
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                IPAddress[] ip = Dns.GetHostAddresses(Dns.GetHostName());//获取主机名
                string strmsg = "" + txtName.Text + "(" + ip[1].ToString() + ")" + DateTime.Now.ToLongTimeString() + "\n" + " " + this.rtbSend.Text + "\n";//定义消息格式
                TcpClient client = new TcpClient(txtIP.Text, 888);//创建TcpClient对象
                NetworkStream netstream = client.GetStream();//创建NetworkStream网络流对象
                StreamWriter wstream = new StreamWriter(netstream, Encoding.Default);
                wstream.WriteLine(strmsg);//将消息写入网络流
                wstream.Flush();//释放网络流对象
                wstream.Close();//关闭网络流对象
                client.Close();//关闭TcpClient
                rtbContent.AppendText(strmsg);//将发送的消息添加到文本框
                rtbContent.ScrollToCaret();//自动滚动文本框的滚动条
                rtbSend.Clear();//清空发送消息文本框
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (message != "")
            {
                rtbContent.AppendText(message);//将接收到的消息添加到文本框
                rtbContent.ScrollToCaret();//自动滚动文本框的滚动条
                message = "";//清空消息
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (this.tcpListener != null)
            {
                tcpListener.Stop();
            }
            if (td != null)
            {
                if (td.ThreadState == ThreadState.Running)
                {
                    td.Abort();
                }
            }
            this.Close();
        }

        private void rtbSend_MouseDown(object sender, MouseEventArgs e)
        {
            rtbSend.Text = "";
        }

        

        private void rtbSend_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Control && e.KeyCode == Keys.Enter) // 检测 Ctrl+Enter
            {
                try
                {
                    IPAddress[] ip = Dns.GetHostAddresses(Dns.GetHostName());//获取主机名
                    string strmsg = "" + txtName.Text + "(" + ip[1].ToString() + ")" + DateTime.Now.ToLongTimeString() + "\n" + " " + this.rtbSend.Text + "\n";//定义消息格式
                    TcpClient client = new TcpClient(txtIP.Text, 888);//创建TcpClient对象
                    NetworkStream netstream = client.GetStream();//创建NetworkStream网络流对象
                    StreamWriter wstream = new StreamWriter(netstream, Encoding.Default);
                    wstream.WriteLine(strmsg);//将消息写入网络流
                    wstream.Flush();//释放网络流对象
                    wstream.Close();//关闭网络流对象
                    client.Close();//关闭TcpClient
                    rtbContent.AppendText(strmsg);//将发送的消息添加到文本框
                    rtbContent.ScrollToCaret();//自动滚动文本框的滚动条
                    rtbSend.Clear();//清空发送消息文本框
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            rtbContent.Text = "";
        }

        private void flist_MouseEnter(object sender, EventArgs e)
        {
            flist.Text = "添加或查看好友数据";
        }

        private void flist_MouseLeave(object sender, EventArgs e)
        {
            flist.Text = "怕记不住或者忘记了好友IP，点我试试？";
        }

        private void flist_Click(object sender, EventArgs e)
        {
            flist f=new flist(id);
            f.ShowDialog();
        }
    }
}
