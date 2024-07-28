using CsvHelper.Configuration;
using CvsHelperTalk.Csv.Entities;
using CvsHelperTalk.Csv.TypeConverters;

namespace CvsHelperTalk.Csv.Maps
{
    public class MappedItemWriterMap : ClassMap<MappedItem>
    {
        public MappedItemWriterMap(List<MappedItem> mappedItems)
        {
            var noOfColumns = mappedItems.Max(x => x.People.Count);

            for (int i = 0; i < noOfColumns; i++)
            {
                var peopleFirstNameConverter = new PersonConverter(i, person => person.FirstName);
                var peopleLastNameConverter = new PersonConverter(i, person => person.LastName);
                var peopleAgeConverter = new PersonConverter(i, person => person.Age.ToString());

                Map(m => m.People, false).TypeConverter(peopleFirstNameConverter).Name($"{i + 1}fn");
                Map(m => m.People, false).TypeConverter(peopleLastNameConverter).Name($"{i + 1}sn");
                Map(m => m.People, false).TypeConverter(peopleAgeConverter).Name($"{i + 1}a");
            }
        }
    }
}
