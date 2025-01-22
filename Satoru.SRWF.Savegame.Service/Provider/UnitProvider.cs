using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace Satoru.SRWF.Savegame.Service
{
    internal class UnitProvider : IUnitProvider
    {
        private const int HEXA = 0;
        private const int ID = 1;
        private const int NAME = 2;
        private const int HP = 3;
        private const int MOBILITY = 4;
        private const int ARMOR = 5;
        private const int LIMIT = 6;
        private const int NOTE = 7;
        private const string FILENAME = "units.csv";

        public UnitProvider() { }

        public IList<Unit> GetUnits()
        {
            List<Unit> units = new List<Unit>();

            using (var reader = new StreamReader(FILENAME))
            {
                // Ignore Header
                reader.ReadLine();

                while (!reader.EndOfStream)
                {
                    var line = reader.ReadLine();
                    var values = line.Split(';');

                    Unit unit = new Unit()
                    {
                        Hexa = values[HEXA],
                        Id = int.Parse(values[ID]),
                        Name = values[NAME],
                        HP = values[HP],
                        Mobility = values[MOBILITY],
                        Armor = values[ARMOR],
                        Limit = values[LIMIT],
                        Note = values[NOTE]
                    };
                    units.Add(unit);
                }
            }

            return units.OrderBy(x => x.Name).ToList();
        }
    }
}
