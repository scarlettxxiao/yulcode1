using smartOffice.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;

namespace smartOffice.Controllers
{

    public class LightController
    {
        public int getTime()
        {
            DateTime current = DateTime.Now;
            int hour = current.Hour;
            return hour;
        }

        static Light UpdateLight(Light light)
        {
            int switchcase = DateTime.Now.Hour;
            string color = "#111111";
            switch (switchcase)
            {
                case 6:
                    color = "#FAAS535";
                    break;
                case 7:
                    color = "#EFAA7D";
                    break;
                case 8:
                    color = "#E9B9AF";
                    break;
                case 9:
                    color = "#E6C2AA";
                    break;
                case 10:
                    color = "#F5EAA0";
                    break;
                case 11:
                    color = "#F953CE";
                    break;
                case 12:
                    color = "#FFFFFC";
                    break;
                case 13:
                    color = "#F953CE";
                    break;
                case 14:
                    color = "#F5EAA0";
                    break;
                case 15:
                    color = "#E9B9AF";
                    break;
                case 16:
                    color = "#E9B9AF";
                    break;
                case 17:
                    color = "#EFAA7D";
                    break;
                case 18:
                    color = "#FAAS535";
                    break;
                default:
                    break;
            }
            light.hexColor = color;
            return light;
        }

        static async Task<Light> UpdateColorAsync(Light light)
        {
            using (var client = new HttpClient())
            {
                HttpResponseMessage response = await client.PutAsJsonAsync(
                      "staryu.azurewebsites.net/yulcode/light/" + light.hexColor, light);
                response.EnsureSuccessStatusCode();
                // Deserialize the updated product from the response body.
                light = await response.Content.ReadAsAsync<Light>();
                return light;
            }
        }
    }
}
