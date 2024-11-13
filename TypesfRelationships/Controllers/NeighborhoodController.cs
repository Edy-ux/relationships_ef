using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using TypesfRelationships.Context;
using TypesfRelationships.Dtos;
using TypesfRelationships.Model;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace TypesfRelationships.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class NeighborhoodController : ControllerBase
    {
        private readonly AppDbContext _context;

        public NeighborhoodController(AppDbContext context)
        {
            _context = context;
        }

        [HttpPost]
        public async Task<IActionResult> CreateHouse(CreateHouseDTO house)
        {

            HouseModel newHouse = new()
            {
                Description = house.Description,
                Address = new AddressModel
                {

                    Street = house.Address.Street,
                    Number = house.Address.Number,
                    City = house.Address.City,
                },
                Rooms = house.Rooms.Select(r => new RoomModel { Description = r.Description }).ToList(),
                Residents = house.Residents.Select(r => new ResidentModel { Name = r.Name }).ToList()


            };

            _context.Houses.Add(newHouse);

            await _context.SaveChangesAsync();

            var output = await _context.Houses.Include(e => e.Address).Include(e => e.Rooms).Include(e => e.Residents).ToListAsync();
            return Ok(output);

        }
        [HttpGet]
        public async Task<IActionResult> Get()
        {

            var houses = await _context.Houses.Include(e => e.Address).Include(e => e.Rooms).Include(e => e.Residents).ToListAsync();

            return (houses.Count == 0) ?
                     Ok(Enumerable.Empty<HouseModel>())
                      : Ok(houses);

        }

    }
}
