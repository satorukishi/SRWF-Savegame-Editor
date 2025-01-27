using System.Collections.Generic;

namespace Satoru.SRWF.Savegame.Service
{
    public interface IUnitProviderCache
    {
        Unit GetUnitById(int unitId);
        IEnumerable<Unit> GetUnits();
    }
}