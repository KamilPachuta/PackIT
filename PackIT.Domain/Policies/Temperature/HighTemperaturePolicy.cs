using PackIT.Domain.ValueObjects;

namespace PackIT.Domain.Policies.Temperature
{
    public class HighTemperaturePolicy
    {
        public bool IsApplicable(PolicyData data)
            => data.Temperature > 25D;

        public IEnumerable<PackingItem> GenerateItems(PolicyData data)
            => new List<PackingItem>
            {
                new("Hat", 1),
                new("Sunglasses", 1),
                new("Cream UV", 1)
            };
    }
}
