namespace bhmz
{
    partial class FrmMain
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMain));
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.tbSearchResult = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tbKeyword = new System.Windows.Forms.TextBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.msMain = new System.Windows.Forms.MenuStrip();
            this.tsmiTools = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiSearch = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiAddRoom = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiAddYeZhu = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiExport = new System.Windows.Forms.ToolStripMenuItem();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tpSearch = new System.Windows.Forms.TabPage();
            this.tpBuilding = new System.Windows.Forms.TabPage();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.lsvData = new System.Windows.Forms.ListView();
            this.chBuilding = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chRoom = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.cbName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chPhone = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chQQ = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chArea = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chUse = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chBak = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.cmsYeZhu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.tsmiEditYeZhu = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.tsmiDeleteYeZhu = new System.Windows.Forms.ToolStripMenuItem();
            this.tbDetail = new System.Windows.Forms.TextBox();
            this.msMain.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tpSearch.SuspendLayout();
            this.tpBuilding.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.cmsYeZhu.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(56, 28);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 21);
            this.textBox1.TabIndex = 1;
            // 
            // tbSearchResult
            // 
            this.tbSearchResult.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbSearchResult.Location = new System.Drawing.Point(16, 62);
            this.tbSearchResult.Multiline = true;
            this.tbSearchResult.Name = "tbSearchResult";
            this.tbSearchResult.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tbSearchResult.Size = new System.Drawing.Size(749, 456);
            this.tbSearchResult.TabIndex = 1;
            this.tbSearchResult.Text = resources.GetString("tbSearchResult.Text");
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(215, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 12);
            this.label1.TabIndex = 2;
            this.label1.Text = "关键词";
            // 
            // tbKeyword
            // 
            this.tbKeyword.Location = new System.Drawing.Point(265, 20);
            this.tbKeyword.Name = "tbKeyword";
            this.tbKeyword.Size = new System.Drawing.Size(154, 21);
            this.tbKeyword.TabIndex = 3;
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(425, 19);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 23);
            this.btnSearch.TabIndex = 4;
            this.btnSearch.Text = "搜索";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // msMain
            // 
            this.msMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiTools});
            this.msMain.Location = new System.Drawing.Point(0, 0);
            this.msMain.Name = "msMain";
            this.msMain.Size = new System.Drawing.Size(789, 25);
            this.msMain.TabIndex = 5;
            this.msMain.Text = "menuStrip1";
            // 
            // tsmiTools
            // 
            this.tsmiTools.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiSearch,
            this.tsmiAddRoom,
            this.tsmiAddYeZhu,
            this.tsmiExport});
            this.tsmiTools.Name = "tsmiTools";
            this.tsmiTools.Size = new System.Drawing.Size(44, 21);
            this.tsmiTools.Text = "工具";
            // 
            // tsmiSearch
            // 
            this.tsmiSearch.Name = "tsmiSearch";
            this.tsmiSearch.Size = new System.Drawing.Size(148, 22);
            this.tsmiSearch.Text = "搜索业主";
            this.tsmiSearch.Click += new System.EventHandler(this.tsmiSearch2_Click);
            // 
            // tsmiAddRoom
            // 
            this.tsmiAddRoom.Name = "tsmiAddRoom";
            this.tsmiAddRoom.Size = new System.Drawing.Size(148, 22);
            this.tsmiAddRoom.Text = "批量添加房子";
            this.tsmiAddRoom.Click += new System.EventHandler(this.tsmiAddRoom_Click);
            // 
            // tsmiAddYeZhu
            // 
            this.tsmiAddYeZhu.Name = "tsmiAddYeZhu";
            this.tsmiAddYeZhu.Size = new System.Drawing.Size(148, 22);
            this.tsmiAddYeZhu.Text = "批量添加业主";
            this.tsmiAddYeZhu.Visible = false;
            this.tsmiAddYeZhu.Click += new System.EventHandler(this.tsmiAddYeZhu_Click);
            // 
            // tsmiExport
            // 
            this.tsmiExport.Name = "tsmiExport";
            this.tsmiExport.Size = new System.Drawing.Size(148, 22);
            this.tsmiExport.Text = "导出业主信息";
            this.tsmiExport.Click += new System.EventHandler(this.tsmiExport_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tpSearch);
            this.tabControl1.Controls.Add(this.tpBuilding);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 25);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(789, 561);
            this.tabControl1.TabIndex = 6;
            // 
            // tpSearch
            // 
            this.tpSearch.Controls.Add(this.tbSearchResult);
            this.tpSearch.Controls.Add(this.btnSearch);
            this.tpSearch.Controls.Add(this.label1);
            this.tpSearch.Controls.Add(this.tbKeyword);
            this.tpSearch.Location = new System.Drawing.Point(4, 22);
            this.tpSearch.Name = "tpSearch";
            this.tpSearch.Padding = new System.Windows.Forms.Padding(3);
            this.tpSearch.Size = new System.Drawing.Size(781, 535);
            this.tpSearch.TabIndex = 0;
            this.tpSearch.Text = "搜索";
            this.tpSearch.UseVisualStyleBackColor = true;
            // 
            // tpBuilding
            // 
            this.tpBuilding.Controls.Add(this.splitContainer1);
            this.tpBuilding.Location = new System.Drawing.Point(4, 22);
            this.tpBuilding.Name = "tpBuilding";
            this.tpBuilding.Padding = new System.Windows.Forms.Padding(3);
            this.tpBuilding.Size = new System.Drawing.Size(781, 535);
            this.tpBuilding.TabIndex = 1;
            this.tpBuilding.Text = "楼栋信息";
            this.tpBuilding.UseVisualStyleBackColor = true;
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(3, 3);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.lsvData);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.tbDetail);
            this.splitContainer1.Size = new System.Drawing.Size(775, 529);
            this.splitContainer1.SplitterDistance = 472;
            this.splitContainer1.TabIndex = 0;
            // 
            // lsvData
            // 
            this.lsvData.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.chBuilding,
            this.chRoom,
            this.cbName,
            this.chPhone,
            this.chQQ,
            this.chArea,
            this.chUse,
            this.chBak});
            this.lsvData.ContextMenuStrip = this.cmsYeZhu;
            this.lsvData.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lsvData.FullRowSelect = true;
            this.lsvData.Location = new System.Drawing.Point(0, 0);
            this.lsvData.Name = "lsvData";
            this.lsvData.Size = new System.Drawing.Size(775, 472);
            this.lsvData.TabIndex = 0;
            this.lsvData.UseCompatibleStateImageBehavior = false;
            this.lsvData.View = System.Windows.Forms.View.Details;
            this.lsvData.SelectedIndexChanged += new System.EventHandler(this.lsvData_SelectedIndexChanged);
            this.lsvData.DoubleClick += new System.EventHandler(this.lsvData_DoubleClick);
            // 
            // chBuilding
            // 
            this.chBuilding.Text = "楼号";
            this.chBuilding.Width = 40;
            // 
            // chRoom
            // 
            this.chRoom.Text = "室号";
            this.chRoom.Width = 50;
            // 
            // cbName
            // 
            this.cbName.Text = "业主姓名";
            this.cbName.Width = 96;
            // 
            // chPhone
            // 
            this.chPhone.Text = "联系电话";
            this.chPhone.Width = 160;
            // 
            // chQQ
            // 
            this.chQQ.Text = "QQ";
            this.chQQ.Width = 120;
            // 
            // chArea
            // 
            this.chArea.Text = "面积";
            this.chArea.Width = 50;
            // 
            // chUse
            // 
            this.chUse.Text = "用途";
            this.chUse.Width = 36;
            // 
            // chBak
            // 
            this.chBak.Text = "备注";
            this.chBak.Width = 170;
            // 
            // cmsYeZhu
            // 
            this.cmsYeZhu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiEditYeZhu,
            this.toolStripMenuItem1,
            this.tsmiDeleteYeZhu});
            this.cmsYeZhu.Name = "contextMenuStrip1";
            this.cmsYeZhu.Size = new System.Drawing.Size(125, 54);
            // 
            // tsmiEditYeZhu
            // 
            this.tsmiEditYeZhu.Name = "tsmiEditYeZhu";
            this.tsmiEditYeZhu.Size = new System.Drawing.Size(124, 22);
            this.tsmiEditYeZhu.Text = "编辑信息";
            this.tsmiEditYeZhu.Click += new System.EventHandler(this.tsmiEditYeZhu_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(121, 6);
            // 
            // tsmiDeleteYeZhu
            // 
            this.tsmiDeleteYeZhu.Name = "tsmiDeleteYeZhu";
            this.tsmiDeleteYeZhu.Size = new System.Drawing.Size(124, 22);
            this.tsmiDeleteYeZhu.Text = "删除业主";
            this.tsmiDeleteYeZhu.Click += new System.EventHandler(this.tsmiDeleteYeZhu_Click);
            // 
            // tbDetail
            // 
            this.tbDetail.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbDetail.Location = new System.Drawing.Point(0, 0);
            this.tbDetail.Multiline = true;
            this.tbDetail.Name = "tbDetail";
            this.tbDetail.Size = new System.Drawing.Size(775, 53);
            this.tbDetail.TabIndex = 0;
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(789, 586);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.msMain);
            this.MainMenuStrip = this.msMain;
            this.Name = "FrmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "大城业主信息管理系统 1.0 build 20160809";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.msMain.ResumeLayout(false);
            this.msMain.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tpSearch.ResumeLayout(false);
            this.tpSearch.PerformLayout();
            this.tpBuilding.ResumeLayout(false);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.cmsYeZhu.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox tbSearchResult;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbKeyword;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.MenuStrip msMain;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tpSearch;
        private System.Windows.Forms.TabPage tpBuilding;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.ListView lsvData;
        private System.Windows.Forms.ColumnHeader chBuilding;
        private System.Windows.Forms.ColumnHeader chRoom;
        private System.Windows.Forms.ColumnHeader cbName;
        private System.Windows.Forms.ColumnHeader chPhone;
        private System.Windows.Forms.ColumnHeader chUse;
        private System.Windows.Forms.TextBox tbDetail;
        private System.Windows.Forms.ColumnHeader chQQ;
        private System.Windows.Forms.ColumnHeader chBak;
        private System.Windows.Forms.ColumnHeader chArea;
        private System.Windows.Forms.ToolStripMenuItem tsmiTools;
        private System.Windows.Forms.ToolStripMenuItem tsmiSearch;
        private System.Windows.Forms.ToolStripMenuItem tsmiAddRoom;
        private System.Windows.Forms.ToolStripMenuItem tsmiAddYeZhu;
        private System.Windows.Forms.ToolStripMenuItem tsmiExport;
        private System.Windows.Forms.ContextMenuStrip cmsYeZhu;
        private System.Windows.Forms.ToolStripMenuItem tsmiDeleteYeZhu;
        private System.Windows.Forms.ToolStripMenuItem tsmiEditYeZhu;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
    }
}

