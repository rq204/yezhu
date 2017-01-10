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
    public partial class FrmEdit : Form
    {
        YeZhu yz = null;
        public FrmEdit(YeZhu yz)
        {
            InitializeComponent();
            this.yz = yz;
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            this.tbbuildingroom.Text = string.Format("{0}栋{1}室", yz.building, yz.room);
            this.tbowner.Text = yz.owner;
            this.tbphone.Text = yz.phone;
            this.tbQQ.Text = yz.qq;

            switch (yz.used)
            {
                case 2:
                    this.rbuseempty.Checked = true;
                    break;
                case 1:
                    this.rbuserent.Checked = true;
                    break;
                case 0:
                    this.rbuseself.Checked = true;
                    break;
            }
            this.tbbak.Text = yz.bak;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (this.tbowner.Text == "")
            {
                MessageBox.Show("业主姓名不能为空");
                return;
            }
            if (!Common.IsChinese(this.tbowner.Text))
            {
                if (!Common.IsChinese(this.tbowner.Text.Replace("、", "")))
                {
                    MessageBox.Show("多个业主请用、分割"); return;
                }
            }
            if (this.tbphone.Text != "" && !Common.IsPhone(this.tbphone.Text))
            {
                MessageBox.Show("手机号错误，" + this.tbphone.Text);
                return;
            }

            this.yz.owner = this.tbowner.Text;
            this.yz.phone = this.tbphone.Text;
            this.yz.bak = this.tbbak.Text;
            this.yz.qq = this.tbQQ.Text;

            if (this.rbuseempty.Checked) this.yz.used = 2;
            else if (this.rbuserent.Checked) this.yz.used = 1;
            else if (this.rbuseself.Checked) this.yz.used = 0;
            this.DialogResult = DialogResult.OK;
        }
    }
}
