using Api.Domain.DTOs;
using Api.Domain.Interfaces.Services.User;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Threading.Tasks;

namespace Api.Application.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LoginController : ControllerBase
    {
        // Injeção de depencia direto no metodo.
        [HttpPost]
        public async Task<object> Login([FromBody] LoginDto loginDto, [FromServices] ILoginService service)
        {
            if (loginDto == null)
                return StatusCode(StatusCodes.Status400BadRequest);

            try
            {
                var result = await service.FindByLogin(loginDto);
                if (result == null)
                    return NotFound();
                return Ok(result);
            }
            catch (ArgumentException e)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, e.Message);
            }
        }
    }
}