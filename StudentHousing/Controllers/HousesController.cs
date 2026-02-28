using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;


namespace StudentHousing.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class HousesController(IHouseService houseService) : ControllerBase
    {
        private readonly IHouseService _houseService = houseService;

        [HttpGet]
        public async Task<IActionResult> GetAllHouses(CancellationToken cancellation = default)
        {
            var houses = await _houseService.GetAllHouses(cancellation);
            return Ok(houses);
        }

        [HttpGet]
        public async Task<IActionResult> GetHouseById(int id, CancellationToken cancellation = default)
        {
            var house = await _houseService.GetHouseById(id, cancellation);
            
            return house is null ? NotFound() : Ok(house);
        }

        [HttpPost]
        public async Task<IActionResult> CreateHouse(HouseRequest request, CancellationToken cancellation = default)
        {
            var house = await _houseService.CreateHouse(request, cancellation);
            return CreatedAtAction(nameof(GetHouseById), new { id = house.Id }, house);
        }

        [HttpPut]
        public async Task<IActionResult> UpdateHouse(HouseRequest request, int id, CancellationToken cancellation = default) 
        {
            var isUpdated = await _houseService.UpdateHouse(request, id, cancellation);
            return isUpdated ? NoContent() : NotFound(); 
        }

        [HttpDelete]
        public async Task<IActionResult> DeleteHouse(int id, CancellationToken cancellation = default)
        {
            var isDeleted = await _houseService.DeleteHouse(id, cancellation);

            return isDeleted ? NoContent() : NotFound();
        }
    }
}
