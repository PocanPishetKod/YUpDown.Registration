using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Mvc;
using YUpDown.Registration.Application.Dtos;
using YUpDown.Registration.Application.Services;

namespace YUpDown.Rest.Controllers
{
    [Route("transferrings")]
    [ApiController]
    public class TransferringController : ControllerBase
    {
        private readonly ITransferringService _registrationService;

        public TransferringController(ITransferringService registrationService)
        {
            _registrationService = registrationService;
        }

        [HttpPost]
        public async Task<IActionResult> RegisterTeansferring([Required] RegistrationDto dto)
        {
            try
            {
                var result = await _registrationService.Register(dto);
                return Ok(result);
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex);
            }
        }
    }
}
