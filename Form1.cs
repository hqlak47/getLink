using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.IO;

namespace 提取链接
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            Tb.Text = @"D:\0000文件列表";
            Tb1.Text = @"H:\00-已压缩";
        }
        //string connectString = "Data Source=.;Initial Catalog=a250;Integrated Security=True";

        //提取链接
        private void btn_Click(object sender, EventArgs e)
        {
            foreach (string i in rtb.Lines)
            {
                if (i.IndexOf(Tb.Text) != -1)
                {
                    rtb1.AppendText(i.Replace(Tb.Text, "") + "\n");
                }
            }
        }

        private void btnGetCopy_Click(object sender, EventArgs e)
        {
            string str = Tb.Text.Trim();
            foreach (string i in rtb.Lines)
            {
                if (i.IndexOf(str) != -1)
                {
                    rtb1.AppendText(i.Replace(str, "") + "\n");
                }
            }
            Clipboard.SetDataObject(rtb1.Text);
        }

        private void btnCopy_Click(object sender, EventArgs e)
        {
            Clipboard.SetDataObject(rtb1.Text);
        }

        private void btnClean_Click(object sender, EventArgs e)
        {
            rtb.Text = "";
            rtb1.Text = "";
            rtb.Focus();
        }

        //提取磁力链接
        private void btnM_Click(object sender, EventArgs e)
        {
            //rtb1.AppendText("D68D4564267F5B78C3A161A361F063611DEFE3F6".Length.ToString());
            int sum = 0;
            foreach (string i in rtb.Lines)
            {
                if (i.IndexOf(Tb.Text) != -1)
                {
                    string t = i.Trim().Replace(Tb.Text, "");
                    // rtb1.AppendText(t.Length + "\n"+t);
                    if (t.Length == 40 && System.Text.RegularExpressions.Regex.IsMatch(t, @"^[A-Za-z0-9]{4,40}$"))
                    {
                        rtb1.AppendText(t + "\n");
                        sum++;
                    }
                }
                if (i.Trim().Length == 40 && System.Text.RegularExpressions.Regex.IsMatch(i.Trim(), @"^[A-Za-z0-9]+$"))
                {
                    rtb1.AppendText(i + "\n");
                    sum++;
                }
            }
            ls.Text = (Convert.ToInt32(ls.Text) + sum).ToString();
            Clipboard.SetDataObject(rtb1.Text);
        }

        private void btnBD_Click(object sender, EventArgs e)
        {
            if (cb.SelectedIndex==1)
            {
                int sum = 0;
                foreach (string i in rtb.Lines)
                {
                    int index = i.IndexOf("https://pan.baidu.com/s/");
                    if (index != -1)
                    {
                        string s = "https://pan.baidu.com/s/";
                        for (int j = index; j < i.Length; j++)
                        {
                            s += i[j];
                        }
                        rtb1.AppendText(s + "\n");
                        sum++;
                    }
                }
                ls.Text = (Convert.ToInt32(ls.Text) + sum).ToString();
                Clipboard.SetDataObject(rtb1.Text); 
            }
            else
            {
                RtbTxtList.Text = "";
                Tb.Text = Tb.Text.Trim();
                if (Tb.Text.LastIndexOf("\\") != Tb.Text.Length - 1)//把c: 变成c:\，即在最后添上\
                {
                    Tb.Text += "\\";
                }
                string sourcepath = Tb.Text;
                if (!Directory.Exists(sourcepath))
                {
                    return;
                }
                string[] files = Directory.GetFiles(sourcepath, "*.txt"); //获取指定目录所有txt文件的绝对路径
                foreach (string txtfile in files)//列出每一个txt文件
                {
                    RtbTxtList.AppendText(txtfile + "\n");
                    //RtbTxtList.ScrollToCaret();
                    StreamReader list = new(txtfile);
                    string i;
                    while ((i = list.ReadLine()) != null)//读取每个TXT的每一行
                    {
                        rtb.AppendText(i + "\n");
                        string bdlink = "https://pan.baidu.com/s/";
                        int index = i.IndexOf(bdlink);
                        if (index != -1)
                        {
                            for (int j = index; j < i.Length; j++)
                            {
                                bdlink += i[j];
                            }
                            rtb1.AppendText(bdlink + "\n");
                        }
                    }
                    list.Close();
                    string txtpath = Directory.GetParent(txtfile).FullName + "\\";
                    string path = txtpath + Path.GetFileNameWithoutExtension(txtfile) + @"---百度网盘.txt";
                    //创建 FileStream 类的实例
                    FileStream fileStream = new FileStream(path, FileMode.OpenOrCreate, FileAccess.ReadWrite, FileShare.ReadWrite);
                    string msg = rtb1.Text;
                    byte[] bytes = Encoding.UTF8.GetBytes(msg);
                    fileStream.Write(bytes, 0, bytes.Length);
                    fileStream.Flush();
                    fileStream.Close();
                    rtb1.Text = "";
                }
            }
        }

        //检测是否重复
        private void btn250_Click(object sender, EventArgs e)
        {
            
        }

        //去除250网址
        private void Btn25_Click(object sender, EventArgs e)
        {
            int sum = 0;
            foreach (string i in rtb.Lines)
            {
                if (i.Contains("http://250a") && i != "")
                {
                    rtb1.AppendText(i + "\n");
                    if (i.Contains("https://pan.baidu.com/s/"))
                    {
                        sum++;
                    }
                }
            }
            ls.Text = (Convert.ToInt32(ls.Text) + sum).ToString();
            Clipboard.SetDataObject(rtb1.Text);
        }

        private void BtnGetTxt_Click(object sender, EventArgs e)
        {
            Tb.Text = Tb.Text.Trim();
            if (Tb.Text.LastIndexOf("\\") != Tb.Text.Length - 1)//把c: 变成c:\，即在最后添上\
            {
                Tb.Text += "\\";
            }
            RtbTxtList.Text = "";
            string sourcepath = Tb.Text;
            if (!Directory.Exists(sourcepath))
            {
                return;
            }
            string[] files = Directory.GetFiles(sourcepath, "*.txt");            
            foreach (string txtfile in files)//txt文件列表
            {
                RtbTxtList.AppendText(txtfile + "\n");
                //rtb1.AppendText(txtfile + "\n");
                StreamReader list = new(txtfile);
                string ke;
                int num = 3;
                string a = "";
                string b = "";
                {
                    //SqlConnection sqlCnt = new SqlConnection(connectString);
                    //sqlCnt.Open();
                    //SqlCommand command = new SqlCommand();
                    //command.Connection = sqlCnt;            // 绑定SqlConnection对象
                    //SqlCommand cmd = sqlCnt.CreateCommand();              //创建SqlCommand对象
                    //cmd.CommandType = CommandType.Text;
                    //cmd.CommandText = "select * from products = @ID";   //sql语句
                    //cmd.Connection = sqlCnt;
                    //cmd.Parameters.Add("@ID", SqlDbType.Int);
                    //cmd.Parameters["@ID"].Value = 1;                    //给参数sql语句的参数赋值
                    // 创建SqlDataAdapter
                    //SqlDataAdapter myDataAdapter = new SqlDataAdapter();
                    //myDataAdapter.SelectCommand = cmd;	// 为SqlDataAdapter对象绑定所要执行的SqlCommand对象
                    //cmd.ExecuteNonQuery();
                }

                int flag = 0;
                while ((ke = list.ReadLine()) != null)//TXT的每一行是一节课
                {
                    //rtb1.AppendText(num+ ke + "\n");
                    if (num == 3)
                    {
                        a = ke;
                        num--;
                    }
                    else if (num == 2)
                    {
                        num--;
                                b = ke;
                        foreach (string i in rtb.Lines)//从rtb里读每一行与TXT每一行比较
                        {
                            if (string.Equals(i, ke))
                            {
                                flag = 1;//匹配上了
                                //rtb1.AppendText(i + ke + "已存在\n");
                                break;
                            }
                        }
                    }
                    else if (num == 1)
                    {
                        num = 3;
                        if (flag == 0)
                        {
                            rtb1.AppendText(a + "\n" + b + "\n" + ke + "\n");
                        }
                        flag = 0;
                    }
                }
                list.Close();
                //rtb1.AppendText(i + "\n");
                string txtpath = Directory.GetParent(txtfile).FullName+"\\";
                string path = txtpath+Path.GetFileNameWithoutExtension( txtfile)+ @"---.txt";
                //创建 FileStream 类的实例
                FileStream fileStream = new FileStream(path, FileMode.OpenOrCreate, FileAccess.ReadWrite, FileShare.ReadWrite);
                //定义学号
                string msg = rtb1.Text;
                //将字符串转换为字节数组
                byte[] bytes = Encoding.UTF8.GetBytes(msg);
                //向文件中写入字节数组
                fileStream.Write(bytes, 0, bytes.Length);
                //刷新缓冲区
                fileStream.Flush();
                //关闭流
                fileStream.Close();
                rtb1.Text = "";
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Tb1.Text = Tb1.Text.Trim();
            if (Tb1.Text.LastIndexOf("\\") != Tb1.Text.Length - 1)//把c: 变成c:\，即在最后添上\
            {
                Tb1.Text += "\\";
            }
            RtbTxtList.Text = "";
            string sourcepath = Tb1.Text;
            if (!Directory.Exists(sourcepath))
            {
                return;
            }
            string[] flods = Directory.GetDirectories(sourcepath);
            foreach (string i in flods) //列出每一个文件夹
            {
                string flod = Path.GetFileName(i);
                rtb.AppendText(flod + "\n");
            }
            string[] files = Directory.GetFiles(sourcepath, "*.txt");
            foreach (string i in files) //列出每一个文件
            {
                string file = Path.GetFileNameWithoutExtension(i);
                rtb.AppendText(file + "\n");
            }
        }

        private void BtnCc_Click(object sender, EventArgs e)
        {
            foreach (string i in rtb.Lines)
            {
                foreach (string j in RtbTxtList.Lines)
                {
                    if (string.Equals(i,j))
                    {
                        rtb1.AppendText(i+"\n");
                    }
                }
            }
        }
    }
}

