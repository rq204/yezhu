using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace bhmz
{
    class Config
    {
        /// <summary>
        /// 登录的管理员帐号
        /// </summary>
        public static string UsernName
        {
            get
            {
                return ini.IniReadValue("config", "username");
            }
            set
            {
                ini.IniWriteValue("config", "username", value);
            }
        }

        /// <summary>
        /// server地址
        /// </summary>
        public static string Server
        {
            get
            {
                return ini.IniReadValue("config", "server");
            }
        }

        /// <summary>
        /// server地址
        /// </summary>
        public static string ShowName
        {
            get
            {
                return ini.IniReadValue("config", "showname");
            }
        }

        public static string ConnStr
        {
            get { return ini.IniReadValue("config", "connstr"); }
        }

        /// <summary>
        /// 登录的管理员密码
        /// </summary>
        public static string Password
        {
            get
            {
                return ini.IniReadValue("config", "password");
            }
            set
            {
                ini.IniWriteValue("config", "password", value);
            }
        }

        public static ISource DataManager = null;

        private static Lv.Winform.INI ini = new Lv.Winform.INI(AppDomain.CurrentDomain.BaseDirectory + "config.ini");

        public static void CreateSqlite()
        {

        }

        public static System.Data.IDbConnection Conn = null;
    }
}
