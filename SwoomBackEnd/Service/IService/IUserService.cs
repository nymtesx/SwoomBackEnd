using SwoomBackEnd.DTOs;

namespace SwoomBackEnd.Service.IService
{
    public interface IUserService
    {
        public UserDTO GetUserById(int userId);
    }
}