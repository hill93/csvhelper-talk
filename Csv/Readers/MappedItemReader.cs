using CsvHelper;
using CvsHelperTalk.Csv.Entities;
using System.Globalization;

namespace CvsHelperTalk.Csv.Readers
{
    public class MappedItemReader
    {
        public List<MappedItem> Read()
        {
            using (var streamReader = new StreamReader("C:\\CsvReaderTalk\\mapped.csv"))
            using (var csvReader = new CsvReader(streamReader, CultureInfo.InvariantCulture))
            {
                csvReader.Read();
                csvReader.ReadHeader();
                csvReader.Context.RegisterClassMap<MappedItemMap>();

                return csvReader.GetRecords<MappedItem>().ToList();
            }
        }
    }
}
