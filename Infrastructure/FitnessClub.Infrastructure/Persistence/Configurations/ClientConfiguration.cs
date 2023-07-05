using FitnessClub.Domain.Entities.ClientEntity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace FitnessClub.Infrastructure.Persistence.Configurations;

public class ClientConfiguration : IEntityTypeConfiguration<Client>
{
    public void Configure(EntityTypeBuilder<Client> builder)
    {
        builder.HasKey(client => client.Id);
        builder.Property(client => client.Name);
        builder.Property(client => client.Surname);
        builder.Property(client => client.Patronymic);
        builder.Property(client => client.Age);
        builder.HasOne(client => client.Coach);
        builder.HasOne(client => client.Subscription);
    }
}

