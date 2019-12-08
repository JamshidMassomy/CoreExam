using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.IdentityModel.Logging;
using Microsoft.IdentityModel.Tokens;
using XM.Application.Login.Queries;
using XM.Application.Users.Queries;

namespace Exam.Controllers
{
    public class AdminController : BaseController
    {
        public IConfiguration Configuration;
        public AdminController(IConfiguration _Configuration)
        {
            this.Configuration = _Configuration;
        }
        [HttpPost]
        [AllowAnonymous]
        public IActionResult CreateToken([FromBody]GetLoginQuery login)
        {
            IActionResult response = Unauthorized();
            var user = Authentic(login);
            if (user != null)
            {
                var tokenString = BuildToken(user);
                response = Ok(new { tokenString });
            }
            return response;
        }
        private GetUsersQuery Authentic(GetLoginQuery login)
        {
            GetUsersQuery user = null;
            if(login.UserName == "Jamshid" && login.Password == "password")
            {
                user = new GetUsersQuery { Name = "Jamshid", Phone = 1223, Email = "massomy@email.com" };
            }
            return user;
        }

        private string BuildToken(GetUsersQuery user)
        {
            IdentityModelEventSource.ShowPII = true;
            var key =new SymmetricSecurityKey(Encoding.UTF8.GetBytes("hsfhs i thi si sfs fsjlk   ljsf  jsfl  ljsfl sdfj   jksfk s  sf j ld"));
            var creds =  new SigningCredentials(key, SecurityAlgorithms.HmacSha256);

            var token = new JwtSecurityToken(Configuration["JWT:ISSUER"],
              Configuration["JWT:ISSUER"],
              expires: DateTime.Now.AddMinutes(30),
              signingCredentials: creds);

            return new JwtSecurityTokenHandler().WriteToken(token);
        }

       
    }
}