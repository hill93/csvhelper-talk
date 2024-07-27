using CsvHelper;
using CsvHelper.Configuration;
using CsvHelper.TypeConversion;
using CvsHelperTalk.Csv.Entities;
using Newtonsoft.Json;

namespace CvsHelperTalk.Csv.Maps
{
    public class MappedItemWriterMap : ClassMap<MappedItem>
    {
        public MappedItemWriterMap()
        {
            var peopleFirstNameConverter = new PeopleFirstNameConverter(0);
            var peopleLastNameConverter = new PeopleLastNameConverter(0);
            var peopleAgeConverter = new PeopleAgeConverter(0);

            Map(m => m.People, false).TypeConverter(peopleFirstNameConverter).Name("1fn");
            Map(m => m.People, false).TypeConverter(peopleLastNameConverter).Name("1sn");
            Map(m => m.People, false).TypeConverter(peopleAgeConverter).Name("1a");
        }
    }

    public class PeopleFirstNameConverter : DefaultTypeConverter
    {
        private readonly int position;

        public PeopleFirstNameConverter(int position)
        {
            this.position = position;
        }

        public override string ConvertToString(object value, IWriterRow row, MemberMapData memberMapData)
        {
            var people = (List<Person>)value;
            return people[this.position].FirstName;
        }
    }

    public class PeopleLastNameConverter : DefaultTypeConverter
    {
        private readonly int position;

        public PeopleLastNameConverter(int position)
        {
            this.position = position;
        }


        public override string ConvertToString(object value, IWriterRow row, MemberMapData memberMapData)
        {
            var people = (List<Person>)value;
            return people[this.position].LastName;
        }
    }

    public class PeopleAgeConverter : DefaultTypeConverter
    {
        private readonly int position;

        public PeopleAgeConverter(int position)
        {
            this.position = position;
        }


        public override string ConvertToString(object value, IWriterRow row, MemberMapData memberMapData)
        {
            var people = (List<Person>)value;
            return people[this.position].Age.ToString();
        }
    }
}
