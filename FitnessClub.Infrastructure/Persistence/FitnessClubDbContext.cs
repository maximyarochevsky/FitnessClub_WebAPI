using FitnessClub.Domain.Entities.ClientEntity;
using FitnessClub.Domain.Entities.CoachEntity;
using FitnessClub.Domain.Entities.SubscriptionEntity;
using Microsoft.EntityFrameworkCore;

namespace FitnessClub.Infrastructure.Persistence;

public class FitnessClubDbContext: DbContext
{
    public DbSet<Client> Clients { get; set; }
    public DbSet<Coach> Coachs { get; set; }
    public DbSet<Subscription> Supscriptions { get; set; }

    public FitnessClubDbContext(DbContextOptions<FitnessClubDbContext> options)
        : base(options) { }

    protected override void OnModelCreating(ModelBuilder builder)
    {
        base.OnModelCreating(builder);
    }
}

