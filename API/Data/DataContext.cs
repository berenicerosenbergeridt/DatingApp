//data context qui permet de créer une instance pour les utilisateurs

using System.Data.Common;
using API.Entities;
using Microsoft.EntityFrameworkCore;

namespace API.Data;

public class DataContext : DbContext //créer l'instance
{
    public DataContext(DbContextOptions options) : base(options) //options appelées
    {
    }

    public DbSet<AppUser> Users {get;set;} //"users" = nom de la table dans la base de données
}
