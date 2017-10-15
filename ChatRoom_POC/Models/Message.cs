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
        [Column]
        public int ChatRoomID { get; set; }
        [ForeignKey("ChatRoomID")]
        public ChatRoom chatRoom { get; set; }
        //[Column]
        public int? CreatedByID { get; set; }
        [ForeignKey("CreatedByID")]
        public User CreatedBy { get; set; }
    }
}