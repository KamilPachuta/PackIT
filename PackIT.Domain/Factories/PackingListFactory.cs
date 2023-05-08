using PackIT.Domain.Consts;
using PackIT.Domain.Entities;
using PackIT.Domain.Policies;
using PackIT.Domain.ValueObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PackIT.Domain.Factories
{
    internal class PackingListFactory
    {
        private readonly IEnumerable<IPackingItemsPolicy> _policies;

        public PackingListFactory(IEnumerable<IPackingItemsPolicy> policies)
            => _policies = policies;


        PackingList Create(PackingListId id, PackingListName name, Localization localization)
            => new(id,name,localization);

        PackingList CreateWithDefaultItems(PackingListId id, PackingListName name, TravelDays days, Gender gender, Localization localization, Temperature temperature)
        {
            var data = new PolicyData(days, gender, temperature, localization);
            var applicablePolicies = _policies.Where(p => p.IsApplicable(data));

            var items = applicablePolicies.SelectMany(p => p.GenerateItems(data));
            var packingList = Create(id, name, localization);
            packingList.AddItems(items);

            return packingList;
        }
    }
}
