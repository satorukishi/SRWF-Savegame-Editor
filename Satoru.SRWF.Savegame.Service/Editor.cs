using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace Satoru.SRWF.Savegame.Service
{
    public class Editor
    {
        private readonly SaveProvider _provider;

        public Editor(string filename)
        {
            _provider = new SaveProvider(filename);
        }

        public string GetHexaVerifier()
        {
            return _provider.GetHexaVerifier();
        }

        public string Save(Save save)
        {
            return _provider.Update(save);
        }
    }
}
