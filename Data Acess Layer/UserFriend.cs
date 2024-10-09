using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data_Acess_Layer
{
    public  class UserFriend
    {
        [ForeignKey(nameof(UserFriend.SendUser))]
        public string SenderId { get; set; }
        public virtual User SendUser { get; set; }
        [ForeignKey(nameof(UserFriend.Friend))]
        public string FriendId { get; set; }
        public virtual User Friend { get; set; }
    }
}
