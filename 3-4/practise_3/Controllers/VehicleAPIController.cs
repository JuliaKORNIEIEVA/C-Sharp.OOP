using WebApplication1.Data;
using Microsoft.AspNetCore.Mvc;
using WebApplication1.Models.Dto;

namespace WebApplication1.Controllers
{
    [Route("api/VehicleAPI")]
    [ApiController]
    public class VehicleAPIController : ControllerBase
    {
        private readonly ApplicationDbContext _db;

        public VehicleAPIController(ApplicationDbContext db)
        {
            _db = db;
        }

        [HttpGet]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public ActionResult<IEnumerable<VehicleDTO>> GetVehicles()
        {
            return Ok(_db.Vehicle);
        }

        [HttpGet("{id}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public ActionResult<VehicleDTO> GetVehicle(int id)
        {
            if (id == 0)
            {
                return BadRequest();
            }

            var vehicle = _db.Vehicle.FirstOrDefault(d => d.Id == id);

            if (vehicle == null)
            {
                return BadRequest();
            }
            return Ok(vehicle);
        }

        [HttpPost]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public ActionResult<VehicleDTO> CreateVehicle([FromBody] Vehicle vehicleDTO)
        {
            if (vehicleDTO == null)
            {
                return BadRequest(vehicleDTO);
            }

            if (vehicleDTO.Id > 0)
            {
                return StatusCode(StatusCodes.Status500InternalServerError);
            }

            _db.Vehicle.Add(vehicleDTO);
            _db.SaveChanges();

            return Ok(vehicleDTO);
        }

        [HttpDelete]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public ActionResult DeleteVehicle(int id)
        {
            if (id == 0)
            {
                return BadRequest();
            }

            var vehicle = _db.Vehicle.FirstOrDefault(d => d.Id == id);

            if (vehicle == null)
            {
                return NotFound();
            }

            _db.Vehicle.Remove(vehicle);
            _db.SaveChanges();

            return Ok("Vehicle was deleted successfully...");
        }

        [HttpPut]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public ActionResult<VehicleDTO> PutInfo([FromBody] Vehicle vehicleDTO, int id)
        {
            if (id <= 0)
            {
                return BadRequest();
            }

            if (vehicleDTO == null)
            {
                return BadRequest();
            }

            var vehicle = _db.Vehicle.FirstOrDefault(d => d.Id == id);

            if (vehicle == null)
            {
                return NotFound();
            }

            vehicle.Name = vehicleDTO.Name;

            _db.SaveChanges();

            return Ok("Vehicle was updated successfully...");
        }
    }
}