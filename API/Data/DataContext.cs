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

    public DbSet<AppUser> Users { get; set; } //"users" = nom de la table dans la base de données
    public DbSet<UserLike> Likes { get; set; }
    protected override void OnModelCreating(ModelBuilder builder)
    {
        base.OnModelCreating(builder);

        builder.Entity<UserLike>()
            .HasKey(k=> new {k.SourceUserId, k.TargentUserId});

        builder.Entity<UserLike>()
            .HasOne(s => s.SourceUser)
            .WithMany(l => l.LikedUsers)
            .HasForeignKey(s => s.SourceUserId)
            .OnDelete(DeleteBehavior.Cascade);

        builder.Entity<UserLike>()
            .HasOne(s => s.TargetUser)
            .WithMany(l => l.LikedByUsers)
            .HasForeignKey(s => s.TargentUserId)
            .OnDelete(DeleteBehavior.Cascade);
    }
}
