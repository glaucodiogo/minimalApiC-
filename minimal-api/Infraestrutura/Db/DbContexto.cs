using MinimalApi.Dominio.Entidades;
using Microsoft.EntityFrameworkCore;

namespace MinimalApi.infraestrutura.Db;

public class DbContexto : DbContext
{
    public DbContexto(DbContextOptions<DbContexto> options) : base(options)
    {
    }
    public DbSet<Administrador> Administradores { get; set; } = default!;

}