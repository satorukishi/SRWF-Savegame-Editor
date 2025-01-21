using System.Collections.Generic;

namespace Satoru.SRWF.Savegame.Service
{
    public interface IUnitProvider
    {
        IList<Unit> GetUnits();
    }
}
