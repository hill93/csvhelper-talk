using CvsHelperTalk.Csv.Entities;

namespace CvsHelperTalk.Csv.Writers
{
    public class FoodItemWriter : WriterBase<FoodItem>
    {
        public void WriteRange(List<FoodItem> items)
        {
            base.WriteRange(items, "C:\\CsvReaderTalk\\food.csv");
        }

        public void AppendRange(List<FoodItem> items)
        {
            base.AppendRange(items, "C:\\CsvReaderTalk\\food.csv");
        }
    }
}
