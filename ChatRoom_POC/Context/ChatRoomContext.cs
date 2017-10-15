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

        public DbSet<MessageReaction> MessageReaction { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Message>()
                .HasRequired<User>(s => s.CreatedBy)
                .WithMany()
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<MessageReaction>()
                .HasRequired<User>(s => s.ReactedBy)
                .WithMany()
                .WillCascadeOnDelete(false);
        }

    }
}