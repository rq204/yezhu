using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace bhmz
{
    public partial class FrmLogin : Form
    {
        public FrmLogin()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string username = this.tbUserName.Text.Trim();
            string passwrod = this.tbPassword.Text.Trim();
            if (username == "" || passwrod == "")
            {
                MessageBox.Show("用户名或密码不能为空"); return;
            }

            try
            {
                Config.DataManager.Login(username, passwrod);
                Config.UsernName = username;
                Config.Password = passwrod;
                this.DialogResult = System.Windows.Forms.DialogResult.OK;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "出错");
            }
        }

        private void FrmLogin_Load(object sender, EventArgs e)
        {
            this.tbPassword.Text = Config.Password;
            this.tbUserName.Text = Config.UsernName;
        }
    }
}
