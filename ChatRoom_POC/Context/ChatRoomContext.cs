using ChatRoom_POC.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace ChatRoom_POC.Context
{
    public class ChatRoomContext: DbContext
    {
        public ChatRoomContext(): base("name=ChatRoomConnectionString")      {

        }
        public DbSet<User> User { get; set; }

        public DbSet<ChatRoom> ChatRoom { get; set; }

        public DbSet<Message> Message { get; set; }
    }
}