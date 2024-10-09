using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data_Acess_Layer
{
    public  class UserMessage
    {
        [ForeignKey(nameof(UserMessage.Message))]
        public int MessageId { get; set; }
        public virtual Message Message { get; set; }
        [ForeignKey(nameof(UserMessage.Sender))]
        public string  SenderId { get; set; } 
        public virtual User Sender { get; set; }
        [ForeignKey(nameof(UserMessage.Reciver))]
        public  string  ReciverId { get; set; }
        public virtual User Reciver { get; set; }

    }
}
