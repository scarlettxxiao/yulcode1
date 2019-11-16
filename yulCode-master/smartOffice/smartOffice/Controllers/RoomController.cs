using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using smartOffice.Models;

namespace smartOffice.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RoomController : ControllerBase
    {
        public static async Task<List<Room>> GetAllRoomsAsync()
        {
            List<Room> rooms = new List<Room>();
            using (var client = new HttpClient())
            {
                var response = await client.GetAsync("https://staryu.azurewebsites.net/yulcode/rooms"); ;
                Console.WriteLine(response.StatusCode);
                if (response.IsSuccessStatusCode)
                {
                    rooms = await response.Content.ReadAsAsync<List<Room>>();
                }
                return rooms;
            }
        }

        public static async Task<Room> GetRoomAsync(int id)
        {
            Room room = null;
            using (var client = new HttpClient())
            {
                var response = await client.GetAsync("https://staryu.azurewebsites.net/yulcode/rooms" + id); ;
                Console.WriteLine(response.StatusCode);
                if (response.IsSuccessStatusCode)
                {
                    room = await response.Content.ReadAsAsync<Room>();
                }
                return room;
            }
        }


    }
}
