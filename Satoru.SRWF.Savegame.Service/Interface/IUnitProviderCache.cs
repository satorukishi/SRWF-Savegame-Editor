using System.Collections.Generic;

namespace Satoru.SRWF.Savegame.Service
{
    public interface IUnitProviderCache
    {
        IEnumerable<Unit> GetUnits();
    }
}