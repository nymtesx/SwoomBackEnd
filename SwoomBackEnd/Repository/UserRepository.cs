using System;
using SwoomBackEnd.DTOs;
using SwoomBackEnd.Models;
using SwoomBackEnd.Repository.IRepository;

namespace SwoomBackEnd.Repository
{
    public class UserRepository : IUserRepository
    {
        //Somewhere DBContext for db connection
        public UserDTO GetUserById(int userId)
        {
            return new UserDTO
            {
                Name = "Hank",
                Age = 12,
                CurrentAddress = "Roffa",
                Account = new Account
                {
                    Username = "Hank123",
                    LastLogin = new DateTime(),
                    Password = "Test",
                    Premium = true
                }
            };
        }
    }
}