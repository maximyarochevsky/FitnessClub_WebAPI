namespace FitnessClub.Infrastructure.Persistence;

public class DbInitializer
{
    public static void Initialize(FitnessClubDbContext context)
    {
        context.Database.EnsureCreated();
    }
}

