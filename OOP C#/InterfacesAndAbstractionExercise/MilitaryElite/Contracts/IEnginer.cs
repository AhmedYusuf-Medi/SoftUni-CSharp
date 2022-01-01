using System;
using System.Collections.Generic;
using System.Text;

namespace MilitaryElite
{
    public interface IEnginer : ISpecialisedSoldier
    {
        IReadOnlyCollection<IRepair> Repairs { get; }

        void AddRepair(IRepair repair);
    }
}
