using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace ChatRoom_POC.Models
{
    public class Admin: User
    {
        [EmailAddress]
        [Column]
        public string Email { get; set; }
        [Column]
        public UserStatus UserStatus { get; set; }
    }
}