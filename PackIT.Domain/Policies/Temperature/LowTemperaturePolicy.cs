using PackIT.Domain.ValueObjects;

namespace PackIT.Domain.Policies.Temperature
{
    public class LowTemperaturePolicy
    {
        public bool IsApplicable(PolicyData data)
            => data.Temperature < 10D;

        public IEnumerable<PackingItem> GenerateItems(PolicyData data)
            => new List<PackingItem>
            {
                new("Winter hat", 1),
                new("Hoodie", 1),
                new("Warm jacket", 1)
            };
    }
}
