using Proyecto25AM.Context;
using Proyecto25AM.Services.Iservices;

namespace Proyecto25AM.Services.Services
{
    public class UsuarioServices : IUsuarioServices
    {
        private readonly ApplicationDBContext _context;
        public UsuarioServices(ApplicationDBContext context) 
        {
            _context = context;
        }

        //Creacion de funciones CRUD

    }
}
