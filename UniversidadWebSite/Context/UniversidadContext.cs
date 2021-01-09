using Microsoft.EntityFrameworkCore;
using UniversidadWebSite.Models;

namespace UniversidadWebsite.Context
{
    public class UniversidadContexto : DbContext
    {
        public UniversidadContexto(DbContextOptions<UniversidadContexto> opciones) : base(opciones)
        {

        }

        public DbSet<Estudiante> Estudiantes { get; set; }
    }
}