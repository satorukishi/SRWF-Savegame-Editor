using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace Satoru.SRWF.Savegame.Service
{
    internal class SaveProvider : ISaveProvider
    {
        private readonly IUnitProviderCache _unitCache;
        private const int HEXA_VERIFIER_OFFSET = 0x11;
        private const int HEXA_VERIFIER_LENGTH = 3;
        private const int FUNDS_OFFSET = 0x1A;
        private const int FUNDS_LENGTH = 3;


        private string _filename;
        private byte[] _content;

        public SaveProvider(string filename, IUnitProviderCache unitCache)
        {
            _filename = filename;
            _unitCache = unitCache;

            if (File.Exists(filename))
            {
                _content = File.ReadAllBytes(filename);
            }
            else
            {
                throw new FileNotFoundException($"The file {filename} does not exist.");
            }

        }

        public SaveProvider(string filename) : this(filename,new UnitProviderCache())
        {
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
            //UpdateContent(save.Unit.Id, , );

            Commit();

            return GetHexaVerifier();
        }

        public IEnumerable<Unit> GetUnlockedUnits()
        {
            List<Unit> units = new List<Unit>();
            int offset = UnitUnlocked.START_INDEX;
            int unitId;
            bool retry = true;

            do
            {
                unitId = GetIntValue(offset, 2);
                offset += UnitUnlocked.LENGTH;
                if (unitId > 0)
                {
                    Unit unit = _unitCache.GetUnitById(unitId);
                    unit.Offset = offset;
                    units.Add(unit);
                }
                else
                {
                    // If unitId is 0, we check if next 2 bytes are 0 too
                    unitId = GetIntValue(offset, 4);
                    retry = unitId != 0;
                }


            } while (unitId > 0 || retry);

            return units;
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
                    // 01~99 needs to subtract (don't remember why)
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


        private class UnitUnlocked
        {
            internal const int START_INDEX = 0x110;
            internal const int LENGTH = 30;
            internal const int HP_EN_INDEX = 5;
            internal const int MOBILITY_INDEX = 7;
            internal const int ARMOR_LIMIT_INDEX = 6;

            // HP, Mobility, Armor
            internal static readonly Dictionary<int, byte> UPGRADE_TYPE1 = new Dictionary<int, byte>()
            {
                {1, 0x80},
                {2, 0x80},
                {3, 0x80},
                {4, 0x80},
                {5, 0x80},
            };

            // EN, Limit
            internal static readonly Dictionary<int, byte> UPGRADE_TYPE2 = new Dictionary<int, byte>()
            {
                {1, 0x08},
                {2, 0x08},
                {3, 0x08},
                {4, 0x08},
                {5, 0x08},
            };
        }
    }
}
