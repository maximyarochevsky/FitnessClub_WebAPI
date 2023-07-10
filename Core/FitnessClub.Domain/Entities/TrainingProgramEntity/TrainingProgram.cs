using FitnessClub.Domain.Entities.Base;

namespace FitnessClub.Domain.Entities.TrainingProgramEntity;
public class TrainingProgram : Entity
{
    public string Name { get; set; }
    public double? Rating { get; set; }
    public string Plan { get; set; }
    public string Description { get; set; }
    public decimal Price { get; set; }
}

