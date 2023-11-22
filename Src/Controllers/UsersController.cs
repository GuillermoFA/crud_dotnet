using System.Text.Json;
using System.Text.Json.Serialization;
using apinet.Src.Data;
using apinet.Src.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace apinet.Src.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class UserController : ControllerBase
    {
        
        private DataContext _context;
        public UserController(DataContext context)
        {
            _context = context;
        }

        [HttpGet]
        public async Task<ActionResult<List<User>>> Get()
        {
            var users = await _context.Users
                .Include(u => u.Interests)
                .Include(u => u.Frameworks)
                .Include(u => u.SocialNetworks)
                .ToListAsync();

            var jsonSettings = new JsonSerializerOptions
            {
                ReferenceHandler = ReferenceHandler.Preserve,
                MaxDepth = 256 // Ajusta este valor según sea necesario
            };

            var json = JsonSerializer.Serialize(users, jsonSettings);

            return Ok(json);
        }

        [HttpPut("user/{id}")]
        public async Task<ActionResult<User>> PutUser(int id, [FromBody] User updatedUser)
        {
            var existingUser = await _context.Users.FindAsync(id);

            if (existingUser == null)
            {
                return NotFound(new { ErrorMessage = "Usuario no encontrado." });
            }

            // Validar el modelo antes de realizar cambios
            if (!ModelState.IsValid)
            {
                return BadRequest(new { ErrorMessage = "La solicitud contiene datos no válidos.", Errors = ModelState.Values.SelectMany(v => v.Errors) });
            }

            // Asignar manualmente las propiedades actualizadas
            existingUser.Name = updatedUser.Name;
            existingUser.Description = updatedUser.Description;
            existingUser.Age = updatedUser.Age;
            existingUser.Country = updatedUser.Country;
            existingUser.City = updatedUser.City;
            existingUser.Email = updatedUser.Email;

            await _context.SaveChangesAsync();
            return existingUser;
        }

        [HttpPut("framework/{id}")]
        public async Task<ActionResult<Framework>> PutFramework(int id, [FromBody] Framework updatedFramework)
        {
            var existingFramework = await _context.Frameworks.FindAsync(id);

            if (existingFramework == null)
            {
                return NotFound(new { ErrorMessage = "Framework no encontrado." });
            }

            // Validar el modelo antes de realizar cambios
            if (!ModelState.IsValid)
            {
                return BadRequest(new { ErrorMessage = "La solicitud contiene datos no válidos.", Errors = ModelState.Values.SelectMany(v => v.Errors) });
            }

            // Asignar manualmente las propiedades actualizadas
            existingFramework.Name = updatedFramework.Name;
            existingFramework.Description = updatedFramework.Description;

            await _context.SaveChangesAsync();
            return existingFramework;
        }

        [HttpPut("interest/{id}")]
        public async Task<ActionResult<Interest>> PutInterest(int id, [FromBody] Interest updatedInterest)
        {
            var existingInterest = await _context.Interests.FindAsync(id);

            if (existingInterest == null)
            {
                return NotFound(new { ErrorMessage = "Interés no encontrado." });
            }

            // Validar el modelo antes de realizar cambios
            if (!ModelState.IsValid)
            {
                return BadRequest(new { ErrorMessage = "La solicitud contiene datos no válidos.", Errors = ModelState.Values.SelectMany(v => v.Errors) });
            }

            // Asignar manualmente las propiedades actualizadas
            existingInterest.Description = updatedInterest.Description;

            await _context.SaveChangesAsync();
            return existingInterest;
        }

        [HttpPut("socialnetwork/{id}")]
        public async Task<ActionResult<SocialNetwork>> PutSocialNetwork(int id, [FromBody] SocialNetwork updatedSocialNetwork)
        {
            var existingSocialNetwork = await _context.SocialNetworks.FindAsync(id);

            if (existingSocialNetwork == null)
            {
                return NotFound(new { ErrorMessage = "Red social no encontrada." });
            }

            // Validar el modelo antes de realizar cambios
            if (!ModelState.IsValid)
            {
                return BadRequest(new { ErrorMessage = "La solicitud contiene datos no válidos.", Errors = ModelState.Values.SelectMany(v => v.Errors) });
            }

            // Asignar manualmente las propiedades actualizadas
            existingSocialNetwork.Url = updatedSocialNetwork.Url;

            await _context.SaveChangesAsync();
            return existingSocialNetwork;
        }
    }


        
    
}