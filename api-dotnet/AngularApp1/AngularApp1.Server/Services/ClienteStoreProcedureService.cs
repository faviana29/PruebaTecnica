using AngularApp1.Server.Models;
using AngularApp1.Server.Data;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;

namespace AngularApp1.Server.Services
{
    public class ClienteStoreProcedureService
    {
        private readonly AppDbContext _context;

        public ClienteStoreProcedureService(AppDbContext context)
        {
            _context = context;
        }

        public async Task<List<Cliente>> ObtenerClientesPaginados(int pagina, int tamaño)
        {
            var parametros = new[]
            {
                new SqlParameter("@Pagina", pagina),
                new SqlParameter("@Tamano", tamaño)
            };

            return await _context.Clientes
                .FromSqlRaw("EXEC ObtenerClientesPaginados @Pagina, @Tamano", parametros)
                .ToListAsync();
        }
    }
}
