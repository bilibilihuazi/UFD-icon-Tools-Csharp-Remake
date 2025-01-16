using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace U_U盘图标更换小工具_C_
{
    public partial class Main_Window : Form
    {
        //变量===============================================
        public static string Path;
        public static string IconPath;

        //CustomFunctions====================================
        static bool WriteFile(string filePath, string content)
        {
            try
            {
                using (StreamWriter writer = new StreamWriter(filePath))
                {
                    writer.Write(content);
                }
                Console.WriteLine("文件写入成功！");
                return true;
            }
            catch (Exception e)
            {
                Console.WriteLine("写入文件时出错: " + e.Message);
                return false;
            }
        }

        static bool CopyFile(string sourcePath, string destinationPath)
        {
            try
            {
                File.Copy(sourcePath, destinationPath, true);
                Console.WriteLine("文件复制成功！");
                return true;
            }
            catch (Exception e)
            {
                Console.WriteLine("复制文件时出错: " + e.Message);
                return false;
            }
        }

        static bool DeleteFile(string filePath)
        {
            try
            {
                if (File.Exists(filePath))
                {
                    File.Delete(filePath);
                    Console.WriteLine("文件删除成功！");
                    return true;
                }
                else
                {
                    Console.WriteLine("文件不存在！");
                    return false;
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("删除文件时出错: " + e.Message);
                return false;
            }
        }

        //Main=====================================================
        public Main_Window()
        {
            InitializeComponent();
        }

        private void Main_Window_Load(object sender, EventArgs e)
        {
            label_Title.Left=this.Width/2-label_Title.Width/2;

        }

        private void button_Path_Browser_Click(object sender, EventArgs e)
        {
            


            if (folderBrowserDialog.ShowDialog() == DialogResult.OK)
            {
                Path=folderBrowserDialog.SelectedPath;
                textBox_Path.Text = Path;
                Debug.WriteLine(Path);
                
                if(Path.Length==3 && Path.Substring(Path.Length-2)==":\\")
                {

                }
                else if(Path=="")
                {

                }
                else
                {
                    MessageBox.Show("选择的路径不合法，路径必须为某个驱动器的根目录，例如\"C:\\\"","ERROR",MessageBoxButtons.OK,MessageBoxIcon.Error);
                    Path = "";
                    textBox_Path.Text = "";

                }
  

            }
        }

        private void button_IconPath_Browser_Click(object sender, EventArgs e)
        {
            MessageBox.Show("请准备一个名为\"usbicon.ico\"的图标文件，并选择它", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);

            if(openFileDialog.ShowDialog() == DialogResult.OK)
            {
                IconPath=openFileDialog.FileName;
                
                if(IconPath.Substring(IconPath.Length-4)!=".ico")
                {
                    MessageBox.Show("选择的文件不合法！应为.ico图标文件","ERROR",MessageBoxButtons.OK,MessageBoxIcon.Error);
                    IconPath = "";
                    textBox_IconPath.Text=IconPath;

                }
                textBox_IconPath .Text=IconPath;

                pictureBox_IconView.Image = Image.FromFile(IconPath);


            }
        }

        private void button_Set_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("确定开始更换？\n\n此操作将会在U盘根目录下创建两个文件，以便实现图标替换功能\nU盘根目录:" + Path + "\n图标目录:" + IconPath, "请确认", MessageBoxButtons.OKCancel, MessageBoxIcon.Question)==DialogResult.OK)
            {
                if (CopyFile(IconPath, Path + "usbicon.ico") == true)
                {
                    if(WriteFile(Path + "autorun.inf", "[autorun]\nicon=usbicon.ico,0")==true)
                    {
                        MessageBox.Show("操作执行成功!重新插入U盘即可成功设置!", "INFO", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    }
                    else
                    {
                        MessageBox.Show("在写入文件的过程中遇到未知错误！操作意外终止", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("在复制文件的过程中遇到未知错误！操作意外终止", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
            }

        }

        private void button_Reset_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("是否开始还原图标？此操作后将会重置为默认图标\n\n点击确定将会删除U盘根目录下的两个文件，请确保路径设置与已更换图标的U盘路径相同！", "是否开始", MessageBoxButtons.OKCancel, MessageBoxIcon.Question)==DialogResult.OK)
            {
                if(DeleteFile(Path+"usbicon.ico")==true)
                {
                    if(DeleteFile(Path+"autorun.inf")==true)
                    {
                        MessageBox.Show("还原图标成功！重新插入U盘即可还原图标！", "INFO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("在删除文件的过程中遇到错误！检查路径是否填写正确或文件是否存在！", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("在删除文件的过程中遇到错误！检查路径是否填写正确或文件是否存在！", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

        }

        private void 关于程序ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("U盘图标更换小工具\nHuaZi-华子 版权所有 Copyright ©  2024-2025 盗版必究\n\n原软件由易语言开发，此软件使用C# WindowsForm重制", "关于程序", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }
    }
}
