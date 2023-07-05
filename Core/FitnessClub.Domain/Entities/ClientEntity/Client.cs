using FitnessClub.Domain.Entities.Base;
using FitnessClub.Domain.Entities.CoachEntity;
using FitnessClub.Domain.Entities.SubscriptionEntity;

namespace FitnessClub.Domain.Entities.ClientEntity;

public class Client: Entity
{
    public string Name { get; set; }
    public string Surname { get; set; }
    public string? Patronymic { get; set; }
    public int Age { get; set; }
    public Coach? Coach { get; set; }
    public Subscription? Subscription { get; set; }
}

