using Proyecto25AM.Context;
using Proyecto25AM.Services.Iservices;

namespace Proyecto25AM.Services.Services
{
    public class DepartamentoService : IDepartamentoServices
    {
        private readonly ApplicationDBContext _context;
        public DepartamentoService(ApplicationDBContext context)
        {
            _context = context;
        }
    }
}
