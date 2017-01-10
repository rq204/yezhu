namespace bhmz
{
    partial class FrmEdit
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tbbuildingroom = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tbbak = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.tbowner = new System.Windows.Forms.TextBox();
            this.tbphone = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.rbuseempty = new System.Windows.Forms.RadioButton();
            this.rbuserent = new System.Windows.Forms.RadioButton();
            this.rbuseself = new System.Windows.Forms.RadioButton();
            this.btnSave = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.tbQQ = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(27, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "业主姓名";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(27, 24);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 12);
            this.label2.TabIndex = 1;
            this.label2.Text = "楼栋室号";
            // 
            // tbbuildingroom
            // 
            this.tbbuildingroom.Location = new System.Drawing.Point(86, 20);
            this.tbbuildingroom.Name = "tbbuildingroom";
            this.tbbuildingroom.ReadOnly = true;
            this.tbbuildingroom.Size = new System.Drawing.Size(181, 21);
            this.tbbuildingroom.TabIndex = 10;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(27, 79);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 12);
            this.label3.TabIndex = 0;
            this.label3.Text = "联系电话";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(27, 140);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 12);
            this.label4.TabIndex = 0;
            this.label4.Text = "居住情况";
            // 
            // tbbak
            // 
            this.tbbak.Location = new System.Drawing.Point(86, 169);
            this.tbbak.Multiline = true;
            this.tbbak.Name = "tbbak";
            this.tbbak.Size = new System.Drawing.Size(256, 80);
            this.tbbak.TabIndex = 8;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(27, 169);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(53, 12);
            this.label6.TabIndex = 0;
            this.label6.Text = "备注信息";
            // 
            // tbowner
            // 
            this.tbowner.Location = new System.Drawing.Point(87, 49);
            this.tbowner.Name = "tbowner";
            this.tbowner.Size = new System.Drawing.Size(180, 21);
            this.tbowner.TabIndex = 0;
            // 
            // tbphone
            // 
            this.tbphone.Location = new System.Drawing.Point(86, 77);
            this.tbphone.Name = "tbphone";
            this.tbphone.Size = new System.Drawing.Size(181, 21);
            this.tbphone.TabIndex = 1;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.rbuseempty);
            this.panel1.Controls.Add(this.rbuserent);
            this.panel1.Controls.Add(this.rbuseself);
            this.panel1.Location = new System.Drawing.Point(86, 134);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(181, 25);
            this.panel1.TabIndex = 6;
            // 
            // rbuseempty
            // 
            this.rbuseempty.AutoSize = true;
            this.rbuseempty.Checked = true;
            this.rbuseempty.Location = new System.Drawing.Point(126, 5);
            this.rbuseempty.Name = "rbuseempty";
            this.rbuseempty.Size = new System.Drawing.Size(47, 16);
            this.rbuseempty.TabIndex = 4;
            this.rbuseempty.TabStop = true;
            this.rbuseempty.Text = "空置";
            this.rbuseempty.UseVisualStyleBackColor = true;
            // 
            // rbuserent
            // 
            this.rbuserent.AutoSize = true;
            this.rbuserent.Location = new System.Drawing.Point(66, 5);
            this.rbuserent.Name = "rbuserent";
            this.rbuserent.Size = new System.Drawing.Size(47, 16);
            this.rbuserent.TabIndex = 3;
            this.rbuserent.TabStop = true;
            this.rbuserent.Text = "出租";
            this.rbuserent.UseVisualStyleBackColor = true;
            // 
            // rbuseself
            // 
            this.rbuseself.AutoSize = true;
            this.rbuseself.Location = new System.Drawing.Point(5, 5);
            this.rbuseself.Name = "rbuseself";
            this.rbuseself.Size = new System.Drawing.Size(47, 16);
            this.rbuseself.TabIndex = 2;
            this.rbuseself.TabStop = true;
            this.rbuseself.Text = "自住";
            this.rbuseself.UseVisualStyleBackColor = true;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(160, 259);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 9;
            this.btnSave.Text = "保存";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // label7
            // 
            this.label7.ForeColor = System.Drawing.Color.ForestGreen;
            this.label7.Location = new System.Drawing.Point(278, 79);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(54, 48);
            this.label7.TabIndex = 9;
            this.label7.Text = "多个姓名 手机号码 QQ号码用、分割";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(39, 110);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(41, 12);
            this.label5.TabIndex = 11;
            this.label5.Text = "QQ号码";
            // 
            // tbQQ
            // 
            this.tbQQ.Location = new System.Drawing.Point(86, 106);
            this.tbQQ.Name = "tbQQ";
            this.tbQQ.Size = new System.Drawing.Size(181, 21);
            this.tbQQ.TabIndex = 13;
            // 
            // FrmEdit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(370, 291);
            this.Controls.Add(this.tbQQ);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.tbphone);
            this.Controls.Add(this.tbowner);
            this.Controls.Add(this.tbbak);
            this.Controls.Add(this.tbbuildingroom);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmEdit";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "业主信息编辑";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbbuildingroom;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbbak;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tbowner;
        private System.Windows.Forms.TextBox tbphone;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.RadioButton rbuseempty;
        private System.Windows.Forms.RadioButton rbuserent;
        private System.Windows.Forms.RadioButton rbuseself;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbQQ;
    }
}