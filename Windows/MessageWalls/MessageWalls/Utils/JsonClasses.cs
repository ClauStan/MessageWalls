using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MessageWalls.Utils
{
    public class RequestUser
    {
        public string username { get; set; }
        public string password { get; set; }
        public string name { get; set; }
        public string content { get; set; }
        public string date { get; set; }
    }

    public class ResponseJson
    {
        public string value { get; set; }
        public string details { get; set; }
        public string content { get; set; }
        public User user { get; set; }
    }

    public class User
    {
        public string username { get; set; }
        public string password { get; set; }
        public string name { get; set; }
        public string date { get; set; }
        public List<Wall> walls { get; set; }

        public User()
        {
            walls = new List<Wall>();
        }
    }

    public class Wall
    {
        public string name { get; set; }
        public string author { get; set; }
        public string date { get; set; }
        public List<Message> messages { get; set; }

        public Wall()
        {
            messages = new List<Message>();
        }
    }

    public class Message
    {
        public string id { get; set; }
        public string author { get; set; }
        public string date { get; set; }
        public string content { get; set; }
    }
}
