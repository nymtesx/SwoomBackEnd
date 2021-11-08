using SwoomBackEnd.DTOs;
using SwoomBackEnd.Models;
using SwoomBackEnd.Repository.IRepository;

namespace SwoomBackEnd.Repository
{
    public class RoomRepository : IRoomRepository
    {
        //Somewhere DBContext for db connection
        public RoomDTO GetRoomById(int roomId)
        {
            return new RoomDTO
            {
                Name = "Icon",
                Address = "Balcony",
                MonthlyRent = 345.23
            };
        }
    }
}