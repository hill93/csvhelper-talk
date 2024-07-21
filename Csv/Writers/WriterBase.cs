using CsvHelper;
using CsvHelper.Configuration;
using System.Globalization;

namespace CvsHelperTalk.Csv.Writers
{
    public class WriterBase<T>
    {
        public void WriteRange(List<T> records, string path, CsvConfiguration configArg = null)
        {
            var config = configArg ?? new(CultureInfo.InvariantCulture);
            config.ApplyAttributes<T>();

            using (var writer = new StreamWriter(path))
            using (var csvWriter = new CsvWriter(writer, config))
            {
                csvWriter.WriteRecords(records);
            }
        }

        public void AppendRange(List<T> records, string path, CsvConfiguration configArg = null)
        {
            var config = configArg ?? new(CultureInfo.InvariantCulture);

            config.HasHeaderRecord = false;
            config.ApplyAttributes<T>();

            using (var stream = File.Open(path, FileMode.Append))
            using (var writer = new StreamWriter(stream))
            using (var csvWriter = new CsvWriter(writer, config))
            {
                csvWriter.WriteRecords(records);
            }
        }
    }
}
