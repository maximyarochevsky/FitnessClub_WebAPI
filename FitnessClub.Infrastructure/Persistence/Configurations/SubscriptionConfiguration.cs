using FitnessClub.Domain.Entities.SubscriptionEntity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace FitnessClub.Infrastructure.Persistence.Configurations;

public class SubscriptionConfiguration : IEntityTypeConfiguration<Subscription>
{
    public void Configure(EntityTypeBuilder<Subscription> builder)
    {
        builder.HasKey(subscription => subscription.Id);
        builder.Property(subscription => subscription.Name);
        builder.Property(subscription => subscription.Price);
        builder.Property(subscription => subscription.ValidityPeriod);
        builder.Property(subscription => subscription.Description);
        builder.HasMany(subscription => subscription.Clients);
    }
}

