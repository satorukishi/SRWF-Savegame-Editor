using System;
using System.IO;
using System.Linq;
using System.Management.Instrumentation;

namespace Satoru.SRWF.Savegame.Service
{
    internal class SaveProvider : ISaveProvider
    {
        private const int HEXA_VERIFIER_OFFSET = 17;
        private const int HEXA_VERIFIER_LENGTH = 3;
        private const int FUNDS_OFFSET = 26;
        private const int FUNDS_LENGTH = 3;

        private string _filename;
        private byte[] _content;

        public SaveProvider(string filename)
        {
            _filename = filename;

            if (File.Exists(filename))
            {
                _content = File.ReadAllBytes(filename);
            }
            else
            {
                throw new FileNotFoundException($"The file {filename} does not exist.");
            }
        }

        public string GetHexaVerifier()
        {
            int hexaVerifier = GetIntHexaVerifier();
            string hexa = ToHexa(6, hexaVerifier);
            hexa = hexa.Substring(0, 2) + ' ' + hexa.Substring(2, 2) + ' ' + hexa.Substring(4, 2);

            return hexa;
        }

        public string Update(Save save)
        {
            UpdateContent(save.Funds, FUNDS_OFFSET, FUNDS_LENGTH);

            Commit();

            return GetHexaVerifier();
        }

        private void Commit()
        {
            // Must update Hexa Verifier before saving the file
            UpdateContent(GetIntHexaVerifier(), HEXA_VERIFIER_OFFSET, HEXA_VERIFIER_LENGTH);

            // Save the file
            File.WriteAllBytes(_filename, _content);
        }

        private void UpdateContent(int newValue, int offset, int length)
        {
            byte[] byteChanged = BitConverter.GetBytes(newValue).Reverse().Skip(1).ToArray();
            Array.Copy(byteChanged, 0, _content, offset, length);
        }

        private int GetIntHexaVerifier()
        {
            int resultado = 0;
            try
            {
                int startIndex = HEXA_VERIFIER_OFFSET + HEXA_VERIFIER_LENGTH;
                for (int i = startIndex; i < _content.Length; i++)
                {
                    resultado += _content[i];
                }

                // SRWF has 2 savegame types:
                // 00 is for historycal things like how many robots/pilots you have already seen in the game
                // 01~99 are used to store which stage you are, money, robots/pilots you have been leveled up, etc.
                if (_filename.Substring(_filename.Length - 6, 2) != "00")
                {
                    // 01~99 needs to subtract (don't remember why although
                    resultado = resultado - 255 - 100;
                }
            }
            catch (IOException)
            {

            }

            return resultado;
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
        /// <param="length">byte quantity will be read</param>
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
