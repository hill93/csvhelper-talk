using CsvHelper;
using CvsHelperTalk.Csv.Entities;
using System.Globalization;

namespace CvsHelperTalk.Csv.Readers
{
    public class MappedItemReader
    {
        public List<MappedItem> Read()
        {
            using (var streamReader = new StreamReader("C:\\CsvReaderTalk\\mappeditem.csv"))
            using (var csvReader = new CsvReader(streamReader, CultureInfo.InvariantCulture))
            {
                csvReader.Context.RegisterClassMap(new MappedItemMap(csvReader.HeaderRecord.ToList()));

                return csvReader.GetRecords<MappedItem>().ToList();
            }
        }
    }
}
