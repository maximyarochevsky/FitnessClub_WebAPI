using FitnessClub.Domain.Entities.CoachEntity;
using FitnessClub.Domain.Entities.TrainingProgramEntity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace FitnessClub.Infrastructure.Persistence.Configurations;

public class TrainingProgramConfiguration:IEntityTypeConfiguration<TrainingProgram>
{
    public void Configure(EntityTypeBuilder<TrainingProgram> builder)
    {
        builder.HasKey(coach => coach.Id);
        builder.Property(coach => coach.Name);
        builder.Property(coach => coach.Rating);
        builder.Property(coach => coach.Plan);
        builder.Property(coach => coach.Description);
        builder.Property(coach => coach.Price);
    }
}

