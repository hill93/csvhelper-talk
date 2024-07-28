using CsvHelper.Configuration;
using CsvHelper;
using System.Globalization;
using CvsHelperTalk.Csv.Entities;
using CvsHelperTalk.Csv.Maps;

namespace CvsHelperTalk.Csv.Writers
{
    public class MappedItemWriter
    {
        public void WriteRange(List<MappedItem> records, CsvConfiguration? configArg = null)
        {
            var config = configArg ?? new(CultureInfo.InvariantCulture);

            using (var writer = new StreamWriter("C:\\CsvReaderTalk\\mapped-output.csv"))
            using (var csvWriter = new CsvWriter(writer, config))
            {
                csvWriter.Context.RegisterClassMap(new MappedItemWriterMap(records));

                csvWriter.WriteRecords(records);
            }
        }

        public void AppendRange(List<MappedItem> records, CsvConfiguration? configArg = null)
        {
            var config = configArg ?? new(CultureInfo.InvariantCulture);

            config.HasHeaderRecord = false;

            using (var stream = File.Open("C:\\CsvReaderTalk\\mapped-output.csv", FileMode.Append))
            using (var writer = new StreamWriter(stream))
            using (var csvWriter = new CsvWriter(writer, config))
            {
                csvWriter.Context.RegisterClassMap(new MappedItemWriterMap(records));

                csvWriter.WriteRecords(records);
            }
        }
    }
}
