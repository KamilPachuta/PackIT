﻿using PackIT.Domain.ValueObjects;

namespace PackIT.Domain.Policies.BasePolicy
{
    public class BasePolicy
    {
        private const uint MaximumQuantityOfClothes = 7;

        public bool IsApplicable(PolicyData _)
            => true;

        public IEnumerable<PackingItem> GenerateItems(PolicyData data)
            => new List<PackingItem>
            {
                new("Pants", Math.Min(data.Days, MaximumQuantityOfClothes)),
                new("Socks", Math.Min(data.Days, MaximumQuantityOfClothes)),
                new("T-Shirt", Math.Min(data.Days, MaximumQuantityOfClothes)),
                new("Shampoo", 1),
                new("Toothpaste", 1),
                new("Toothbrush", 1),
                new("Towel", 1),
                new("Phone charger", 1),
                new("Bag pack", 1),
                new("Passport", 1)
            };
    }
}
