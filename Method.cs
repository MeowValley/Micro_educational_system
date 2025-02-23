using QRCoder;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Satelliteeducationsystem
{
    //课表类
   

    public class studentinfo
    {
        public string sid;
        public string sname;
        public string sidcard;
        public string sphone;
        public string semail;
        public string sage;
        public string cname;
        public string sex;
        public string cid;
    }
    public class teacherinfo
    {
        public string tid;
        public string tname;
        public string tidcard;
        public string tphone;
        public string temail;
        public string tage;
        public string sex;
        public string cid;
        public string cname;

    }
    public class file
    {
        public string fid;
        public string fname;
        public string ftype;
        public string fsize;
        public string uploadtime;
    }
    public class admininfo 
    {
        public string aid;
        public string aname;
        public string aidcard;
        public string aemail;
        public string aphone;
        public string state;
    }

    public class Method
    {
        //QRcode生成函数
        public static void QRcodegenerate(string code)
        {
            string text = "您正在登录重庆工商大学派斯学院学习平台---课程设计作业\n您的验证码为：" + code + "\n代码框架.net，开发语言：C#\n开发平台visualstudio";
            //string text = code;
            QRCodeGenerator qrGenerator = new QRCodeGenerator();
            QRCodeData qrCodeData = qrGenerator.CreateQrCode(text, QRCodeGenerator.ECCLevel.Q);
            QRCode qrCode = new QRCode(qrCodeData);

            using (Bitmap qrCodeImage = qrCode.GetGraphic(20))
            {
                qrCodeImage.Save("验证码.png"); // 保存二维码为图片
            }
        }



        //随机四位验证码生成器
        public static string GenerateVerificationCode()
        {
            char[] characters = "abcdefghijklmnopqrstuvwxyz0123456789".ToCharArray();
            Random random = new Random();
            string code = string.Empty;

            for (int i = 0; i < 4; i++)
            {
                // 从字符数组中随机选择一个字符
                code += characters[random.Next(characters.Length)];
            }

            return "123";
        }



        //对不同身份列表进行插入操作,以下为注册操作所使用的数据库语法
        public static bool insert_s_user(string username, string sex, string age, string idcard, string password, string email, string phone)//学生
        {
            string sql = string.Format("insert into s_user (sname,spassword,sidcard,sex,semail,sphone,sage) values('{0}','{1}','{2}','{3}','{4}','{5}','{6}')", username, password, idcard, sex, email, phone, age);
            if (DataBase.ExcuteSql(sql))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public static bool insert_t_user(string username, string sex, string age, string idcard, string password, string email, string phone)//教师
        {
            string sql = string.Format("insert into t_user (tname,tpassword,tidcard,sex,temail,tphone,tage) values('{0}','{1}','{2}','{3}','{4}','{5}','{6}')", username, password, idcard, sex, email, phone, age);
            if (DataBase.ExcuteSql(sql))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public static bool insert_admin(string username, string password, string idcard, string email, string phone)//管理员
        {
            string sql = string.Format("insert into admin (aname,apassword,aidcard,aemail,aphone) values('{0}','{1}','{2}','{3}','{4}')", username, password, idcard, email, phone);
            if (DataBase.ExcuteSql(sql))
            {
                return true;
            }
            else
            {
                return false;
            }
        }


        ////对不同身份列表进行查询操作,以下为登录用户操作所使用的数据库语法
        public static bool query_s_user_login(string account, string idcard, string password)//学生
        {
            string sql = string.Format("select count(*) from s_user where (sphone='{0}' or semail='{1}' or sidcard='{2}') and spassword='{3}'", account, account, idcard, password);
            int num = (int)DataBase.QuerySingle(sql);
            if (num > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public static bool query_t_user_login(string account, string idcard, string password)
        {
            string sql = string.Format("select count(*) from t_user where(tphone='{0}'or temail='{1}' or tidcard='{2}') and tpassword='{3}'", account, account, idcard, password);
            int num = (int)DataBase.QuerySingle(sql);
            if (num > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public static bool query_admin_login(string account, string idcard, string password)
        {
            string sql = string.Format("select count(*) from admin where(aphone='{0}'or aemail='{1}' or aidcard='{2}') and apassword='{3}'", account, account, idcard, password);
            int num = (int)DataBase.QuerySingle(sql);
            if (num > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        //检测用户是否存在


        public static bool query_s_user_exist(string phone, string email, string idcard)
        {
            string sql = string.Format("select count(*) from s_user where sphone='{0}' or semail='{1}' or sidcard='{2}'", phone, email, idcard);
            int num = (int)DataBase.QuerySingle(sql);
            if (num > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public static bool query_t_user_exist(string phone, string email, string idcard)
        {
            string sql = string.Format("select count(*) from t_user where (tphone='{0}' or temail='{1}' or tidcard='{2}')", phone, email, idcard);
            int num = (int)DataBase.QuerySingle(sql);
            if (num > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public static bool query_admin_exist(string phone, string email, string idcard)
        {
            string sql = string.Format("select count(*) from admin where aphone='{0}' or aemail='{1}' or aidcard='{2}'", phone, email, idcard);
            int num = (int)DataBase.QuerySingle(sql);
            if (num > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        #region 个人中心信息
        //以下为个人中心数据查询函数


        public static studentinfo query_s_user_info(string account)
        {
            string sql = string.Format("select s_user.sid,sname,sidcard,sex,semail,sphone,sage,cname,class.cid from s_user inner join class on s_user.cid=class.cid where (sidcard='{0}' or semail='{1}' or sphone='{2}')  ", account, account, account);
            DataSet ds = DataBase.QueryLots(sql, "student");
            studentinfo s = new studentinfo();
            s.sid = ds.Tables["student"].Rows[0][0].ToString();
            s.semail = ds.Tables["student"].Rows[0][4].ToString();
            s.sphone = ds.Tables["student"].Rows[0][5].ToString();
            s.sage = ds.Tables["student"].Rows[0][6].ToString();
            s.sex = ds.Tables["student"].Rows[0][3].ToString();
            s.cname = ds.Tables["student"].Rows[0][7].ToString();
            s.sidcard = ds.Tables["student"].Rows[0][2].ToString();
            s.sname = ds.Tables["student"].Rows[0][1].ToString();
            s.cid = ds.Tables["student"].Rows[0][8].ToString();
            return s;
        }

        public static teacherinfo query_t_user_info(string account)
        {
            string sql = string.Format("select tid,tname,tidcard,sex,temail,tphone,tage,cid from t_user  where (tidcard='{0}' or temail='{1}' or tphone='{2}')  ", account, account, account);
            DataSet ds = DataBase.QueryLots(sql, "teacher");
            teacherinfo t = new teacherinfo();
            t.tid = ds.Tables["teacher"].Rows[0][0].ToString();
            t.temail = ds.Tables["teacher"].Rows[0][4].ToString();
            t.tphone = ds.Tables["teacher"].Rows[0][5].ToString();
            t.tage = ds.Tables["teacher"].Rows[0][6].ToString();
            t.sex = ds.Tables["teacher"].Rows[0][3].ToString();
            t.tidcard = ds.Tables["teacher"].Rows[0][2].ToString();
            t.tname = ds.Tables["teacher"].Rows[0][1].ToString();
            t.cid = ds.Tables["teacher"].Rows[0][7].ToString();
            return t;
        }

        public static admininfo query_admin_info(string account)
        {
            string sql = string.Format("select aid,aname,aidcard,aemail,aphone,state from  admin  where (aidcard='{0}' or aemail='{1}' or aphone='{2}')  ", account, account, account);
            DataSet ds = DataBase.QueryLots(sql, "admin");
            admininfo a = new admininfo();
            a.aid = ds.Tables["admin"].Rows[0][0].ToString();
            a.aemail = ds.Tables["admin"].Rows[0][3].ToString();
            a.aphone = ds.Tables["admin"].Rows[0][4].ToString();
            a.aidcard = ds.Tables["admin"].Rows[0][2].ToString();
            a.aname = ds.Tables["admin"].Rows[0][1].ToString();
            a.state = ds.Tables["admin"].Rows[0][5].ToString();
            return a;
        }
        #endregion


        //以下为忘记密码使用的函数
        public static bool Forget_s_user_passwprd(string phone, string idcard, string password)
        {
            string sql = string.Format("update s_user set spassword='{0}' where (sphone='{1}' and sidcard='{2}')  ", password, phone, idcard);
            if (DataBase.ExcuteSql(sql))
            {
                return true;
            }
            else
            {
                return false;
            }

        }

        public static bool Forget_t_user_passwprd(string phone, string idcard, string password)
        {
            string sql = string.Format("update t_user set tpassword='{0}' where (tsphone='{1}' and tidcard='{2}')  ", password, phone, idcard);
            if (DataBase.ExcuteSql(sql))
            {
                return true;
            }
            else
            {
                return false;
            }

        }


        public static bool Forget_admin_passwprd(string phone, string idcard, string password)
        {
            string sql = string.Format("update admin set apassword='{0}' where (aphone='{1}' and aidcard='{2}')  ", password, phone, idcard);
            if (DataBase.ExcuteSql(sql))
            {
                return true;
            }
            else
            {
                return false;
            }

        }



        //以下为修改密码所使用的函数

        public static bool Modify_s_user_password(string prepassword, string account, string newpassword)
        {
            string sql = string.Format("update s_user set spassword='{0}' where ((sname='{1}' or semail='{2}' or sphone='{3}') and spassword='{4}')", newpassword, account, account, account, prepassword);
            if (DataBase.ExcuteSql(sql))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public static bool Modify_t_user_password(string prepassword, string account, string newpassword)
        {
            string sql = string.Format("update t_user set tpassword='{0}' where ((tname='{1}' or temail='{2}' or tphone='{3}') and tpassword='{4}')", newpassword, account, account, account, prepassword);
            if (DataBase.ExcuteSql(sql))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public static bool Modify_admin_password(string prepassword, string account, string newpassword)
        {
            string sql = string.Format("update admin set apassword='{0}' where ((aname='{1}' or aemail='{2}' or aphone='{3}') and apassword='{4}')", newpassword, account, account, account, prepassword);
            if (DataBase.ExcuteSql(sql))
            {
                return true;
            }
            else
            {
                return false;
            }
        }



        //以下为上传文件所需的函数

        public static bool fileupload(string id, string filename, string filetype, long size)
        {

            string sql = string.Format("insert into [file](fname,ftype,userid,fsize,uploadtime) values('{0}','{1}','{2}','{3}','{4}')", filename, filetype, id, size, System.DateTime.Now.ToString("F"));
            if (DataBase.ExcuteSql(sql))
            {

                return true;
            }
            else
            {
                return false;
            }

        }
        //判断文件是否存在


        public static bool file_exist(string id, string ftype, string fname)
        {
            string sql = string.Format("select count(*) from [file] where (userid='{0}' and ftype='{1}' and fname='{2}')", id, ftype, fname);
            object o = DataBase.QuerySingle(sql);
            if (o != null && int.TryParse(o.ToString(), out int count) && count > 0)
            {
                return count > 0;
            }
            else
            {
                return false;
            }
        }



        //获取文件列表
        public static DataSet filelist(string userid)
        {
            string sql = string.Format("select fid,fname,ftype,fsize,uploadtime from [file] where userid='{0}'", userid);
            DataSet ds = DataBase.QueryLots(sql, "file");
            // file file=new file();
            // file.fid=ds.Tables["file"].Rows[0][0].ToString();
            // file.fname=ds.Tables["file"].Rows[0][1].ToString();
            // file.ftype=ds.Tables["file"].Rows[0][2].ToString();
            //file.fsize=ds.Tables["file"].Rows[0][3].ToString();
            // file.uploadtime=ds.Tables["file"].Rows[0][4].ToString();
            return ds;
        }

        //删除文件使用的函数

        public static bool deletfile(string fid)
        {
            string sql = string.Format("delete from [file] where fid='{0}'", fid);
            if (DataBase.ExcuteSql(sql))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        //系统公告展示
        public static DataSet sysnotice()
        {
            string sql = "select snotice,sdatetime from notice";
            DataSet ds = DataBase.QueryLots(sql, "notice");
            return ds;
        }

        //班级公告展示
        public static DataSet classnotice(string cid)
        {
            string sql = string.Format("select cnotice,cdatetime from notice where cid='{0}'", cid);
            DataSet ds = DataBase.QueryLots(sql, "classnotice");
            return ds;
        }
        //发布班级公告
        public static bool insertclassnotice(string cid, string notice, string tid)
        {
            string sql1 = string.Format("select count(*) from notice where tid='{0}'", tid);
            object o = DataBase.QuerySingle(sql1);
            if (o != null && int.TryParse(o.ToString(), out int count) && count > 0 && count > 0)
            {
                string sql = string.Format("update notice set cnotice='{0}',cdatetime='{1}' where tid='{2}'", notice, System.DateTime.Now.ToString(), tid);
                if (DataBase.ExcuteSql(sql))
                {
                    return true;
                }
                else

                {
                    return false;
                }
            }
            else
            {
                string sql = string.Format("insert into notice (tid,cnotice,cdatetime) values('{0}','{1}','{2}') ", tid, notice, System.DateTime.Now.ToString());
                if (DataBase.ExcuteSql(sql))
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
        }
        //发布系统公告
        public static bool insertsystemnotice(string aid, string notice)
        {
            string sql1 = string.Format("select count(*) from notice where aid='{0}'", aid);
            object o = DataBase.QuerySingle(sql1);
            if (o != null && int.TryParse(o.ToString(), out int count) && count > 0 && count > 0)
            {
                string sql = string.Format("update notice set snotice='{0}',sdatetime='{1}' where aid='{2}'", notice, System.DateTime.Now.ToString(), aid);
                if (DataBase.ExcuteSql(sql))
                {
                    return true;
                }
                else

                {
                    return false;
                }
            }
            else
            {
                string sql = string.Format("insert into notice (aid,snotice,sdatetime) values('{0}','{1}','{2}') ", aid, notice, System.DateTime.Now.ToString());
                if (DataBase.ExcuteSql(sql))
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }

        }

        //留言板展示
        public static DataSet message()
        {
            string sql = "select mg,datetime from message";
            DataSet ds = DataBase.QueryLots(sql, "message");
            return ds;
        }


        //发布留言

        public static bool sendmg(string mg)
        {
            string sql = string.Format("insert into message (mg,datetime) values('{0}','{1}')", mg, System.DateTime.Now.ToString("F"));
            if (DataBase.ExcuteSql(sql))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        #region 课表管理

        //检查课表是否存在(sql 语句 ai)
        public static bool courseexist(string cid)
        {

            string sql = string.Format("IF EXISTS (SELECT 1 FROM sys.tables WHERE name = '{0}')\r\n                SELECT 1\r\n            ELSE\r\n                SELECT 0;", "c" + cid);
            int exists = (int)DataBase.QuerySingle(sql);
            if (exists == 1)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        #region 课程表备注
        //课程表备注
        public static void coursebz(string cid)
        {
            string sql = string.Format("insert into 课程表备注 (cid) values('{0}')", cid);
            DataBase.ExcuteSql(sql);
        }
        public static bool updatebz(string bz, string cid)
        {
            string sql = string.Format("update 课程表备注 set 备注='{0}' where cid='{1}'", bz, cid);
            if (DataBase.ExcuteSql(sql))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public static bool bzexist(string cid)
        {
            string sql = string.Format("select count(*) from 课程表备注 where cid='{0}'", cid);
            object o = DataBase.QuerySingle(sql);
            if (o != null && int.TryParse(o.ToString(), out int count) && count > 0 && count > 0)
            {
                return count > 0;
            }
            else
            {
                return false;
            }
        }
        //读取备注
        public static DataSet bz(string cid)
        {
            string sql = string.Format("select 备注 from 课程表备注 where cid='{0}'", cid);
            DataSet ds = DataBase.QueryLots(sql, "bz");
            return ds;
        }
        #endregion
        //课表设置函数

        public static void CourseDesign(string cid)
        {
            string sql = string.Format("CREATE TABLE {0}  (\r\n时间 varchar(255),\r\n星期一 varchar(255),\r\n星期二 varchar(255),\r\n星期三 varchar(255),\r\n星期四 varchar(255),\r\n星期五 varchar(255),\r\n星期六 varchar(255),\r\n星期日 varchar(255)\r\n);", "c" + cid);
            DataBase.ExcuteSql(sql);
            for (int i = 1; i <= 6; i++)
            {
                string sql1 = string.Format("insert into {0} (时间) values('{1}')", "c" + cid, $"第{i}大节");
                DataBase.ExcuteSql(sql1);
            }


        }

        //课表查询

        public static DataSet course(string cid)
        {
            string sql = string.Format("select * from {0}", "c" + cid);
            DataSet ds = DataBase.QueryLots(sql, "course");
            return ds;
        }

        //更新课表

        public static bool updatecourse(string cid, string m1, string m2, string m3, string m4, string m5, string m6, string m7, string time)
        {
            string sql = string.Format("update {0} set 星期一='{1}',星期二='{2}',星期三='{3}',星期四='{4}',星期五='{5}',星期六='{6}',星期日='{7}' where 时间='{8}'", "c" + cid, m1, m2, m3, m4, m5, m6, m7, time);
            if (DataBase.ExcuteSql(sql))
            {
                return true;
            }
            else
            {
                return false;
            }

        }
        //课表角标

        public static DataSet course_cname(string cid)
        {
            string sql = string.Format("select cname from class where cid='{0}'", cid);
            DataSet ds = DataBase.QueryLots(sql, "cname");
            return ds;
        }
        //学生课表绘图数据
        public static DataSet Mycourse(string cid)
        {
            string sql = string.Format("select 星期一,星期二,星期三,星期四,星期五,星期六,星期日 from {0}", "c" + cid);
            DataSet ds = DataBase.QueryLots(sql, "course");
            return ds;
        }
        #endregion
        //当前学生状态（状态0全部不开放，状态1开放成绩，状态2开放选课中心，状态3全部开放）
        public static int state(string sid)
        {
            string sql = string.Format("select state from s_user where sid='{0}'", sid);
            object o = DataBase.QuerySingle(sql);
            return Convert.ToInt32(o);
        }

        //修改状态

        public static bool changestate(string state, string cid)
        {
            string sql = string.Format("update s_user set state='{0}' where cid='{1}'", state, cid);
            if (DataBase.ExcuteSql(sql))
            {
                return true;
            }
            else
            {
                return false;
            }
        }



        #region 教师班级管理
        //教师班级管理

        public static bool whether_teach_class(string tid)
        {
            string sql = string.Format("select cid from t_user where tid='{0}'", tid);
            object o = DataBase.QuerySingle(sql);
            if (o != null && int.TryParse(o.ToString(), out int count) && count > 0)
            {
                return count > 0;
            }
            else
            {
                return false;
            }
        }
        //教师学生管理

        public static DataSet managestudent(string cid)
        {
            string sql = string.Format("select sid,sname,spassword,sidcard,sex,semail,sphone,sage,state from s_user where cid='{0}'", cid);
            DataSet ds = DataBase.QueryLots(sql, "student");
            return ds;
        }
        public static bool updatestudent(string sid, string sname, string spassword, string sidcard, string sex, string semail, string sphone, string sage, string state)
        {
            string sql = string.Format("update s_user set sname='{0}',spassword='{1}',sidcard='{2}',sex='{3}',semail='{4}',sphone='{5}',sage='{6}',state='{7}' where sid='{8}'", sname, spassword, sidcard, sex, semail, sphone, sage, state, sid);
            if (DataBase.ExcuteSql(sql))
            {
                return true;
            }
            else
            {
                return false;
            }

        }
        #endregion
        //作业查询
        public static DataSet query_homework(string cid)
        {
            string sql = string.Format("select name,date,notice from homework where cid='{0}'", cid);
            DataSet ds = DataBase.QueryLots(sql, "homework");
            return ds;
        }

        //加入班级
        public static bool addclass(string cid, string sid, string name)
        {
            string sql = string.Format("update s_user set cid='{0}' where sid='{1}'", cid, sid);
            string sql1 = string.Format("select count(*) from class where cid='{0}'", cid);
            string sql2 = string.Format("insert into score (cid,学号,姓名) values('{0}','{1}','{2}')", cid, sid, name);
            string sql3 = string.Format("select count(*) from score where cid='{0}'", cid);
            object o = DataBase.QuerySingle(sql1);
            if (o != null && int.TryParse(o.ToString(), out int count) && count > 0)
            {
                if (DataBase.ExcuteSql(sql))
                {
                    object o1 = DataBase.QuerySingle(sql3);
                    if (o1 != null && int.TryParse(o1.ToString(), out int count1) && count1 > 0)
                    {

                    }
                    else
                    {
                        DataBase.ExcuteSql(sql2);
                    }
                    return true;
                }
                else
                {
                    return false;
                }
            }
            else
            {
                return false;
            }

        }
        //班级教师信息查询
        public static DataSet classteacherinfo(string cid)
        {
            string sql = string.Format("select tname,tage,sex,temail,tphone from t_user where cid='{0}' ", cid);
            DataSet ds = DataBase.QueryLots(sql, "classteacherinfo");
            return ds;
        }

        #region 管理员终端
        public static DataSet admin_admin()
        {
            string sql = string.Format("select * from admin");
            DataSet ds = DataBase.QueryLots(sql, "admin");
            return ds;
        }
        public static DataSet code_admin()
        {
            string sql = string.Format("select * from [key]");
            DataSet ds = DataBase.QueryLots(sql, "key");
            return ds;
        }
        public static DataSet class_admin()
        {
            string sql = string.Format("select * from class");
            DataSet ds = DataBase.QueryLots(sql, "class_admin");
            return ds;
        }

        public static DataSet student_admin()
        {
            string sql = string.Format("select * from s_user");
            DataSet ds = DataBase.QueryLots(sql, "student_admin");
            return ds;
        }

        public static DataSet teacher_admin()
        {
            string sql = string.Format("select * from t_user");
            DataSet ds = DataBase.QueryLots(sql, "teacher_admin");
            return ds;
        }
        public static bool updateclass(string cid, string cname)
        {
            string sql1 = string.Format("select count(*) from class where cid='{0}'", cid);
            object o = DataBase.QuerySingle(sql1);
            if (o != null && int.TryParse(o.ToString(), out int count) && count > 0)
            {
                string sql = string.Format("update class set cid='{0}',cname='{1}' where cid='{2}'", cid, cname, cid);
                if (DataBase.ExcuteSql(sql))
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            else
            {
                string sql = string.Format("insert into class (cid,cname) values('{0}','{1}')", cid, cname);
                if (DataBase.ExcuteSql(sql))
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }

        }

        public static bool updatestudent(string sid, string sname, string spassword, string sidcard, string sex, string semail, string sphone, string sage, string cid, string state)
        {
            string sql1 = string.Format("select count(*) from s_user where sid='{0}'", sid);
            object o = DataBase.QuerySingle(sql1);
            if (o != null && int.TryParse(o.ToString(), out int count) && count > 0)
            {
                string sql = string.Format("update s_user set sname='{0}',spassword='{1}',sidcard='{2}',sex='{3}',semail='{4}',sphone='{5}',sage='{6}',cid='{7}',state='{8}' where sid='{9}'", sname, spassword, sidcard, sex, semail, sphone, sage, cid, state, sid);
                if (DataBase.ExcuteSql(sql))
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            else
            {
                string sql = string.Format("insert into s_user  (sname,spassword,sidcard,sex,semail,sphone,sage,cid,state) values('{0}','{1}','{2}','{3}','{4}','{5}','{6}','{7}','{8}')", sname, spassword, sidcard, sex, semail, sphone, sage, cid, state);
                if (DataBase.ExcuteSql(sql))
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
        }


        public static bool updateteacher(string tid, string tname, string tpassword, string tidcard, string sex, string temail, string tphone, string tage, string cid)
        {
            string sql1 = string.Format("select count(*) from t_user where tid='{0}'", tid);
            object o = DataBase.QuerySingle(sql1);
            if (o != null && int.TryParse(o.ToString(), out int count) && count > 0)
            {
                string sql = string.Format("update t_user set tname='{0}',tpassword='{1}',tidcard='{2}',sex='{3}',temail='{4}',tphone='{5}',tage='{6}',cid='{7}'  where tid='{8}' ", tname, tpassword, tidcard, sex, temail, tphone, tage, cid, tid);
                if (DataBase.ExcuteSql(sql))
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            else
            {
                string sql = string.Format("insert into t_user  (tname,tpassword,tidcard,sex,temail,tphone,tage,cid) values('{0}','{1}','{2}','{3}','{4}','{5}','{6}','{7}')", tname, tpassword, tidcard, sex, temail, tphone, tage, cid);
                if (DataBase.ExcuteSql(sql))
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }

        }


        public static bool updateadmin(string aid, string aname, string apassword, string aidcard, string aemail, string aphone, string state)
        {
            string sql1 = string.Format("select count(*) from admin where aid='{0}'", aid);
            object o = DataBase.QuerySingle(sql1);
            if (o != null && int.TryParse(o.ToString(), out int count) && count > 0)
            {
                string sql = string.Format("update admin set aname='{0}',apassword='{1}',aidcard='{2}',aemail='{3}',aphone='{4}',state='{5}'  where aid='{6}' ", aname, apassword, aidcard, aemail, aphone, state, aid);
                if (DataBase.ExcuteSql(sql))
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            else
            {
                string sql = string.Format("insert into admin  (aname,apassword,aidcard,aemail,aphone,state) values('{0}','{1}','{2}','{3}','{4}','{5}')", aname, apassword, aidcard, aemail, aphone, state);
                if (DataBase.ExcuteSql(sql))
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
        }

        public static bool updatekey(string code, string state, string type)
        {

            string sql1 = string.Format("select count(*) from [key] where code='{0}'", code);
            object o = DataBase.QuerySingle(sql1);
            if (o != null && int.TryParse(o.ToString(), out int count) && count > 0 && count > 0)
            {


                string sql = string.Format("update [key] set code='{0}',state='{1}',type='{2}' where code='{3}'", code, state, type, code);
                if (DataBase.ExcuteSql(sql))
                {
                    return true;
                }
                else
                {
                    return false;
                }


            }
            else
            {
                string sql = string.Format("insert into [key] (code,state,type) values('{0}','{1}','{2}')", code, state, type);
                if (DataBase.ExcuteSql(sql))
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
        }
        #endregion

        //密钥验证，状态设置
        public static bool VerificationCode(string code, string type)
        {
            string sql = string.Format("select count(*) from [key] where code='{0}' and state='{1}' and type='{2}'", code, "1", type);
            object o = DataBase.QuerySingle(sql);
            if (o != null && int.TryParse(o.ToString(), out int count) && count > 0 && count > 0)
            {
                string sql1 = string.Format("update [key] set state='{0}' where code='{1}' and type='{2}'", "0", code, type);
                if (DataBase.ExcuteSql(sql1))
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            else
            {
                return false;
            }
        }
        //成绩中心(学生查询)

        public static DataSet student_score(string sid)
        {
            string sql = string.Format("select 学号,姓名,课程名称,分数 from score where 学号='{0}'", sid);
            DataSet ds = DataBase.QueryLots(sql, "score");
            return ds;
        }

        //成绩中心(教师查询)

        public static DataSet teacher_score(string cid)
        {
            string sql = string.Format("select 学号,姓名,课程名称,分数 from score where cid='{0}'", cid);
            DataSet ds = DataBase.QueryLots(sql, "score");
            return ds;
        }
        //成绩中心（教师编辑）
        public static bool updatescore(string sid, string coursename, string score, string cid, string name)
        {
            // string sql = string.Format("update score set 姓名='{0}',课程名称='{1}',成绩='{2}' where sid='{3}'", name, coursename, score, sid);
            string sql1 = string.Format("select count(*) from score where sid='{0}' and 课程名称='{1}'", sid, coursename);
            object o = DataBase.QuerySingle(sql1);
            if (o != null && int.TryParse(o.ToString(), out int count) && count > 0)
            {
                string sql = string.Format("update score set 课程名称='{0}',分数='{1}' where sid='{2}'", coursename, score, sid);
                if (DataBase.ExcuteSql(sql))
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            else
            {
                string sql = string.Format("insert into score (cid,学号,姓名,课程名称,分数) values('{0}','{1}','{2}','{3}','{4}')", cid, sid, name, coursename, score);
                if (DataBase.ExcuteSql(sql))
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }


        }
        #region 分数可视化
        //个人成绩
        public static DataSet bar_score(string cid, string sid)
        {
            string sql = string.Format("select 分数,课程名称 from score where cid='{0}'and 学号='{1}'", cid, sid);
            DataSet ds = DataBase.QueryLots(sql, "bar_score");
            return ds;
        }
        //班级平均成绩
        public static DataSet bar_avgscore(string cid)
        {
            string sql = string.Format("SELECT  AVG(分数) AS average_score FROM score where cid='{0}' group by cid", cid);
            DataSet ds = DataBase.QueryLots(sql, "avg_score");
            return ds;
        }
        //各班级平均成绩
        public static DataSet bar_classavgscore()
        {
            string sql = string.Format("SELECT 课程名称,AVG(分数) AS average_score FROM score  group by 课程名称");
            DataSet ds = DataBase.QueryLots(sql, "classavgscore");
            return ds;
        }
        #endregion

        #region 我的好友列表管理

        public static DataSet flist(string id)
        {
            string sql = string.Format("select IP,备注 from flist where id='{0}'", id);
            DataSet ds = DataBase.QueryLots(sql, "flist");
            return ds;
        }

        public static bool updateflist(string IP, string bz, string id)
        {
            string sql = string.Format("select count(*) from flist where IP='{0}' and id='{1}'", IP, id);
            object o = DataBase.QuerySingle(sql);
            if (o != null && int.TryParse(o.ToString(), out int count) && count > 0)
            {
                string sql1 = string.Format("update flist set IP='{0}',备注='{1}' where id='{2}'", IP, bz, id);
                if (DataBase.ExcuteSql(sql1))
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            else
            {
                string sql2 = string.Format("insert into flist (IP,备注,id) values('{0}','{1}','{2}')", IP, bz, id);
                if (DataBase.ExcuteSql(sql2))
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
        }
        #endregion

        #region 空闲教室管理

        //教室列表(1为占用中，0为空闲)
        public static DataSet query_classroom()
        {
            string sql = string.Format("select * from classroom");
            DataSet ds = DataBase.QueryLots(sql, "classroom");
            return ds;
        }
        //空闲教室列表查询
        public static DataSet query_state_classroom()
        {
            string sql = string.Format("select * from classroom where state='0'");
            DataSet ds = DataBase.QueryLots(sql, "classroom");
            return ds;
        }
        //教室列表管理(教师)禁止修改房间号
        public static bool updateclassroom_teacher(string crid, string roomnumber, string state)
        {
            string sql = string.Format("select count(*) from classroom where crid='{0}' ", crid);
            object o = DataBase.QuerySingle(sql);
                string sql1 = string.Format("update classroom set state='{0}' where roomnumber='{1}' and crid='{2}'", state, roomnumber, crid);
                if (DataBase.ExcuteSql(sql1))
                {
                    return true;
                }
                else
                {
                    return false;
                }
            
           
        }


        //教室列表管理（管理员）禁止修改编号

        public static bool updateclassroom_admin(string crid, string roomnumber, string state)
        {
            string sql = string.Format("select count(*) from classroom where crid='{0}' ", crid);
            object o = DataBase.QuerySingle(sql);
            if (o != null && int.TryParse(o.ToString(), out int count) && count > 0)
            {
                string sql1 = string.Format("update classroom set roomnumber='{0}',state='{1}' where crid='{2}'", roomnumber, state, crid);
                if (DataBase.ExcuteSql(sql1))
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            else
            {
                string sql2 = string.Format("insert into classroom (roomnumber,state) values('{0}','{1}')", roomnumber, state);
                if (DataBase.ExcuteSql(sql2))
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
           }
       #endregion  
    }
}
