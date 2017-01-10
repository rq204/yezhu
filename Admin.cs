using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace bhmz
{
    [PetaPoco.TableName("admin"), PetaPoco.PrimaryKey("id")]
    public class Admin
    {
        [PetaPoco.Column]
        public string Id { get; set; }

        [PetaPoco.Column]
        public string UserName { get; set; }

        [PetaPoco.Column]
        public string PassWord { get; set; }

        [PetaPoco.Column]
        public string Room { get; set; }
    }
}
