using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Runtime.Serialization;

namespace bhmz
{
    [DataContract]
    [PetaPoco.TableName("room"), PetaPoco.PrimaryKey("id")]
    public class YeZhu
    {
        [DataMember]
        [PetaPoco.Column]
        public int id { get; set; }

        [DataMember]
        [PetaPoco.Column]
        public int building { get; set; }

        [DataMember]
        [PetaPoco.Column]
        public string room { get; set; }

        [DataMember]
        [PetaPoco.Column]
        public string owner { get; set; }

        [DataMember]
        [PetaPoco.Column]
        public string phone { get; set; }

        [DataMember]
        [PetaPoco.Column]
        public string bak { get; set; }

        [DataMember]
        [PetaPoco.Column]
        public string log { get; set; }

        [DataMember]
        [PetaPoco.Column]
        public string area { get; set; }

        [DataMember]
        [PetaPoco.Column]
        public string qq { get; set; }

        [DataMember]
        [PetaPoco.Column]
        public int used { get; set; }//0自住1出租2空置

        public YeZhu Clone()
        {
            return (YeZhu)this.MemberwiseClone();
        }

        public string GetUsed()
        {
            string suse = "";
            switch (this.used)
            {
                case 0:
                    suse = "自住";
                    break;
                case 1:
                    suse = "出租";
                    break;
                case 2:
                    suse = "空置";
                    break;
            }
            return suse;
        }

        public override string ToString()
        {
            return string.Format("楼栋室号:{0}栋{1}室，业主姓名：{2}，联系电话:{3}，QQ号{4}，面积{5}，居住情况:{6}，备注:\r\n{7}", this.building, this.room, this.owner, this.phone, this.qq, this.area, this.GetUsed(), this.bak);
        }
    }
}
