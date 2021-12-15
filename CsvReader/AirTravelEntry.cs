using CsvHelper.Configuration.Attributes;

namespace CsvReaderData
{
    class AirTravelEntry
    {
        [Name("Month")]
        public string Month { get; set; }

        [Name("1958")]
        public int Y1958 { get; set; }

        [Name("1959")]
        public int Y1959 { get; set; }

        [Name("1960")]
        public int Y1960 { get; set; }
    }
}
