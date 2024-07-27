using CsvHelper.Configuration;
using CvsHelperTalk.Csv.Entities;
using System.Globalization;

namespace CvsHelperTalk.Csv.Writers
{
    public class OtherItemWriter : WriterBase<OtherItem>
    {
        public void AppendRange(List<OtherItem> items)
        {
            var config = new CsvConfiguration(CultureInfo.InvariantCulture)
            {
                MissingFieldFound = field => { Console.WriteLine($"{field} is empty"); },
                PrepareHeaderForMatch = header => header.Header.Replace(" ", "")
            };

            base.AppendRange(items, "C:\\CsvReaderTalk\\other.csv", config);
        }
    }
}
