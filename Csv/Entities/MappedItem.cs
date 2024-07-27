namespace CvsHelperTalk.Csv.Entities
{
    public class MappedItem
    {
        public List<Person> People { get; set; }
        public string Json { get; set; }
    }

    public class Person
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }
    }
}
