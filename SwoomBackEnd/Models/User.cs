using System;

namespace SwoomBackEnd.Models
{
    public class User
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public string CurrentAddress { get; set; }
        public Account Account { get; set; }
    }

    public class Account
    {
        public string Username { get; set; }
        public string Password { get; set; }
        public DateTime LastLogin { get; set; }
        public bool Premium { get; set; }
    }
}