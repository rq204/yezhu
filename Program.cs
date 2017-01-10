using NPOI.HSSF.UserModel;
using NPOI.SS.UserModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace bhmz
{
    static class Program
    {
        /// <summary>
        /// 应用程序的主入口点。
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            //单个实例
            System.Diagnostics.Process p = Lv.Winform.AppStart.RunningInstance(true);
            if (p != null) Lv.Winform.AppStart.HandleRunningInstance(p);
            else
            {
                switch (Config.Server)
                {
                    case "mysql":
                        MySql.Data.MySqlClient.MySqlConnection connmysql = new MySql.Data.MySqlClient.MySqlConnection(Config.ConnStr);
                        connmysql.Open();
                        Config.Conn = connmysql;
                        DatabaseSource.DB = new PetaPoco.Database(connmysql);
                        Config.DataManager = new DatabaseSource();
                        break;
                    case "sqlite":
                        string conn = Config.ConnStr.Replace("$", AppDomain.CurrentDomain.BaseDirectory);
                        System.Data.SQLite.SQLiteConnection connection = new System.Data.SQLite.SQLiteConnection(conn);
                        Config.Conn = connection;
                        //DatabaseSource.DB = new PetaPoco.Database(conn, "System.Data.SQLite.EF6");
                        DatabaseSource.DB = new PetaPoco.Database(connection);
                        Config.DataManager = new DatabaseSource();
                        break;
                    default:
                        if (Config.Server.StartsWith("http"))
                        {
                            Config.DataManager = new HttpSource();
                        }
                        else
                        {
                            MessageBox.Show("没有设置数据源"); Environment.Exit(99);
                        }
                        break;
                }
                Application.Run(new FrmMain());
            }
        }
    }
}
