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

namespace Casus_SocialBrothers.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AddressesController : ControllerBase
    {
        private readonly appDBcontext _context;

        public AddressesController(appDBcontext context)
        {
            _context = context;
        }

        // GET: api/Addresses
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Address>>> GetDept()
        {
            string city = HttpContext.Request.Query["city"].ToString();
            string country = HttpContext.Request.Query["country"].ToString();
            string zip = HttpContext.Request.Query["zip"].ToString();
            string street = HttpContext.Request.Query["street"].ToString();
            int pageSize = 3;
            int pageNumber = 1;
            int id = -1;
            try
            {
                pageNumber = Int32.Parse(HttpContext.Request.Query["pageNumber"].ToString());

            }
            catch (FormatException)
            {

                pageNumber = 1;

            }
            try
            {
                pageSize = Int32.Parse(HttpContext.Request.Query["pageSize"].ToString());

            }
            catch (FormatException)
            {

                pageSize = 3;
            }
            try
            {

                id = Int32.Parse(HttpContext.Request.Query["id"].ToString());
            }
            catch (FormatException)
            {
                id = -1;

            }


            return await _context.Dept.Where(x => (city == "" ||  x.City == city)).Where(x => (street == "" || x.StreetName == street)).Where(x => (country == "" || x.Country == country)).Where(x => (zip == "" || x.ZipCode == zip)).Where(x => (city == "" || x.City == city)).Where(x => (id == -1 || x.ID == id)).Skip((pageNumber - 1) * pageSize).Take(pageSize).ToListAsync();
        }

        // GET: api/Addresses/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Address>> GetAddress(int id)
        {
            var address = await _context.Dept.FindAsync(id);

            if (address == null)
            {
                return NotFound();
            }
            return address;
        }

        // PUT: api/Addresses/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutAddress(int id, Address address)
        {
            if (id != address.ID)
            {
                return BadRequest();
            }

            _context.Entry(address).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!AddressExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return NoContent();
        }

        // POST: api/Addresses
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<Address>> PostAddress(Address address)
        {
           bool dutch = await CheckAddress(address.ZipCode);
            if (dutch)
            {
                _context.Dept.Add(address);
                await _context.SaveChangesAsync();

                return CreatedAtAction("GetAddress", new { id = address.ID }, address);
            }
            return null;
        }

        // DELETE: api/Addresses/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteAddress(int id)
        {
            var address = await _context.Dept.FindAsync(id);
            if (address == null)
            {
                return NotFound();
            }

            _context.Dept.Remove(address);
            await _context.SaveChangesAsync();

            return NoContent();
        }
        private async Task<bool> CheckAddress(string zip)
        {

            using (var client = new HttpClient())
            {
                string access_key = "672c8c45fe6c28e30255ae645f4a3200";

                //TODO - send HTTP requests
                client.BaseAddress = new Uri("http://api.positionstack.com/v1/forward?");
                client.DefaultRequestHeaders.Accept.Clear();
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

                HttpResponseMessage response = await client.GetAsync("access_key=" + access_key + "&query=" + zip);
                double lat = 0;
                double lon = 0;
                if (response.IsSuccessStatusCode)
                {
                    var json = response.Content.ReadAsStringAsync().Result;
                    dynamic jsonObject = JsonConvert.DeserializeObject(json);
                    if (jsonObject.resourceSets.Count > 0)
                    {
                        if (jsonObject.resourceSets[0].resources.Count > 0)
                        {
                            lat = jsonObject.resourceSets[0].resources[0].point.coordinates[0];
                            lon = jsonObject.resourceSets[0].resources[0].point.coordinates[1];
                            string l = lat + "," + lon;
                            return true;
                        }
                    }
                }
            }
            Console.WriteLine("Sorry, we only support Dutch addresses.");
            return false;
        }
        private bool AddressExists(int id)
        {
            return _context.Dept.Any(e => e.ID == id);
        }
    }
}
