using ChatRoom_POC.Context;
using ChatRoom_POC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ChatRoom_POC.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            // create user
            //ChatRoomContext context = new ChatRoomContext();
            //User user = new User();
            //user.Username = "thanda aye";
            //context.User.Add(user);

            // create admin
            //Admin admin = new Admin();
            //admin.Username = "Thet Min Ko";
            //admin.Email = "dev.minko@gmail.com";
            //context.User.Add(admin);
            //context.SaveChanges();
            return View();
        }

        public ActionResult About()
        {
            // create chatroom
            //ChatRoomContext context = new ChatRoomContext();
            //ChatRoom chatRoom = new ChatRoom();
            //chatRoom.Owner = context.User.Find(1);
            //context.ChatRoom.Add(chatRoom);
            //context.SaveChanges();

            // User user = context.User.Find(1);
            // ViewBag.Something = user.ChatRoom.Messages;
            //ChatRoom chatRoom = context.ChatRoom.Where(x => x.Owner == user).FirstOrDefault();
            //ViewBag.Something = chatRoom.Messages.ToString();

            //ChatRoom chatRoom = context.ChatRoom.Find(1);
            //ViewBag.Message = chatRoom.Messages;
            return View();
        }

        public ActionResult Contact()
        {
            ChatRoomContext context = new ChatRoomContext();
            User user = context.User.Find(1);
            Message message = new Message();
            message.ChatRoom = context.ChatRoom.Find(1);
            message.CreatedBy = context.User.Find(1);
            context.Message.Add(message);
            context.SaveChanges();
            return View();
        }

    }
}