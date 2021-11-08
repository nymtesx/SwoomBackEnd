using System;
using SwoomBackEnd.Models;

namespace SwoomBackEnd.DTOs
{
    public class UserDTO
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public string CurrentAddress { get; set; }
        public Account Account { get; set; }
    }
}