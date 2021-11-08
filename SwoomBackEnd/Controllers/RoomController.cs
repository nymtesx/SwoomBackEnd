using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using SwoomBackEnd.DTOs;
using SwoomBackEnd.Service.IService;

namespace SwoomBackEnd.Controllers
{
    [ApiController]
    public class RoomController : Controller
    {
        private readonly IRoomService _roomService;

        public RoomController(IRoomService roomService)
        {
            _roomService = roomService;
        }
        
        [HttpGet("/[action]")]
        public RoomDTO GetRoomById(int roomId)
        {
            return _roomService.GetRoomById(roomId);
        }
    }
}