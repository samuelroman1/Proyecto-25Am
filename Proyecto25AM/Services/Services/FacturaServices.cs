using Proyecto25AM.Context;
using Proyecto25AM.Services.Iservices;

namespace Proyecto25AM.Services.Services
{
    public class FacturaServices : IFacturaServices
    {
        private readonly ApplicationDBContext _context;
        public FacturaServices(ApplicationDBContext context)
        {
            _context = context;
        }
    }
}
