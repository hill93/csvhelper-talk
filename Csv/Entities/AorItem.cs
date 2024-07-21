using CsvHelper.Configuration.Attributes;

namespace CvsHelperTalk.Csv.Entities
{
    [Delimiter("|")]
    [HasHeaderRecord(false)]
    public class AorItem
    {
        [Index(0)]
        public long Id { get; set; }

        [Index(1)]
        public int ActionType { get; set; }

        [Index(2)]
        public int CordKey { get; set; }

        [Index(3)]
        public int? FourthField { get; set; }

        [Index(4)]
        public int? FifthField { get; set; }

        [Index(5)]
        public string PhoneNumber { get; set; }

        [Index(6)]
        public string AnotherId { get; set; }

        [Index(7)]
        public DateTime ADate { get; set; }
    }
}
