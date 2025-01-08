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

        public Editor(string filename)
        {
            _filename = filename;
        }

        public string GetHexaVerifier()
        {
            string hexa = string.Empty;
            try
            {
                int resultado = 0;
                
                using (FileStream fs = new FileStream(_filename, FileMode.Open, FileAccess.Read))
                {
                    int umByte;
                    for (int i = 0; i < fs.Length; i++)
                    {
                        // Need to ReadByte to skip unnecessary byte
                        umByte = fs.ReadByte();
                        if (i >= HEXA_VERIFIER_OFFSET)
                        {
                            resultado += umByte;
                        }
                    }
                }

                // SRWF has 2 savegame types:
                // 00 is for historycal things like how many robots/pilots you have already seen in the game
                // 01~99 are used to store which stage you are, money, robots/pilots you have been leveled up, etc.
                if (_filename.Substring(_filename.Length - 6, 2) != "00")
                {
                    // 01~99 needs to subtract (don't remember why although
                    resultado = resultado - 255 - 100;
                }

                // Convert integer as a hex in a string variable
                hexa = resultado.ToString("X").PadLeft(6, '0');
                hexa = hexa.Substring(0, 2) + ' ' + hexa.Substring(2, 2) + ' ' + hexa.Substring(4, 2);
            }
            catch (IOException)
            {

            }

            return hexa;
        }

        public void Save()
        {
            // Convert Int32 to byte[]
            byte[] fundsArray = BitConverter.GetBytes(Funds);

            using (FileStream fs = new FileStream(_filename, FileMode.Open, FileAccess.ReadWrite))
            {
                for (int i = 0; i < fs.Length; i++)
                {
                    // Need to ReadByte to skip unnecessary byte
                    fs.ReadByte();
                    
                    if (i >= FUNDS_OFFSET && (i < FUNDS_OFFSET + FUNDS_LENGTH))
                    {
                        
                    }
                }
            }

        }
    }
}
