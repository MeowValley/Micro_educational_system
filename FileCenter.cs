using AntdUI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Satelliteeducationsystem
{
    public partial class FileCenter : Form
    {
        private int pageSize = 10;  // 每页显示的记录数
        private int currentPage = 1; // 当前页码
        private int totalRecords = 0; // 总记录数
        private int totalPages = 0;  // 总页数

        private DataTable fullTable; // 保存完整数据
        private string id;
        private float p;
        private string fileType;
        public FileCenter(string id, string fileType)
        {
            InitializeComponent();
            this.id = id;

            this.fileType = fileType;

        }
        public FileCenter()
        {
            InitializeComponent();
        }
        #region 文件上传实现
        

        private void timer1_Tick(object sender, EventArgs e)
        {
            fileprogress.Value += (float)0.01;
            fileprogress.Value = p;
        }

        private void FileCenter_Load(object sender, EventArgs e)
        {
            
            file file=new file();
           DataSet ds = Method.filelist(id);
                LoadData(ds);
           
        }
        private void LoadData(DataSet ds)
        {
            
            // 这里假设数据来自 DataSet
            fullTable = ds.Tables["file"];
            totalRecords = fullTable.Rows.Count;
            totalPages = (int)Math.Ceiling((double)totalRecords / pageSize);

            LoadPage(currentPage);
        }
        private void LoadPage(int page)
        {
            if (fullTable.Rows.Count == 0)
            {

            }
            else
            {

           
            // 检查页码范围
            if (page < 1) page = 1;
            if (page > totalPages) page = totalPages;

            currentPage = page;

            // 计算当前页数据的起始索引和结束索引
            int startIndex = (currentPage - 1) * pageSize;
            int endIndex = Math.Min(startIndex + pageSize, totalRecords);

            // 使用临时表存储当前页的数据
            DataTable pageTable = fullTable.Clone(); // 复制表结构
            for (int i = startIndex; i < endIndex; i++)
            {
                pageTable.ImportRow(fullTable.Rows[i]);
            }

            // 将当前页数据绑定到 DataGridView
            filelist.DataSource = pageTable;

            // 更新分页信息显示（可选）
            pagelabel.Text = $"第 {currentPage} 页 / 共 {totalPages} 页";
        }
        }
        #endregion

        private void uiButton1_Click(object sender, EventArgs e)
        {
            if (currentPage > 1)
            {
                LoadPage(currentPage - 1);
            }
        }

        private void uiButton2_Click(object sender, EventArgs e)
        {
            if (currentPage < totalPages)
            {
                LoadPage(currentPage + 1);
            }
        }

        private void uploadDragger1_Click_1(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show(
      "请选择上传类型：是上传文件呢？还是上传文件夹(文件夹请使用压缩方式处理后上传)？\n\n点击“是”上传文件，点击“否”上传文件夹。",
      "选择上传类型",
      MessageBoxButtons.YesNoCancel,
      MessageBoxIcon.Question
  );

            if (result == DialogResult.Yes) // 上传文件
            {
                using (OpenFileDialog openFileDialog = new OpenFileDialog())
                {
                    openFileDialog.Title = "选择文件";
                    openFileDialog.Filter = "所有文件 (*.*)|*.*";
                    openFileDialog.Multiselect = true;

                    if (openFileDialog.ShowDialog() == DialogResult.OK)
                    {
                        foreach (string filePath in openFileDialog.FileNames)
                        {
                            string fileName = Path.GetFileName(filePath);

                            string destPath = Path.Combine(Path.Combine("UpLoad", id), fileName);
                            long fsize = fileoperation.GetFileLength(filePath) / 1024;
                            this.p = (float)0.4;
                            ProgressState.Text = "进度状态栏\n进度条已经启用!\n";
                            timer1.Enabled = true;
                            try
                            {
                                if (Method.file_exist(id, fileType, fileName))
                                {
                                    if (MessageBox.Show($"询问：\n{fileName}已存在，是否需要替换", "错误", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                                    {
                                        ProgressState.Text += $"替换进程启用,文件：{fileName}正在替换...\n";
                                        this.p = (float)0.6;
                                        ProgressState.Text += $"替换进程结束,文件：{fileName}替换成功...\n";
                                        File.Copy(filePath, destPath, true);
                                        this.p = (float)1.0;
                                        MessageBox.Show($"文件 {fileName} 上传成功！", "成功", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                        State.State = AntdUI.TType.Success;
                                        DataSet ds = Method.filelist(id);//上传完成更新文件表
                                        LoadData(ds);
                                        timer1.Enabled = false;
                                    }
                                    else
                                    {
                                        ProgressState.Text += $"进程异常,文件：{fileName}用户拒绝替换...\n";
                                        MessageBox.Show($"文件上传失败：{fileName}已经存在且你拒绝覆盖", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                        State.State = AntdUI.TType.Error;
                                    }
                                }
                                else if (!Method.file_exist(id, fileType, fileName))
                                {
                                    this.p = (float)0.6;
                                    File.Copy(filePath, destPath, true);
                                    this.p = (float)1.0;
                                    ProgressState.Text += $"上传进程结束,文件：{fileName}已完成上传...\n";
                                    MessageBox.Show($"文件 {fileName} 上传成功！", "成功", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                    Method.fileupload(id, fileName, fileType, fsize);
                                    DataSet ds = Method.filelist(id);
                                    LoadData(ds);
                                    State.State = AntdUI.TType.Success;
                                }
                                else
                                {

                                }

                            }
                            catch (Exception ex)
                            {
                                ProgressState.Text += $"上传失败,文件：{fileName}产生了未知错误...\n";
                                MessageBox.Show($"文件上传失败：{ex.Message}", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                State.State = AntdUI.TType.Error;
                            }
                        }
                    }
                }
            }
            else if (result == DialogResult.No) // 上传文件夹
            {
                using (System.Windows.Forms.FolderBrowserDialog folderBrowserDialog = new System.Windows.Forms.FolderBrowserDialog())
                {
                    folderBrowserDialog.Description = "选择文件夹";
                    ProgressState.Text = "进度状态栏\n进度条已经启用!\n";
                    if (folderBrowserDialog.ShowDialog() == DialogResult.OK)
                    {
                        this.p = (float)0.2;
                        timer1.Enabled = true;
                        string sourceFolder = folderBrowserDialog.SelectedPath;
                        
                        foreach (string filePath in Directory.GetFiles(sourceFolder))
                        {
                            string fileName = Path.GetFileName(filePath);
                            string destPath = Path.Combine(Path.Combine("UpLoad", id), fileName);
                            long fsize = fileoperation.GetFileLength(filePath) / 1024;
                            this.p = (float)0.7;
                            try
                            {
                                if (Method.file_exist(id, fileType, fileName))
                                {
                                    if (MessageBox.Show($"询问：\n{fileName}已存在，是否需要替换", "错误", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                                    {
                                        ProgressState.Text += $"替换进程启用,文件：{fileName}正在替换...\n";
                                        File.Copy(filePath, destPath, true);
                                        this.p = (float)1.0;
                                        ProgressState.Text += $"替换进程结束,文件：{fileName}替换成功...\n";
                                        MessageBox.Show($"文件 {fileName} 上传成功！", "成功", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                        State.State = AntdUI.TType.Success;
                                        DataSet ds = Method.filelist(id);
                                        LoadData(ds);
                                        timer1.Enabled = false;
                                    }
                                    else
                                    {
                                        this.p = (float)1.0;
                                        ProgressState.Text += $"进程异常,文件：{fileName}用户拒绝替换...\n";
                                        State.State = AntdUI.TType.Error;
                                        MessageBox.Show($"文件上传失败：{fileName}已经存在且你拒绝覆盖", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                        timer1.Enabled = false;
                                    }

                                }
                                else if (!Method.file_exist(id, fileType, fileName))
                                {
                                    File.Copy(filePath, destPath, true);
                                    this.p = (float)1.0;
                                    ProgressState.Text += $"上传进程结束,文件：{fileName}已完成上传...\n";
                                    MessageBox.Show($"文件 {fileName} 上传成功！", "成功", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                    Method.fileupload(id, fileName, fileType, fsize);
                                    State.State = AntdUI.TType.Success;
                                    DataSet ds = Method.filelist(id);
                                    LoadData(ds);
                                    timer1.Enabled = false;
                                }

                            }
                            catch (Exception ex)
                            {
                                State.State = AntdUI.TType.Error;
                                ProgressState.Text += $"上传进程结束,文件：{fileName}已完成上传...\n";
                                MessageBox.Show($"文件上传失败：{ex.Message}", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                    }
                }
            }
        }

        private void uploadDragger3_Click(object sender, EventArgs e)
        {

            MessageBox.Show("文件下载即将开始，请确认您已经选择一个或多个文件后再执行操作", "提醒", MessageBoxButtons.OK, MessageBoxIcon.Warning);
           
            ProgressState.Text = "下载文件进程开始，进度条初始化完成...\n";
            for(int i = 0; i < filelist.Rows.Count; i++)
            {
                if (filelist.Rows[i].Selected == true)
                {
                    fileoperation.creat_directory(id);
                    string fname = filelist.Rows[i].Cells["fname"].Value.ToString();
                   ProgressState.Text= $"您即将下载文件名为：{filelist.Rows[i].Cells["fname"].Value.ToString()}的文件,进程已重置......";
                   string destinationpath= Path.Combine(Path.Combine("DownLoad", id), filelist.Rows[i].Cells["fname"].Value.ToString());
                    string sourcepath=Path.Combine(Path.Combine("UpLoad", id), filelist.Rows[i].Cells["fname"].Value.ToString());
                    if (MessageBox.Show($"您即将下载文件名为：{filelist.Rows[i].Cells["fname"].Value.ToString()}的文件\n", "Attention", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        this.p = (float)0.0;
                        if (!File.Exists(destinationpath))
                        {
                            this.p = (float)0.5;
                            File.Copy(sourcepath, destinationpath,false);
                            this.p = (float)1.0;
                            State.State =AntdUI.TType.Success;
                            MessageBox.Show($"文件{fname}下载成功！");
                            ProgressState.Text+= $"文件{fname}下载成功,进程结束了！期待下一次见面哦~.......";
                        }
                        
                        else
                        {
                            if (MessageBox.Show($"文件{fname}已经存在，位于{destinationpath}，您是否需要覆盖他呢？","WARNING",MessageBoxButtons.YesNo,MessageBoxIcon.Question)==DialogResult.Yes)
                            {
                                this.p = (float)0.5;
                                File.Copy(sourcepath, destinationpath, true);
                                State.State = AntdUI.TType.Success;
                                this.p = (float)1.0;
                                MessageBox.Show("覆盖操作执行完毕");
                                ProgressState.Text += $"\n文件{fname}已成功执行覆盖操作，下载成功,进程结束！期待下一次见面哦~\n";
                            }
                            else
                            {
                                MessageBox.Show($"文件{fname}覆盖失败，您拒绝了覆盖进程!", "WARNING", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                this.p = (float)0.5;
                                State.State=AntdUI.TType.Error;
                                ProgressState.Text += $"\n文件{fname}执行覆盖操作失败，原因：您拒绝了覆盖请求，下载失败了呢,进程结束！期待下一次见面哦~\n";
                            }
                        }
                    }
                    
                }
                else
                {
                   // MessageBox.Show("您还未选择文件，请您选择一个或多个文件后再执行操作", "提醒", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                  
                }
            }
        }

        private void search_TextChanged(object sender, EventArgs e)
        {
            string filterText = search.Text;

            if (string.IsNullOrEmpty(filterText))
            {
                // 恢复原始数据
                DataSet ds = Method.filelist(id);
                LoadData(ds);
            }
            else
            {
                // 进行模糊查询
                var filteredRows = fullTable.AsEnumerable()
                    .Where(row => row["fname"].ToString().IndexOf(filterText, StringComparison.OrdinalIgnoreCase) >= 0);

                if (filteredRows.Any())
                {
                    // 创建新的DataTable绑定查询结果
                    filelist.DataSource = filteredRows.CopyToDataTable();
                }
                else
                {
                    // 如果无匹配项，清空DataGridView
                    filelist.DataSource = null;
                }
            }
        }

        private void search_MouseDown(object sender, MouseEventArgs e)
        {
            search.Text = "";
        }

        private void uploadDragger2_Click(object sender, EventArgs e)
        {
          


            MessageBox.Show("文件删除进程即将开始，请确认您选择一个或多个文件后再执行操作", "提醒", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            ProgressState.Text = "删除文件进程开始，进度条初始化完成...\n";
            
            this.p = (float)0.2;
        
            for (int i = 0; i < filelist.Rows.Count; i++)
            {
                if (filelist.Rows[i].Selected == true)//存在bug
                {
                    string filepath = Path.Combine(Path.Combine("UpLoad", id), filelist.Rows[i].Cells["fname"].Value.ToString());
                    if (File.Exists(filepath)) 
                    {
                     this.p = (float)0.5;
                     File.Delete(filepath);
                    Method.deletfile(filelist.Rows[i].Cells["fid"].Value.ToString());
                    this.p = (float)1.0;
                    State.State = AntdUI.TType.Success;
                    MessageBox.Show($"文件{filelist.Rows[i].Cells["fname"].Value.ToString()}删除完毕！");
                    ProgressState.Text += $"文件{filelist.Rows[i].Cells["fname"].Value.ToString()}删除成功,进程结束...";
                    }
                    else
                    {
                        MessageBox.Show("文件被移动或者不存在", "WARNING", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    //MessageBox.Show("bug");
                }
               
            }
            DataSet ds = Method.filelist(id);
            LoadData(ds);
        }

        private void uploadDragger4_Click(object sender, EventArgs e)
        {
            for(int i = 0; i < filelist.Rows.Count; i++)
            {
                string openpath = Path.Combine(Path.Combine("DownLoad", id), filelist.Rows[i].Cells["fname"].Value.ToString());
                if (filelist.Rows[i].Selected == true)
                {
                    if (File.Exists(openpath))
                    {
                        //File.Open(openpath, FileMode.Open);
                        System.Diagnostics.Process.Start(openpath);
                    }
                    else
                    {
                        MessageBox.Show($"文件{filelist.Rows[i].Cells["fname"].Value.ToString()}不存在","警告！",MessageBoxButtons.OK,MessageBoxIcon.Warning);
                    }
                       
                }
            }
        }

        private void uiButton3_Click(object sender, EventArgs e)
        {
            string path = Path.Combine("DownLoad", id);
            System.Diagnostics.Process.Start(path);
        }

        private void filelist_CellClick(object sender, DataGridViewCellEventArgs e)
        {
     
        }
    }
    }

