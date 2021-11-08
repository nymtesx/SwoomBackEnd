using SwoomBackEnd.DTOs;
using SwoomBackEnd.Repository.IRepository;
using SwoomBackEnd.Service.IService;

namespace SwoomBackEnd.Service
{
    public class RoomService : IRoomService
    {
        private readonly IRoomRepository _roomRepo;
        
        public RoomService(IRoomRepository roomRepo)
        {
            _roomRepo = roomRepo;
        }
        
        public RoomDTO GetRoomById(int roomId)
        {
            return _roomRepo.GetRoomById(roomId);
        }
    }
}