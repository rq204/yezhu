using NPOI.HSSF.UserModel;
using NPOI.SS.UserModel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace bhmz
{
    public partial class FrmMain : Form
    {
        public FrmMain()
        {
            InitializeComponent();
            if (Config.ShowName != "") this.Text = Config.ShowName;
            FrmLogin f3 = new FrmLogin();
            if (f3.ShowDialog() != System.Windows.Forms.DialogResult.OK) Environment.Exit(100);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.tabControl1.ItemSize = new Size(0, 1);
            tabControl1.SizeMode = TabSizeMode.Fixed;
            this.ReloadRoom();
        }

        private void ReloadRoom()
        {
            this.msMain.Items.Clear();
            this.msMain.Items.Add(this.tsmiTools);
            List<YeZhu> rooms = Config.DataManager.GetYeZhuAll();
            List<int> buildings = Common.GetBuildings(rooms);
            foreach (int bid in buildings)
            {
                string txt = bid.ToString() + "栋";
                if (bid == 0) txt = "商业";
                ToolStripMenuItem tsmi = new ToolStripMenuItem(txt);
                tsmi.Tag = bid;
                tsmi.Click += tsmi_Click;
                tsmi.Padding = new Padding(2, 0, 2, 0);
                this.msMain.Items.Add(tsmi);
            }
        }

        void tsmi_Click(object sender, EventArgs e)
        {
            ToolStripMenuItem tsmi = sender as ToolStripMenuItem;
            List<YeZhu> rooms = Config.DataManager.GetYeZhiByBuilding(tsmi.Tag.ToString());
            this.lsvData.Items.Clear();
            if (this.tabControl1.SelectedTab != this.tpBuilding) this.tabControl1.SelectedTab = this.tpBuilding;
            foreach (YeZhu yz in rooms)
            {
                this.lsvData.Items.Add(getlvi(yz));
            }
            this.lsvData.Tag = sender;
        }

        /// <summary>
        /// 生成lvi
        /// </summary>
        /// <param name="yz"></param>
        /// <returns></returns>
        private ListViewItem getlvi(YeZhu yz)
        {
            ListViewItem lvi = new ListViewItem(yz.building.ToString());
            lvi.Tag = yz;
            lvi.SubItems.Add(yz.room);
            lvi.SubItems.Add(yz.owner);
            lvi.SubItems.Add(yz.phone);
            lvi.SubItems.Add(yz.qq);
            lvi.SubItems.Add(yz.area);
            lvi.SubItems.Add(yz.GetUsed());
            lvi.SubItems.Add(yz.bak);
            return lvi;
        }

        private void lsvData_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lsvData.SelectedItems.Count > 0)
            {
                ListViewItem lvi = lsvData.SelectedItems[0];
                YeZhu yz = lvi.Tag as YeZhu;
                this.tbDetail.Text = yz.ToString();
            }
        }

        private void lsvData_DoubleClick(object sender, EventArgs e)
        {
            if (lsvData.SelectedItems.Count == 1)
            {
                ListViewItem lvi = lsvData.SelectedItems[0];
                int index = lsvData.SelectedIndices[0];
                YeZhu yz = (lvi.Tag as YeZhu).Clone();
                FrmEdit f2 = new FrmEdit(yz);
                if (f2.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    try
                    {
                        Config.DataManager.UpdateYeZhu(yz);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message, "更新失败");
                    }
                    lvi.Remove();
                    lvi = getlvi(yz);
                    this.lsvData.Items.Insert(index, lvi);
                }
            }
        }

        private void tsmiSearch_Click(object sender, EventArgs e)
        {

        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (this.tbKeyword.Text == "")
            {
                MessageBox.Show("关键词为空"); return;
            }

            List<YeZhu> rooms = Config.DataManager.SearchYeZhu(this.tbKeyword.Text.Trim());

            if (rooms.Count == 0)
            {
                this.tbSearchResult.Text = "没有搜索到内容";
            }
            else
            {
                this.tbSearchResult.Text = string.Format("总共获取到搜索结果{0}条：\r\n", rooms.Count);
                foreach (YeZhu yz in rooms)
                {
                    this.tbSearchResult.AppendText(yz.ToString() + "\r\n");
                }
            }
        }

        private void tsmiNameRoom_Click(object sender, EventArgs e)
        {
            try
            {
                List<YeZhu> rooms = Config.DataManager.GetYeZhuAll();
                List<int> buildings = Common.GetBuildings(rooms);

                string[] header = new string[] { "室号", "姓名" };
                foreach (int buildingid in buildings)
                {
                    IWorkbook workbook = new HSSFWorkbook();
                    ISheet it = workbook.CreateSheet(buildingid + "栋");
                    IRow ir = it.CreateRow(0);
                    for (int c = 0; c < 2; c++)
                    {
                        ir.CreateCell(c, CellType.String).SetCellValue(header[c]);
                    }

                    foreach (YeZhu yz in rooms.FindAll(a => a.building == buildingid))
                    {
                        IRow ir2 = it.CreateRow(it.LastRowNum + 1);
                        ir2.CreateCell(0, CellType.Numeric).SetCellValue(int.Parse(yz.room)); ;
                        ir2.CreateCell(1, CellType.String).SetCellValue(yz.owner);
                    }

                    string fileName = AppDomain.CurrentDomain.BaseDirectory + "楼栋信息\\" + buildingid.ToString() + "栋业主.xls";
                    FileStream fs = new FileStream(fileName, FileMode.OpenOrCreate, FileAccess.ReadWrite);
                    workbook.Write(fs);
                    fs.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "导出出错");
            }
            finally
            {
            }
        }

        private void tsmiSearch2_Click(object sender, EventArgs e)
        {
            if (this.tabControl1.SelectedTab != tpSearch) this.tabControl1.SelectedTab = this.tpSearch;
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }

        private void tsmiAddRoom_Click(object sender, EventArgs e)
        {
            FrmAddRoom far = new FrmAddRoom();
            if (far.ShowDialog() == System.Windows.Forms.DialogResult.OK) this.ReloadRoom();
        }

        private void tsmiAddYeZhu_Click(object sender, EventArgs e)
        {
            FrmAddYeZhu far = new FrmAddYeZhu();
            if (far.ShowDialog() == System.Windows.Forms.DialogResult.OK) this.ReloadRoom();
        }

        private void tsmiExport_Click(object sender, EventArgs e)
        {
            new FrmExport().ShowDialog();
        }

        private void tsmiDeleteYeZhu_Click(object sender, EventArgs e)
        {
            if (lsvData.SelectedItems.Count > 0)
            {
                   ListViewItem lvi = lsvData.SelectedItems[0];
                    YeZhu yz = lvi.Tag as YeZhu;
                if (MessageBox.Show(string.Format("确认删除{0}楼{1}室信息，删除后不可恢复，需要请重新添加", yz.building,yz.room),"删除", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == System.Windows.Forms.DialogResult.OK)
                {
                 
                    Config.DataManager.RemoveYeZhu(yz);
                    lvi.Remove();
                }
            }
        }

        private void tsmiEditYeZhu_Click(object sender, EventArgs e)
        {
            lsvData_DoubleClick(null, null);
        }


    }
}