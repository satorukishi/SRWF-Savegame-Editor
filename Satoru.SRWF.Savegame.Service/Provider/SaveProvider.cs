using System;
using System.IO;

namespace Satoru.SRWF.Savegame.Service
{
    internal class SaveProvider : ISaveProvider
    {
        private const int HEXA_VERIFIER_OFFSET = 17;
        private const int HEXA_VERIFIER_LENGTH = 3;
        private const int FUNDS_OFFSET = 20;
        private const int FUNDS_LENGTH = 3;

        private string _filename;
        private byte[] _content;

        public SaveProvider(string filename)
        {
            _filename = filename;
            _content = File.ReadAllBytes(filename);
        }

        public string GetHexaVerifier()
        {
            string hexa = string.Empty;
            try
            {
                int resultado = 0;
                int startIndex = HEXA_VERIFIER_OFFSET + HEXA_VERIFIER_LENGTH;
                for (int i = startIndex; i < _content.Length; i++)
                {
                    // Need to ReadByte to skip unnecessary byte
                    resultado += _content[i];
                }
                //using (FileStream fs = new FileStream(_filename, FileMode.Open, FileAccess.Read))
                //{
                //    int umByte;
                //    for (int i = 0; i < fs.Length; i++)
                //    {
                //        // Need to ReadByte to skip unnecessary byte
                //        umByte = fs.ReadByte();
                //        if (i >= HEXA_VERIFIER_OFFSET)
                //        {
                //            resultado += umByte;
                //        }
                //    }
                //}

                // SRWF has 2 savegame types:
                // 00 is for historycal things like how many robots/pilots you have already seen in the game
                // 01~99 are used to store which stage you are, money, robots/pilots you have been leveled up, etc.
                if (_filename.Substring(_filename.Length - 6, 2) != "00")
                {
                    // 01~99 needs to subtract (don't remember why although
                    resultado = resultado - 255 - 100;
                }

                // Convert integer as a hex in a string variable
                hexa = ToHexa(6, resultado);
                hexa = hexa.Substring(0, 2) + ' ' + hexa.Substring(2, 2) + ' ' + hexa.Substring(4, 2);
            }
            catch (IOException)
            {

            }

            return hexa;
        }

        public string Update(Save save)
        {
            byte[] funds = BitConverter.GetBytes(save.Funds);
            Array.Copy(funds, 0, _content, FUNDS_OFFSET, FUNDS_LENGTH);
            File.WriteAllBytes(_filename, _content);

            return GetHexaVerifier();
        }

        private int GetIntValue(int offset, int length)
        {
            if (length == 1) // int8
            {
                return _content[offset];
            }
            else if (length == 2) // int16
            {
                return _content[offset] << 8
                     | _content[offset + 1];
            }
            else if (length == 3) // int24
            {
                return _content[offset] << 16
                     | _content[offset + 1] << 8
                     | _content[offset + 2];
            }
            else if (length == 4) // int32
            {
                return _content[offset] << 24
                     | _content[offset + 1] << 16
                     | _content[offset + 2] << 8
                     | _content[offset + 3];
            }
            else
            {
                return 0;
            }

        }

        /// <summary>
        /// Find Convert integer as a hex in a string variable
        /// </summary>
        /// <param name="offset">Where in the file the byte begins</param>
        /// <param name="length">byte quantity will be read</param>
        /// <returns></returns>
        private string GetHexaValue(int offset, int length)
        {
            return ToHexa(length * 2, GetIntValue(offset, length));
        }

        /// <summary>
        /// Convert integer as a hex in a string variable
        /// </summary>
        /// <param name="offset">Where in the file the byte begins</param>
        /// <param name="intValue"></param>
        /// <returns></returns>
        private string ToHexa(int padLeft, int intValue)
        {
            string hexa = intValue.ToString("X").PadLeft(padLeft, '0');
            return hexa;
        }
    }
}
