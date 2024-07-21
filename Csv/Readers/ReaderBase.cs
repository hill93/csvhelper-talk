using CsvHelper;
using System.Globalization;

namespace CvsHelperTalk.Csv.Readers
{
    public class ReaderBase<T>
    {
        public List<T> Read(string path)
        {
            using (var streamReader = new StreamReader(path))
            using (var csvReader = new CsvReader(streamReader, CultureInfo.InvariantCulture))
            {
                return csvReader.GetRecords<T>().ToList();
            }
        }
    }
}
