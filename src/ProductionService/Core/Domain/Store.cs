using N8T.Domain;

namespace ProductionService.Core.Domain
{
    public class Store : EntityBase
    {
        public int Id { get; set; }

        public string Name { get; set; } = default!;
    }
}
