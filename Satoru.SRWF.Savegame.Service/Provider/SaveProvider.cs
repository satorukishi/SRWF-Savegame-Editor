using System;
using System.IO;

namespace Satoru.SRWF.Savegame.Service
{
    internal class SaveProvider : ISaveProvider
    {
        private const int HEXA_VERIFIER_OFFSET = 20;
        private const int HEXA_VERIFIER_LENGTH = 3;
        private const int FUNDS_OFFSET = 20;
        private const int FUNDS_LENGTH = 3;

        private byte[] content;

        public SaveProvider(string filename)
        {
            content = File.ReadAllBytes(filename);
        }

        private long GetLongValue(int offset, int length)
        {

            switch (length)
            {
                case 1:
                    return content[offset];
                case 2:
                    return BitConverter.ToInt16(content, offset);
                case 3:
                    return BitConverter.ToInt32(content, offset);
                case 4:
                    return BitConverter.ToInt64(content, offset);
                default: return 0;
            }

        }

        /// <summary>
        /// Convert integer as a hex in a string variable
        /// </summary>
        /// <param name="offset">Where in the file the byte begins</param>
        /// <param name="length">byte quantity will be read</param>
        /// <returns></returns>
        private string GetHexaValue(int offset, int length)
        {
            string hexa = GetLongValue(offset, length).ToString("X").PadLeft(length * 2, '0');
            return hexa;
        }
    }
}
