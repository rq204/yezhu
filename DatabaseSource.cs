using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace bhmz
{
    public class DatabaseSource : ISource
    {
        public static PetaPoco.Database DB = null;
        public void Login(string username, string password)
        {
            if (Config.Conn.State == System.Data.ConnectionState.Closed) Config.Conn.Open();
            if (DB.Fetch<Admin>("select * from admin where username=@0 and password=@1", username, password).Count == 0)
            {
                throw new Exception("用户名或密码错误");
            }
        }

        public List<YeZhu> GetYeZhiByBuilding(string building)
        {
            if (Config.Conn.State == System.Data.ConnectionState.Closed) Config.Conn.Open();
            return DB.Fetch<YeZhu>("select * from room where building =@0", building);
        }

        public List<YeZhu> SearchYeZhu(string keyword)
        {
            PetaPoco.Sql sql = new PetaPoco.Sql();
            if (Config.Conn.State == System.Data.ConnectionState.Closed) Config.Conn.Open();
            sql = new PetaPoco.Sql("select * from room where phone like @0 or qq like @0 or owner like @0 or bak like @0 or log like @0", "%" + keyword + "%");

            List<YeZhu> data = DB.Fetch<YeZhu>(sql);
            if (Common.IsNum(keyword) && keyword.Length == 6)
            {
                string build = keyword.Substring(0, 2);
                string roomnum = keyword.Substring(2, 4);
                build = build.Trim('0');
                roomnum = roomnum.Trim('0');
                sql = new PetaPoco.Sql("select * from room where building=@0 and room=@1", build, roomnum);
                List<YeZhu> data2 = DB.Fetch<YeZhu>(sql);
                data.AddRange(data2);
            }
            return data;
        }

        public void UpdateYeZhu(YeZhu yz)
        {
            if (yz.log == null) yz.log = "";
            if (Config.Conn.State == System.Data.ConnectionState.Closed) Config.Conn.Open();
            DB.Update(yz);
        }


        public List<YeZhu> GetYeZhuAll()
        {
            if (Config.Conn.State == System.Data.ConnectionState.Closed) Config.Conn.Open();
            return DB.Fetch<YeZhu>("select * from room");
        }

        public List<int> GetBuildings()
        {
            if (Config.Conn.State == System.Data.ConnectionState.Closed) Config.Conn.Open();
            List<YeZhu> yzs = DB.Fetch<YeZhu>("select building from room group by building");
            List<int> ls = new List<int>();
            foreach (YeZhu yz in yzs) ls.Add(yz.building);
            return ls;
        }

        public void AddYeZhu(List<YeZhu> yz)
        {
            if (Config.Conn.State == System.Data.ConnectionState.Closed) Config.Conn.Open();
            DB.BeginTransaction();
            foreach (YeZhu y in yz)
            {
                DB.Save(y);
            }
            DB.CompleteTransaction();
        }


        public void RemoveYeZhu(YeZhu yz)
        {
            if (Config.Conn.State == System.Data.ConnectionState.Closed) Config.Conn.Open();
            DB.Delete(yz);
        }
    }
}
