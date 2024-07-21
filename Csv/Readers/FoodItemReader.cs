using CvsHelperTalk.Csv.Entities;

namespace CvsHelperTalk.Csv.Readers
{
    public class FoodItemReader : ReaderBase<FoodItem>
    {
        public List<FoodItem> Read()
        {
            return base.Read("C:\\CsvReaderTalk\\food.csv");
        }
    }
}
