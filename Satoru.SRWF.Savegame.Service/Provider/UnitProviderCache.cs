using System.Collections.Generic;
using System.Linq;

namespace Satoru.SRWF.Savegame.Service
{
    public class UnitProviderCache : IUnitProviderCache
    {
        private const string UNITS = "units";
        private static readonly Dictionary<string, IEnumerable<Unit>> _cache = new Dictionary<string, IEnumerable<Unit>>();

        public IEnumerable<Unit> GetUnits()
        {
            if (!_cache.ContainsKey(UNITS))
            {
                var provider = new UnitProvider();
                var units = provider.GetUnits();
                units.Insert(0, new Unit() { Id = -1, Name = "None" });
                _cache.Add(UNITS, units);
            }

            return _cache[UNITS];
        }

        public Unit GetUnitById(int unitId)
        {
            return GetUnits().FirstOrDefault(x => x.Id == unitId);
        }
    }
}
