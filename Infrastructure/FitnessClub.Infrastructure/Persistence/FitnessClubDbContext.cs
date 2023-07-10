using FitnessClub.Domain.Entities.ClientEntity;
using FitnessClub.Domain.Entities.CoachEntity;
using FitnessClub.Domain.Entities.SubscriptionEntity;
using FitnessClub.Domain.Entities.TrainingProgramEntity;
using FitnessClub.Infrastructure.Persistence.Configurations;
using Microsoft.EntityFrameworkCore;

namespace FitnessClub.Infrastructure.Persistence;

public class FitnessClubDbContext: DbContext
{
    public DbSet<Client> Clients { get; set; }
    public DbSet<Coach> Coachs { get; set; }
    public DbSet<Subscription> Supscriptions { get; set; }
    public DbSet<TrainingProgram> TrainingPrograms{ get; set; }

    public FitnessClubDbContext(DbContextOptions<FitnessClubDbContext> options)
        : base(options) { }

    protected override void OnModelCreating(ModelBuilder builder)
    {
        builder.ApplyConfiguration(new ClientConfiguration());
        builder.ApplyConfiguration(new CoachConfiguration());
        builder.ApplyConfiguration(new SubscriptionConfiguration());
        builder.ApplyConfiguration(new TrainingProgramConfiguration());
        base.OnModelCreating(builder);
    }
}

