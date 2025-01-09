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
        private readonly string _filename;
        private readonly SaveProvider _provider;

        public Editor(string filename)
        {
            _filename = filename;
            _provider = new SaveProvider(filename);
        }

        public string GetHexaVerifier()
        {
            return _provider.GetHexaVerifier();
        }

        public void Save(Save save)
        {
            _provider.Update(save);
        }
    }
}
