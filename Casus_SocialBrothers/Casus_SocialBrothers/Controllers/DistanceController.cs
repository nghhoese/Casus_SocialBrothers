using GeoCoordinatePortable;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Casus_SocialBrothers;
using System.Net.Http;
using System.Net.Http.Headers;
using Newtonsoft.Json;
using Nest;



namespace Casus_SocialBrothers.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DistanceController : ControllerBase
    {
        private readonly appDBcontext _context;

        public DistanceController(appDBcontext context)
        {
            _context = context;
        }



        // GET: api/Distance/5
        [HttpGet("{id}/{id2}")]
        public async Task<ActionResult<double>> GetAddress(int id,int id2)
        {
            var address = await _context.Dept.FindAsync(id);
            var address2 = await _context.Dept.FindAsync(id2);

            if (address == null || address2 == null)
            {
                return NotFound();
            }

            var l = await this.GetCoordinates(address.ZipCode);
            var l2 = await this.GetCoordinates(address2.ZipCode);
            if(l == null || l2 == null)
            {
                return 0;
            }
            double lon1 = -1;
            double lon2 = -1;
            double lat1 = -1;
            double lat2 = -1;
            try
            {
                lon1 = double.Parse(l.Split(",")[0] + "," + l.Split(",")[1]);
                lon2 = double.Parse(l2.Split(",")[0] + "," + l2.Split(",")[1]);
                lat1 = double.Parse(l.Split(",")[2] + "," + l.Split(",")[3]);
                lat2 = double.Parse(l2.Split(",")[2] + "," + l2.Split(",")[3]);


            }
            catch (FormatException)
            {

               
            }
            GeoCoordinatePortable.GeoCoordinate coord1 = new GeoCoordinatePortable.GeoCoordinate(lat1, lon1);
            GeoCoordinatePortable.GeoCoordinate coord2 = new GeoCoordinatePortable.GeoCoordinate(lat2, lon2);
            
            var distance = coord1.GetDistanceTo(coord2) / 1000;

            return distance;
        }

       
        private async Task<string> GetCoordinates(string zip)
        {

            using (var client = new HttpClient())
            {
                string access_key = "672c8c45fe6c28e30255ae645f4a3200";

                //TODO - send HTTP requests
                client.BaseAddress = new Uri("http://api.positionstack.com/");
                client.DefaultRequestHeaders.Accept.Clear();
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

                //-----
                //vervang NL door variabele country omgezet naar NL, UK, US, etc.
                HttpResponseMessage response = await client.GetAsync("v1/forward?access_key=" + access_key + "&query=" + zip);
                double lat = 0;
                double lon = 0;
                if (response.IsSuccessStatusCode)
                {
                    var json = response.Content.ReadAsStringAsync().Result;
                    dynamic jsonObject = JsonConvert.DeserializeObject(json);
                    Console.WriteLine(jsonObject.data);


                    if (jsonObject.data.Count > 0)
                    {
                        if (jsonObject.data[0].latitude != null) {
                        lat = jsonObject.data[0].latitude;
                        lon = jsonObject.data[0].longitude;
                        string l = lat + "," + lon;
                        return l;
                    }
                    }
                }
            }
            Console.WriteLine("Sorry, we only support Dutch addresses.");
            return null;
        }

        private bool AddressExists(int id)
        {
            return _context.Dept.Any(e => e.ID == id);
        }
       

    }
}
