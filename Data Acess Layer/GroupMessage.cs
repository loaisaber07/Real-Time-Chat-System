using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data_Acess_Layer
{
    public  class GroupMessage
    {
        [ForeignKey(nameof(GroupMessage.Message))]
        public int MessageId { get; set; }
        public virtual Message Message { get; set; }
        [ForeignKey(nameof(GroupMessage.Group))]
        public int GroupId { get; set; }
        public virtual Group Group { get; set; }
        [ForeignKey(nameof(GroupMessage.User))]
        public string SenderId { get; set; }
        public virtual User User { get; set; }
    }
}
