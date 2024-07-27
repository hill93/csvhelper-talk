using CsvHelper.Configuration;
using CsvHelper;
using CvsHelperTalk.Csv.Entities;

namespace CvsHelperTalk.Csv.Maps
{
    public class MappedItemReaderMap : ClassMap<MappedItem>
    {
        public MappedItemReaderMap()
        {
            Map(m => m.People).Convert(args => this.ConvertToPeople(args));
        }

        private List<Person> ConvertToPeople(ConvertFromStringArgs args)
        {
            var headerGroups = args.Row.HeaderRecord.GroupBy(x => x[0]).ToList();

            return headerGroups.Take(args.Row.ColumnCount / 3)
                .Select(x => new Person
                {
                    FirstName = args.Row.GetField(x.FirstOrDefault(y => y.EndsWith("fn"))),
                    LastName = args.Row.GetField(x.FirstOrDefault(y => y.EndsWith("sn"))),
                    Age = int.Parse(args.Row.GetField(x.FirstOrDefault(y => y.EndsWith('a'))))
                }).ToList();
        }
    }
}
