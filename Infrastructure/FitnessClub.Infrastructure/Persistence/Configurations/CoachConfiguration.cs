
using FitnessClub.Domain.Entities.CoachEntity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace FitnessClub.Infrastructure.Persistence.Configurations;

public class CoachConfiguration : IEntityTypeConfiguration<Coach>
{
    public void Configure(EntityTypeBuilder<Coach> builder)
    {
        builder.HasKey(coach => coach.Id);
        builder.Property(coach => coach.Name);
        builder.Property(coach => coach.Surname);
        builder.Property(coach => coach.Patronymic);
        builder.Property(coach => coach.Age);
        builder.Property(coach => coach.Description);
        builder.Property(coach => coach.Experience);
        builder.Property(coach => coach.Price);
        builder.HasMany(coach => coach.Clients);
    }
}

