using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace Data_Acess_Layer
{
    public  class Message
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]

        public int ID { get; set; }
       
        [Required]
        public string Content { get; set;}

        public DateTime CreateAt { get; init; } = DateTime.Now;
        public bool ISGroup { get; set; } = false;
        public int? GroupId { get; set; }
        #region Relation Between Message and User
        [ForeignKey(nameof(Sender))]
        public int SenderId { get; set; }
        public virtual User Sender { get; set; }
        #endregion

    }
}
