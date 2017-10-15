using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace ChatRoom_POC.Models
{
    public class ChatRoom
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ChatRoomID { get; set; }

        [Required]
        public int OwnerID { get; set; }
        [ForeignKey("OwnerID")]
        public virtual User Owner { get; set; }

        public virtual ICollection<Message> Messages { get; set; }
    }
}