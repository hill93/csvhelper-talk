using CsvHelper;
using CvsHelperTalk.Csv.Entities;
using System.Globalization;

namespace CvsHelperTalk.Csv.Readers
{
    using CsvHelper.Configuration;

    public class MappedItemReader
    {
        public List<MappedItem> Read()
        {
            var config = new CsvConfiguration(CultureInfo.InvariantCulture)
            {
                MissingFieldFound = null
            };
            
            using (var streamReader = new StreamReader("C:\\CsvReaderTalk\\mapped.csv"))
            using (var csvReader = new CsvReader(streamReader, config))
            {
                csvReader.Context.RegisterClassMap<MappedItemMap>();

                return csvReader.GetRecords<MappedItem>().ToList();
            }
        }
    }
}
