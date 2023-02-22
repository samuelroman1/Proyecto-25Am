using Proyecto25AM.Context;
using Proyecto25AM.Services.Iservices;

namespace Proyecto25AM.Services.Services
{
    public class RolServices : IRolServices
    {
        private readonly ApplicationDBContext _context;
        public RolServices(ApplicationDBContext context) 
        {
            _context = context;
        }
    }
}
