using CvsHelperTalk.Csv.Readers;

namespace CvsHelperTalk.Demos
{
    public class AorDemo
    {
        public void Run()
        {
            var aorItemReader = new AorItemReader();
            var aorItem = aorItemReader.Read();
        }
    }
}
