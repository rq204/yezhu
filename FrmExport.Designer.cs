namespace bhmz
{
    partial class FrmExport
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
            this.llbEXportAll = new System.Windows.Forms.LinkLabel();
            this.llbExportSame = new System.Windows.Forms.LinkLabel();
            this.llbExportDXQF = new System.Windows.Forms.LinkLabel();
            this.SuspendLayout();
            // 
            // llbEXportAll
            // 
            this.llbEXportAll.AutoSize = true;
            this.llbEXportAll.Location = new System.Drawing.Point(23, 18);
            this.llbEXportAll.Name = "llbEXportAll";
            this.llbEXportAll.Size = new System.Drawing.Size(359, 12);
            this.llbEXportAll.TabIndex = 0;
            this.llbEXportAll.TabStop = true;
            this.llbEXportAll.Text = "导出所有业主信息（导出在当前目录下命名为 所有业主信息.xls）";
            this.llbEXportAll.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.llbEXportAll_LinkClicked);
            // 
            // llbExportSame
            // 
            this.llbExportSame.AutoSize = true;
            this.llbExportSame.Location = new System.Drawing.Point(23, 44);
            this.llbExportSame.Name = "llbExportSame";
            this.llbExportSame.Size = new System.Drawing.Size(359, 12);
            this.llbExportSame.TabIndex = 1;
            this.llbExportSame.TabStop = true;
            this.llbExportSame.Text = "导出同名业主信息（导出在当前目录下命名为 同名业主信息.xls）";
            this.llbExportSame.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.llbExportSame_LinkClicked);
            // 
            // llbExportDXQF
            // 
            this.llbExportDXQF.AutoSize = true;
            this.llbExportDXQF.Location = new System.Drawing.Point(25, 74);
            this.llbExportDXQF.Name = "llbExportDXQF";
            this.llbExportDXQF.Size = new System.Drawing.Size(359, 12);
            this.llbExportDXQF.TabIndex = 2;
            this.llbExportDXQF.TabStop = true;
            this.llbExportDXQF.Text = "导出所有不重复的手机号（用于短信群发，命名为 短信群发.txt）";
            this.llbExportDXQF.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.llbExportDXQF_LinkClicked);
            // 
            // FrmExport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(396, 107);
            this.Controls.Add(this.llbExportDXQF);
            this.Controls.Add(this.llbExportSame);
            this.Controls.Add(this.llbEXportAll);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmExport";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "数据导出";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.LinkLabel llbEXportAll;
        private System.Windows.Forms.LinkLabel llbExportSame;
        private System.Windows.Forms.LinkLabel llbExportDXQF;
    }
}