using Proyecto25AM.Context;
using Proyecto25AM.Services.Iservices;

namespace Proyecto25AM.Services.Services
{
    public class PuestoServices : IPuestoServices
    {
        private readonly ApplicationDBContext _context;
        public PuestoServices(ApplicationDBContext context)
        {
            _context = context;
        }
    }
}
