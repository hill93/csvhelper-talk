using CsvHelper;
using CsvHelper.Configuration;
using System.Globalization;

namespace CvsHelperTalk.Csv.Readers
{
    public class ReaderBase<T>
    {
        public List<T> Read(string path, CsvConfiguration configArg = null)
        {
            var config = configArg ?? new(CultureInfo.InvariantCulture);

            config.ApplyAttributes<T>();

            using (var streamReader = new StreamReader(path))
            using (var csvReader = new CsvReader(streamReader, config))
            {
                return csvReader.GetRecords<T>().ToList();
            }
        }
    }
}
