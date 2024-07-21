using CsvHelper;
using CsvHelper.Configuration;
using System.Globalization;

namespace CvsHelperTalk.Csv.Readers
{
    public class ReaderBase<T>
    {
        public List<T> Read(string path)
        {
            var config = new CsvConfiguration(CultureInfo.InvariantCulture)
            {
                AllowComments = true,
                BadDataFound = data => { Console.WriteLine("uh oh!"); },
                BufferSize = 0,
                Comment = '~',
                CacheFields = false,
                CountBytes = false,
                DetectColumnCountChanges = false,
                MissingFieldFound = field => { Console.WriteLine($"{field} is empty"); },
                PrepareHeaderForMatch = header => header.Header.ToUpper(),
                ShouldSkipRecord = record => record.Row[4].Contains("-"),
                UseNewObjectForNullReferenceMembers = true,
                TrimOptions = TrimOptions.Trim
            };

            config.ApplyAttributes<T>();

            using (var streamReader = new StreamReader(path))
            using (var csvReader = new CsvReader(streamReader, config))
            {
                return csvReader.GetRecords<T>().ToList();
            }
        }
    }
}
