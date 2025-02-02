﻿using System.Collections.Generic;

namespace Satoru.SRWF.Savegame.Service
{
    public interface ISaveProvider
    {
        string GetHexaVerifier();
        string Update(Save save);
        IEnumerable<Unit> GetUnlockedUnits();
    }
}
