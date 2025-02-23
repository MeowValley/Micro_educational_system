using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Satelliteeducationsystem
{
      public  class fileoperation
    {
        //文件中心目录创建
        public static bool creat_directory(string id)
        {
            string filepathupload = Path.Combine("UpLoad", id);
            string filepathdownload = Path.Combine("DownLoad", id);
            DirectoryInfo directoryinfo = new DirectoryInfo(filepathupload);
            DirectoryInfo directoryinfo1 = new DirectoryInfo(filepathdownload);
            if (!directoryinfo.Exists)
            {
                Directory.CreateDirectory(filepathupload);
                return true;
            }
            else if (!directoryinfo1.Exists)
            {
                Directory.CreateDirectory(filepathdownload);
                return true;
            }
            else
            {
                return true;
            }
        }
        //作业管理中心目录创建
        public static bool creat_homework(string id)
        {
            string homework = Path.Combine("作业", id);
            DirectoryInfo directoryinfo = new DirectoryInfo(homework);
            if (!directoryinfo.Exists)
            {
                Directory.CreateDirectory(homework);
                return true;
            }
            else
            {
                return true;
            }
        }


        //作业中心下载操作
        public static void homeworkoperation(string cid,string filename,string sid)
        {
            string sourcepath = Path.Combine(Path.Combine("作业", cid), filename);
            string desepath = Path.Combine(Path.Combine("DownLoad", sid), filename);
            string openpath = Path.Combine("DownLoad", sid);
            File.Copy(sourcepath, desepath, true);
            System.Diagnostics.Process.Start(openpath);
        }
        //单机作业名称操作
        public static void clicklink(string cid,string filename)
        {
            string sourcepath = Path.Combine(Path.Combine("作业", cid), filename);
            System.Diagnostics.Process.Start(sourcepath);
        }

        //获取文件占用空间
        public static long GetFileLength(string filePath)
        {
            //判断当前路径所指向的是否为文件
            if (File.Exists(filePath))
            {
                //定义一个FileInfo对象,使之与filePath所指向的文件向关联,
                //以获取其大小
                FileInfo fileInfo = new FileInfo(filePath);
                return fileInfo.Length;
            }
            else
            {
                return -1;
            }
        }

    }
}
