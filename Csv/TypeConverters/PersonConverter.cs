using CsvHelper;
using CsvHelper.Configuration;
using CsvHelper.TypeConversion;
using CvsHelperTalk.Csv.Entities;

namespace CvsHelperTalk.Csv.TypeConverters
{
    public class PersonConverter : DefaultTypeConverter
    {
        private readonly int position;
        private readonly Func<Person, string> mapFunc;
        
        public PersonConverter(int position, Func<Person, string> mapFunc)
        {
            this.position = position;
            this.mapFunc = mapFunc;
        }

        public override string? ConvertToString(object? value, IWriterRow row, MemberMapData memberMapData)
        {
            var people = (List<Person>)value;

            if(people.Count > position)
            {
                return mapFunc(people[this.position]);
            }

            return null;
        }
    }
}
