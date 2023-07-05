using FitnessClub.Domain.Entities.Base;
using FitnessClub.Domain.Entities.ClientEntity;

namespace FitnessClub.Domain.Entities.CoachEntity;

public class Coach : Entity
{
    public string Name { get; set; }
    public string Surname { get; set; }
    public string? Patronymic { get; set; }
    public int Experience { get; set; }
    public decimal Price { get; set; }
    public int Age { get; set; }
    public string Description { get; set; }
    public ICollection<Client>? Clients { get; set; }
}

