using ForAuction.API.Entities;
using Microsoft.EntityFrameworkCore;

namespace ForAuction.API.Repositories;

public class ForAuctionDbContext : DbContext
{
    public ForAuctionDbContext(DbContextOptions option) : base(option) { }
    public DbSet<Auction> Auctions { get; set; }
    public DbSet<User> Users { get; set; }
    public DbSet<Offer> Offers { get; set; }

}
