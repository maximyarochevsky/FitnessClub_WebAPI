using FitnessClub.Domain.Entities.Base;
using FitnessClub.Domain.Entities.ClientEntity;

namespace FitnessClub.Domain.Entities.SubscriptionEntity;

public class Subscription : Entity

{
    public string Name { get; set; }
    public decimal Price { get; set; }
    public int ValidityPeriod { get; set; }
    public string Description { get; set; }
    public ICollection<Client>? Clients { get; set; }
}

