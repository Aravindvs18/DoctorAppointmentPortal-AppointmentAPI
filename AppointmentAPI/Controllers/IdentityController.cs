using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using AppointmentAPI.Models;
using Microsoft.AspNetCore.Identity;

namespace AppointmentAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class IdentityController : ControllerBase
    {
        private readonly UserManager<IdentityUser> _userManager;
        private readonly SignInManager<IdentityUser> _signInManager;

        public IdentityController(UserManager<IdentityUser> userManager,SignInManager<IdentityUser> signInManager)
        {
            _userManager = userManager;
            _signInManager = signInManager;
        }


        [HttpPost("login")]

        public async Task< IActionResult> Login(UserDetail userDetail)
        {
            var userFromDb = await _userManager.FindByEmailAsync(userDetail.UserEmail);

            if(userFromDb == null)
            {
                return BadRequest();
            }

            var result = await _signInManager.CheckPasswordSignInAsync(userFromDb, userDetail.UserPassword, false);

            if (!result.Succeeded) {
                return BadRequest();
            
            }
            return Ok(new
            {
                result = result,
                username = userFromDb.UserName,
                email = userFromDb.Email,
                uniqueid= userFromDb.Id
                

            });
        }

        [HttpPost("signup")]

        public async Task< IActionResult> signup(UserDetail userDetail)
        {
            var userToCreate = new IdentityUser
            {
                Email = userDetail.UserEmail,
                UserName = userDetail.UserName,                
            };

            var result = await _userManager.CreateAsync(userToCreate, userDetail.UserPassword);


            if (result.Succeeded)
            {
                return Ok(result);
            }
            return BadRequest(result);
            
        }




    }
}