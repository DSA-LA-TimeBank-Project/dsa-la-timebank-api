using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using DSA.LA.TimeBank.API.Models;
using DSA.LA.TimeBank.Core.Interfaces.API;

namespace DSA.LA.TimeBank.API.Controllers.v1
{
    [AllowAnonymous]
    [Route("api/v1/[controller]")]
    [ApiController]
    public class HelloWorldController : ControllerBase
    {
        [AllowAnonymous]
        [HttpGet]
        public ActionResult<IResponse> Get()
        {
            Response response = new()
            {
                IsSuccess = true,
                Message = "Hello World from DSA-LA TimeBank!"
            };

            return Ok(response);
        }
    }
}
