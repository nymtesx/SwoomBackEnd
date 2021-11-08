using SwoomBackEnd.DTOs;
using SwoomBackEnd.Models;

namespace SwoomBackEnd.Repository.IRepository
{
    public interface IRoomRepository
    {
        public RoomDTO GetRoomById(int roomId);
    }
}