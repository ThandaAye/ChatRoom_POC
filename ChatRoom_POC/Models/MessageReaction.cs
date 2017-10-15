using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace ChatRoom_POC.Models
{
    public class MessageReaction
    {
        [Key]
        public int MessageReactionID { get; set; }

        public int MessageID { get; set; }
        [ForeignKey("MessageID")]
        public virtual Message Message { get; set; }

        public Reaction Reaction { get; set; }

        public int ReactedByID { get; set; }
        [ForeignKey("ReactedByID")]
        public virtual User ReactedBy { get; set; }
    }
}