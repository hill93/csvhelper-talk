using CsvHelper.Configuration;
using CvsHelperTalk.Csv.Entities;
using System.Globalization;

namespace CvsHelperTalk.Csv.Readers
{
    public class OtherItemReader : ReaderBase<OtherItem>
    {
        public List<OtherItem> Read()
        {
            var config = new CsvConfiguration(CultureInfo.InvariantCulture)
            {
                MissingFieldFound = fieldArg => 
                    { 
                        Console.WriteLine($"Field missing at row {fieldArg.Context.Reader.Parser.RawRow}, column {fieldArg.Index}"); 
                    },
                PrepareHeaderForMatch = header => header.Header.Replace(" ",""),
                ShouldSkipRecord = record => record.Row[0] == "SKIPTHISLINE"
            };

            return base.Read("C:\\CsvReaderTalk\\other.csv", config);
        }
    }
}
