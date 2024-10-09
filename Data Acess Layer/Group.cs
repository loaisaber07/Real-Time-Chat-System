using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data_Acess_Layer
{
    public  class Group
    {
        public int GroupId { get; set;}
        public string GroupName { get; set;}
        public DateTime CreateAt { get; init; } = DateTime.UtcNow;
        [ForeignKey(nameof(Group.CreateBy))]
        public int Userid { get; set; }
        public User CreateBy { get; set; }
    }
}
