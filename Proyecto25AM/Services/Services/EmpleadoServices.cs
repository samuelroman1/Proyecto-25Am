using Proyecto25AM.Context;
using Proyecto25AM.Services.Iservices;

namespace Proyecto25AM.Services.Services
{
    public class EmpleadoServices  : IEmpleadoServices
    {
        private readonly ApplicationDBContext _context;
        public EmpleadoServices(ApplicationDBContext context) 
        {
            _context = context;
        }
    }
}
