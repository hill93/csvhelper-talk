using CsvHelper.Configuration.Attributes;
using CsvHelper.Configuration;

namespace CvsHelperTalk.Csv.Entities
{
    [Comment('~')]
    [AllowComments]
    [TrimOptions(TrimOptions.Trim)]
    //[IgnoreBlankLines(false)]
    [CultureInfo("en-GB")]
    public class OtherItem
    {
        public string AStringField { get; set; }
        public DateTime ADateField { get; set; }
        public int? AnIntField { get; set; }
        public Test Test {  get; set; }
    }
}
