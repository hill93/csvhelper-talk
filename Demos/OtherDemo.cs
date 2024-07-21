using CvsHelperTalk.Csv.Readers;

namespace CvsHelperTalk.Demos
{
    public class OtherDemo
    {
        public void Run()
        {
            var otherItemReader = new OtherItemReader();
            var items = otherItemReader.Read();
        }
    }
}
