using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;


namespace ChatRoom_POC.Context
{
    public class ChatRoomInitializer :CreateDatabaseIfNotExists<ChatRoomContext>
    {
    }
}