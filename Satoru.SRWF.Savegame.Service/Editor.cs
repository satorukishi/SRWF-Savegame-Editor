using System.Collections.Generic;

namespace Satoru.SRWF.Savegame.Service
{
    public class Editor
    {
        private readonly ISaveProvider _provider;
        private readonly IUnitProviderCache _unitCache;

        public Editor(string filename) : this(new SaveProvider(filename), new UnitProviderCache())
        {
        }

        public Editor(ISaveProvider provider, IUnitProviderCache unitCache)
        {
            _provider = provider;
            _unitCache = unitCache;
        }

        public string GetHexaVerifier()
        {
            return _provider.GetHexaVerifier();
        }

        public string Save(Save save)
        {
            return _provider.Update(save);
        }

        public IEnumerable<Unit> GetUnits()
        {
            return _unitCache.GetUnits();
        }

        public IEnumerable<Unit> GetUnlockedUnits()
        {
            return _provider.GetUnlockedUnits();
        }

        
    }
}
