using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SafenedAPI.Models;
using SafenedAPI.Service;

namespace SafenedAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly IUserService userService;

        /// <summary>
        /// The constructor
        /// </summary>
        /// <param name="userService"></param>
        public UserController(IUserService userService)
        {
            this.userService = userService;
        }

        /// <summary>
        /// Action to login with username and password.
        /// </summary>
        /// <param name="model">Model to login with username and password</param>
        /// <returns>Returns the boolean result of login</returns>
        /// <response code="200">Returned if the login was successful</response>
        /// <response code="400">Returned if the model couldn't be parsed or the login was not made</response>
        /// <response code="422">Returned when the validation failed</response>
        [HttpPost("login")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public ActionResult Login(LoginModel model)
        {
            var result = userService.Login(model.UserName, model.Password);
            if (result)
            {
                return Ok(result);
            }

            return BadRequest("Wrong username or password");
        }
    }
}
