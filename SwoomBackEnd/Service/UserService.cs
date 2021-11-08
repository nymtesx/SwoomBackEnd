using SwoomBackEnd.DTOs;
using SwoomBackEnd.Repository;
using SwoomBackEnd.Repository.IRepository;
using SwoomBackEnd.Service.IService;

namespace SwoomBackEnd.Service
{
    public class UserService : IUserService
    {
        private readonly IUserRepository _userRepo;
        
        public UserService(IUserRepository userRepo)
        {
            _userRepo = userRepo;
        }

        public UserDTO GetUserById(int userId)
        {
            return _userRepo.GetUserById(userId);
        }
    }
}