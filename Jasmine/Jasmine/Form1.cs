using Jasmine.applications;
using Jasmine.DBUtils;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Jasmine
{
    public partial class Form1 : Form
    {

        private string userName;
        private string password;
        public Form1()
        {
            InitializeComponent();
            CenterToScreen();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }


        private void pictureBox5_Click(object sender, EventArgs e)
        {
            userName = textBox1.Text.Trim().ToString();
            password = textBox2.Text.Trim().ToString();
            if (userName.Equals("") || password.Equals(""))
            {
                MessageBox.Show("账户名或密码不能为空");//当没有输入的时候提醒
            }
            else
            {
               
                MySqlConnection conn = ConnectUtil.getConnection();
                try
                {
                    conn.Open();
                    string sql = "select * from jasmineuser where userName= '" + userName + "'";//查询是否有对应的账号密码信息
                    MySqlDataAdapter adapter = new MySqlDataAdapter(sql, conn);
                    DataTable dataTable = new DataTable();
                    adapter.Fill(dataTable);
                    if (dataTable.Rows.Count==0)
                    {
                        MessageBox.Show("密码不正确，请重新输入");
                        return;
                    }
                    else
                    {
                        this.Visible = false;
                        MainForm form1 = new MainForm();
                        form1.ShowDialog();
                       
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.ToString());
                    MessageBox.Show("账号不存在，请先注册");
                }
                finally
                {
                    conn.Close();
                }
            }

        }

        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                textBox2.Focus();
            }
        }

        private void textBox2_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                pictureBox5_Click(sender, e);
            }
        }
    }
}
