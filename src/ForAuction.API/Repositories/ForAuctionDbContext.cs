using ForAuction.API.Entities;
using Microsoft.EntityFrameworkCore;

namespace ForAuction.API.Repositories;

public class ForAuctionDbContext : DbContext
{
    public DbSet<Auction> Auctions { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlite(@"Data Source = C:\Users\User\Desktop\Dev\leilaoDbNLW.db");
    }
}
