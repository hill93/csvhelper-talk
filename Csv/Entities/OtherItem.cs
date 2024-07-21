using CsvHelper.Configuration.Attributes;
using CsvHelper.Configuration;

namespace CvsHelperTalk.Csv.Entities
{
    [Comment('~')]
    [UseNewObjectForNullReferenceMembers]
    [TrimOptions(TrimOptions.Trim)]
    public class OtherItem
    {
    }
}
