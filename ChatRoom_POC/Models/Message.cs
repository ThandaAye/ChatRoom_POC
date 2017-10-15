using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace ChatRoom_POC.Models
{
    public class Message
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int MessageID { get; set; }

        public int ChatRoomID { get; set; }
        [ForeignKey("ChatRoomID")]
        public virtual ChatRoom ChatRoom { get; set; }

        public int CreatedByID { get; set; }
        [ForeignKey("CreatedByID")]
        public virtual User CreatedBy { get; set; }

        [Required(AllowEmptyStrings = false)]
        [StringLength(10000000)]
        public string Value { get; set; }

        public virtual ICollection<MessageReaction> MessageReactions { get; set; }

        public override string ToString()
        {
            return "id: " + MessageID + " value: " + Value;
        }
    }
}