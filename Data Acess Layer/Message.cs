using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace Data_Acess_Layer
{
    public  class Message
    {
        public int ID { get; set; }
        public int SenderId { get; set; }
        public string Content { get; set;}
        public DateTime CreateAt { get; init; } = DateTime.Now;
        public bool ISGroup { get; set; } = false;
        public int? GroupId { get; set; }



    }
}
