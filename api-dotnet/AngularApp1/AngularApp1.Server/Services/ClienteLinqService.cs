using AngularApp1.Server.Models;
using AngularApp1.Server.Data;
using Microsoft.EntityFrameworkCore;

namespace AngularApp1.Server.Services
{
    public class ClienteLinqService
    {
        private readonly AppDbContext _context;

        public ClienteLinqService(AppDbContext context)
        {
            _context = context;
        }

        public async Task<List<Cliente>> ObtenerClientesPaginados(int pagina, int tamaño)
        {
            return await _context.Clientes
                .OrderBy(c => c.Nombre) 
                .Skip((pagina - 1) * tamaño)  
                .Take(tamaño)  
                .ToListAsync(); 
        }
    }
}
