using SwoomBackEnd.DTOs;

namespace SwoomBackEnd.Service.IService
{
    public interface IRoomService
    {
        public RoomDTO GetRoomById(int roomId);
    }
}