using SwoomBackEnd.DTOs;

namespace SwoomBackEnd.Repository.IRepository
{
    public interface IUserRepository
    {
        public UserDTO GetUserById(int userId);
    }
}