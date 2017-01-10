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
    public partial class FrmAddRoom : Form
    {
        public FrmAddRoom()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            List<int> buildings = Common.ParserNum(this.tbBuilding.Text);
            List<int> rooms = Common.ParserNum(this.tbRoom.Text);
            List<YeZhu> all = Config.DataManager.GetYeZhuAll();

            if (buildings.Count == 0 || rooms.Count == 0)
            {
                MessageBox.Show("楼栋或室号有误，请检查"); return;
            }



            List<YeZhu> adds = new List<YeZhu>();
            foreach (int b in buildings)
            {
                for (int i = 1; i <= this.nudFloor.Value; i++)
                {
                    foreach (int r in rooms)
                    {
                        string room = string.Format("{0}{1}", i, r.ToString().PadLeft(2,'0'));
                        YeZhu yz = all.Find(c => c.building == b && c.room == room);
                        if (yz == null)
                        {
                            yz = new YeZhu();
                            yz.building = b;
                            yz.room = room;
                            adds.Add(yz);
                        }
                    }
                }
            }
            if (adds.Count > 0) Config.DataManager.AddYeZhu(adds);

            MessageBox.Show(string.Format("本次添加成功房屋{0}间",adds.Count));
            this.DialogResult = System.Windows.Forms.DialogResult.OK;
        }

        private void btnTest_Click(object sender, EventArgs e)
        {
            this.tbLog.Clear();
            List<int> buildings = Common.ParserNum(this.tbBuilding.Text);
            List<int> rooms = Common.ParserNum(this.tbRoom.Text);
            if (buildings.Count == 0 || rooms.Count == 0)
            {
                MessageBox.Show("楼栋或室号有误，请检查"); return;
            }

            List<YeZhu> all = Config.DataManager.GetYeZhuAll();

            foreach (int b in buildings)
            {
                for (int i = 1; i <= this.nudFloor.Value; i++)
                {
                    foreach (int r in rooms)
                    {
                        string room=string.Format("{0}{1}", i, r.ToString().PadLeft(2,'0'));
                        YeZhu yz = all.Find(c => c.building == b && c.room == room);
                        if (yz == null)
                        {
                            this.tbLog.AppendText(string.Format("楼栋{0},室号{1}\r\n", b, room));
                        }
                    }
                }
            }

        }



    }
}
