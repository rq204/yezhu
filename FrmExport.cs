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
using System.Windows.Forms;

namespace bhmz
{
    public partial class FrmExport : Form
    {
        public FrmExport()
        {
            InitializeComponent();
        }

        private void llbEXportAll_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            try
            {
                List<int> buildings = new List<int>();// Config.DataManager.GetBuildings();
                List<YeZhu> rooms = Config.DataManager.GetYeZhuAll();
                foreach (YeZhu yz in rooms) buildings.Add(yz.building);
                buildings = buildings.Distinct().ToList();
                buildings.Sort();

                IWorkbook workbook = new HSSFWorkbook();
                string[] header = new string[] { "室号", "姓名", "电话", "面积" };
                foreach (int buildingid in buildings)
                {
                    ISheet it = workbook.CreateSheet(buildingid + "栋");
                    IRow ir = it.CreateRow(0);
                    for (int c = 0; c < 4; c++)
                    {
                        ir.CreateCell(c, CellType.String).SetCellValue(header[c]);
                    }

                    foreach (YeZhu yz in rooms.FindAll(a => a.building == buildingid))
                    {
                        IRow ir2 = it.CreateRow(it.LastRowNum + 1);
                        ir2.CreateCell(0, CellType.Numeric).SetCellValue(int.Parse(yz.room)); ;
                        ir2.CreateCell(1, CellType.String).SetCellValue(yz.owner);
                        ir2.CreateCell(2, CellType.String).SetCellValue(yz.phone);
                        ir2.CreateCell(3, CellType.String).SetCellValue(yz.area);
                    }
                }

                string fileName = AppDomain.CurrentDomain.BaseDirectory + "所有业主信息.xls";
                FileStream fs = new FileStream(fileName, FileMode.OpenOrCreate, FileAccess.ReadWrite);
                workbook.Write(fs);
                fs.Close();
                System.Diagnostics.Process.Start(fileName);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "导出出错");
            }
            finally
            {

            }
        }

        private void llbExportSame_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            List<YeZhu> all = Config.DataManager.GetYeZhuAll();
            StringBuilder sb = new StringBuilder();

            //先看同名同手机号
            Dictionary<string, List<string>> same = new Dictionary<string, List<string>>();
            foreach (YeZhu yz in all)
            {
                if (yz.owner == null) continue;
                foreach (string name in yz.owner.Split('、'))
                {
                    string data = string.Format("{0}栋{1}室", yz.building, yz.room);
                    if (yz.phone != "")
                    {
                        foreach (string p in yz.phone.Split('、'))
                        {
                            string key1 = string.Format("{0}:{1}", name, p);
                            if (same.ContainsKey(key1)) same[key1].Add(data);
                            else same.Add(key1, new List<string>(new string[] { data }));
                        }
                    }
                }
            }


            List<string> repeat = new List<string>();
            foreach (KeyValuePair<string, List<string>> kv in same)
            {
                if (kv.Value.Count > 1)
                {
                    sb.Append(kv.Key.PadRight(24 - (getlen(kv.Key)) + kv.Key.Length)).Append(string.Join(",", kv.Value)).Append("\r\n");
                }
            }
            same.Clear();
            if (sb.Length > 0) sb = new StringBuilder("同名同手机业主\r\n" + sb.ToString());

            //Dictionary<string,string>
            //再看同名不同手机号的
            foreach (YeZhu yz in all)
            {
                foreach (string name in yz.owner.Split('、'))
                {
                    string data = string.Format("{0}栋{1}室:", yz.building, yz.room);
                    string key = string.Format("{0}:", name);

                    string data2 = data + yz.phone;
                    if (same.ContainsKey(key))
                    {
                        if (!same[key].Contains(data2)) same[key].Add(data2);
                    }
                    else same.Add(key, new List<string>(new string[] { data2 }));

                }
            }
            foreach (KeyValuePair<string, List<string>> kv in same)
            {
                if (kv.Value.Count == 2)
                {
                    if (kv.Value[1].Split(':')[1] == kv.Value[0].Split(':')[1]) kv.Value.Clear();
                }
            }
            foreach (KeyValuePair<string, List<string>> kv in same)
            {
                if (kv.Value.Count > 1)
                {
                    sb.Append("\r\n同名不同手机业主\r\n");
                    foreach (KeyValuePair<string, List<string>> kv2 in same)
                    {
                        if (kv2.Value.Count > 1)
                        {
                            sb.Append(kv2.Key.PadRight(12 - (getlen(kv2.Key)) + kv2.Key.Length)).Append(string.Join(",", kv2.Value)).Append("\r\n");
                        }
                    }
                    break;
                }
            }
            same.Clear();


            //再看同手机号
            foreach (YeZhu yz in all)
            {
                foreach (string name in yz.owner.Split('、'))
                {
                    string data = string.Format("{2}:{0}栋{1}室", yz.building, yz.room, yz.owner);
                    if (yz.phone != "")
                    {
                        foreach (string key1 in yz.phone.Split('、'))
                        {
                            if (same.ContainsKey(key1))
                            {
                                if (!same[key1].Contains(data)) same[key1].Add(data);
                            }
                            else same.Add(key1, new List<string>(new string[] { data }));
                        }
                    }
                }
            }
            foreach (KeyValuePair<string, List<string>> kv in same)
            {
                if (kv.Value.Count == 2)
                {
                    if (kv.Value[1].Split(':')[0] == kv.Value[0].Split(':')[0]) kv.Value.Clear();
                }
            }
            foreach (KeyValuePair<string, List<string>> kv in same)
            {
                if (kv.Value.Count > 1)
                {
                    sb.Append("\r\n同手机号不同名业主\r\n");
                    foreach (KeyValuePair<string, List<string>> kv2 in same)
                    {
                        if (kv2.Value.Count > 1)
                        {
                            sb.Append(kv2.Key.PadRight(15 - (getlen(kv2.Key)) + kv2.Key.Length)).Append(string.Join(",", kv2.Value)).Append("\r\n");
                        }
                    }
                    break;
                }
            }

            string f = AppDomain.CurrentDomain.BaseDirectory + "相同的业主.txt";
            System.IO.File.WriteAllText(f, sb.ToString(), System.Text.Encoding.UTF8);
            System.Diagnostics.Process.Start(f);
        }


        private int getlen(string text)
        {
            int len = 0;
            foreach (char c in text)
            {
                if (c > 127 || c < 0) len++;
                len++;
            }
            return len;
        }

        private void llbExportDXQF_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            List<YeZhu> rooms = Config.DataManager.GetYeZhuAll();
            List<string> phones = new List<string>();
            foreach (YeZhu yz in rooms)
            {
                if (yz.phone != "")
                {
                    phones.AddRange(yz.phone.Split('、'));
                }
            }
            phones = phones.Distinct().ToList();
            phones.Remove("0");
            foreach (string s in phones.ToArray())
            {
                if (s.Length != 11 && !s.StartsWith("1")) phones.Remove(s);
            }
            string save = AppDomain.CurrentDomain.BaseDirectory + "短信群发.txt";
            System.IO.File.WriteAllLines(save, phones);
            System.Diagnostics.Process.Start(save);
        }
    }
}
