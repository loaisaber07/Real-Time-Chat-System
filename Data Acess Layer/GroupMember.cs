using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data_Acess_Layer
{
    public  class GroupMember
    {
        public DateTime JoinedAt { get; init; } = DateTime.UtcNow;

        #region Composite Keys (groupId and UserId)
        [ForeignKey(nameof(GroupMember.Group))]
        public  int GroupId { get; set; } 
        public virtual Group Group { get; set; }
        [ForeignKey(nameof(GroupMember.User))]
        public string UserId { get; set; }
        public virtual User User { get; set; }
        #endregion
    }
}
