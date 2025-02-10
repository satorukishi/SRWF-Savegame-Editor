namespace Satoru.SRWF.Savegame.Service
{
    public class Unit
    {
        public int Id { get; set; }
        public string Hexa { get; set; }
        public string Name { get; set; }
        public string HP { get; set; }
        public string Mobility { get; set; }
        public string Armor { get; set; }
        public string Limit { get; set; }
        public string Note { get; set; }

        public int Offset { get; set; }

        public UnitStatsUpgrade StatsUpgrade { get; set; }


        public Unit()
        {
            StatsUpgrade = new UnitStatsUpgrade();
        }
    }

    public class  UnitStatsUpgrade
    {
        public byte HP { get; set; }
        public byte EN { get; set; }
        public byte Mobility { get; set; }
        public byte Armor { get; set; }
        public byte Limit { get; set; }

    }
}
