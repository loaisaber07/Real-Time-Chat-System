using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data_Acess_Layer
{
    public  class Group
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int GroupId { get; set;}
        [Required]
        public string GroupName { get; set;}
        public DateTime CreateAt { get; init; } = DateTime.UtcNow;
        #region Mapping the relation between Creating User and Group
        [ForeignKey(nameof(Group.UserCreatedBy))]
        public string CreatedUserId { get; set; }
        public User UserCreatedBy { get; set; }
        #endregion
    }
}
