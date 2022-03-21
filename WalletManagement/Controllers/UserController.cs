using Microsoft.AspNetCore.Mvc;
using WalletManagement.Dto;
using WalletManagement.Infrastructure;
using WalletManagement.Models;

namespace WalletManagement.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class UserController : ControllerBase
    {
        private WalletManagementContext _context;
        public UserController(WalletManagementContext wmc)
        {
            _context = wmc;
        }

        [HttpGet]
        public IEnumerable<User> Get()
        {
           return  _context.Users.ToList();
        }

        [HttpPost]
        public UserCreateDto Create(User user)
        {
            try
            {
                _context.Users.Add(user);
                _context.SaveChanges();
            }
            catch (Exception ex)
            {
                var ud = new UserCreateDto();
                ud.Status = false;
                ud.Message = ex.Message;
            }
            return new UserCreateDto
            {
                Status = true,
                Message = "",
                UserName = user.UserName,
                Email = user.Email
            };
        }

        [HttpGet("{id}")]
        public User GetUser(Guid id)
        {
           return  _context.Users.Where(u => u.UserId.ToString() == id.ToString()).FirstOrDefault();
        }

        [HttpPost("{id}")]
        public UserUpdateDto UpdateUser(UserUpdateDto user)
        {
            var tuser = _context.Users.Where(u => u.UserId.ToString() == user.UserId.ToString()).FirstOrDefault();
            tuser.Email = user.Email;
            tuser.PhoneNumber = user.PhoneNumber;
            tuser.State = user.State;
            tuser.Address = user.Address;
            tuser.State = user.State;
            _context.Users.Update(tuser);
            _context.SaveChanges(true);
            return user;
        }
    } 
}