using Proyecto25AM.Context;
using Proyecto25AM.Services.Iservices;

namespace Proyecto25AM.Services.Services
{
    public class ClienteServices : IClienteServices
    {
        private readonly ApplicationDBContext _context;
        public ClienteServices(ApplicationDBContext context)
        {
            _context = context;
        }
    }
}
