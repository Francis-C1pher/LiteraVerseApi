using LiteraVerseApi.Models;
using Microsoft.EntityFrameworkCore;

namespace LiteraVerseApi.DAL;

public class Contexto(DbContextOptions<Contexto> options) : DbContext(options)
{
    public DbSet<Usuarios> Usuarios { get; set; }
}