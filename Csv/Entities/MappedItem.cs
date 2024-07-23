using CsvHelper;
using CsvHelper.Configuration;

namespace CvsHelperTalk.Csv.Entities
{
    public class MappedItem
    {
        public List<Person> People { get; set; }
    }

    public class Person
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }
    }

    public class MappedItemMap : ClassMap<MappedItem>
    {
        public MappedItemMap(List<string> headers)
        {
            Map(m => m.People).Convert(args => this.ConvertToPeople(args, headers));
        }

        private List<Person> ConvertToPeople(ConvertFromStringArgs args, List<string> headers)
        {
            var headerGroups = headers.GroupBy(x => x[0]).ToList();

            return headerGroups.Select(x => new Person
            {
                FirstName = args.Row.GetField(x.FirstOrDefault(x => x.EndsWith("fn"))),
                LastName = args.Row.GetField(x.FirstOrDefault(x => x.EndsWith("sn"))),
                Age = int.Parse(args.Row.GetField(x.FirstOrDefault(x => x.EndsWith("a"))))
            }).ToList();
        }
    }
}
