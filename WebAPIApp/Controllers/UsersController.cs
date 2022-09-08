using Microsoft.AspNetCore.Mvc;
using WebAPIApp.Data.EFCore;
using WebAPIApp.Models;

namespace WebAPIApp.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsersController : WebAPIAppController<User, EfCoreUserRepository>
    {
        public UsersController(EfCoreUserRepository repository)
            : base(repository)
        {
        }
    }
}
