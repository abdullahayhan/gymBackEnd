using ArenaGym.DTOS;
using AutoMapper;
using DAL.Itoken;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using MODEL.Entities;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;

namespace ArenaGym.Controllers
{
    public class AccountController : BaseApiController
    {
        // user işlemleri için usermanager kullan ve appuserı içine ver.
        private readonly UserManager<AppUser> userManager;

        // Giriş yapıldı mı yapılmadı mı kontrol etmek için.
        private readonly SignInManager<AppUser> signInManager;

        // token için
        private readonly ITokenService tokenService;

        //mapper için
        private readonly IMapper mapper;
        public AccountController(UserManager<AppUser> userManager, SignInManager<AppUser> signInManager,
          ITokenService tokenService, IMapper mapper)
        {
            this.userManager = userManager;
            this.signInManager = signInManager;
            this.tokenService = tokenService;
            this.mapper = mapper;
        }

        [HttpPost("login")]
        public async Task<ActionResult<UserDTO>> Login(LoginDTO loginDto)
        {
            var user = await userManager.FindByEmailAsync(loginDto.Email);
            var result = await signInManager.CheckPasswordSignInAsync(user, loginDto.Password, false);
            if (result.Succeeded)
            {
                return new UserDTO
                {
                    Email = user.Email,
                    DisplayName = user.DisplayName,
                    Token = tokenService.CreateToken(user)
                };
            }
            return null;
        }

        [Authorize]
        [HttpGet]
        public async Task<ActionResult<UserDTO>> GetCurrentUser()
        {
            var email = HttpContext.User?.Claims?.FirstOrDefault(x => x.Type == ClaimTypes.Email)?.Value;
            var user = await userManager.FindByEmailAsync(email);
            return new UserDTO
            {
                DisplayName = user.DisplayName,
                Email = user.Email,
                Token = tokenService.CreateToken(user)
            };
        }
    }
}
