using Mango.Services.AuthAPI.Data;
using Mango.Services.AuthAPI.Models;
using Mango.Services.AuthAPI.Models.Dto;
using Mango.Services.AuthAPI.Service.IService;
using Microsoft.AspNetCore.Identity;

namespace Mango.Services.AuthAPI.Service
{
    public class AuthService : IAuthService
    {
        private readonly AppDbContext _db;
        private readonly UserManager<ApplicationUser> _userManager;
        private readonly RoleManager<IdentityRole> _roleManageer;

        public AuthService(AppDbContext db, UserManager<ApplicationUser> userManager, RoleManager<IdentityRole> roleManageer)
        {
            _db = db;
            _userManager = userManager;
            _roleManageer = roleManageer;
        }

        public Task<LoginResponseDto> Login(LoginRequestDTO loginRequestDto)
        {
            throw new NotImplementedException();
        }

        public async Task<string> Register(RegistrationRequestDto registrationRequestDto)
        {
            ApplicationUser user = new()
            {
                UserName = registrationRequestDto.Email,
                Email = registrationRequestDto.Email,
                Name = registrationRequestDto.Name,
                PhoneNumber = registrationRequestDto.PhoneNumber,
            };
            try
            {
                var result = await _userManager.CreateAsync(user, registrationRequestDto.Password);
                if (result.Succeeded)
                {
                    var userToReturn = _db.Applicationusers.First(u => u.UserName == registrationRequestDto.Email);
                    UserDto userDto = new()
                    {
                        Email = userToReturn.Email,
                        Name = registrationRequestDto.Name,
                        PhoneNumber = registrationRequestDto.PhoneNumber,
                        ID = userToReturn.Id
                    };
                    return "";
                }
                else
                {
                    return result.Errors.FirstOrDefault().Description;
                }
            }
            catch (Exception)
            {

                throw;
            }
            return "Error encountered";
        }
    }
}
