using CsvHelper;
using CsvHelper.Configuration;
using System.Globalization;

namespace CvsHelperTalk.Csv.Writers
{
    public class WriterBase<T>
    {
        public void WriteRange(List<T> records, string path)
        {
            using (var writer = new StreamWriter(path))
            using (var csvWriter = new CsvWriter(writer, CultureInfo.InvariantCulture))
            {
                csvWriter.WriteRecords(records);
            }
        }

        public void AppendRange(List<T> records, string path)
        {
            var config = new CsvConfiguration(CultureInfo.InvariantCulture)
            {
                HasHeaderRecord = false,
            };

            using (var stream = File.Open(path, FileMode.Append))
            using (var writer = new StreamWriter(stream))
            using (var csvWriter = new CsvWriter(writer, config))
            {
                csvWriter.WriteRecords(records);
            }
        }
    }
}
