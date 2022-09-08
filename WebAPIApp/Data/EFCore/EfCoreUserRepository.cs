using WebAPIApp.Models;
using WebAPIApp.Models.EFCore;

namespace WebAPIApp.Data.EFCore
{
    public class EfCoreUserRepository : EfCoreRepository<User, WebAPIAppContext>
    {
        public EfCoreUserRepository(WebAPIAppContext context)
            : base(context)
        {
        }
    }
}
