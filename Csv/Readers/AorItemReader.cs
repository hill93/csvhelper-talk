using CvsHelperTalk.Csv.Entities;

namespace CvsHelperTalk.Csv.Readers
{
    public class AorItemReader : ReaderBase<AorItem>
    {
        public List<AorItem> Read()
        {
            return base.Read("C:\\CsvReaderTalk\\ACT_XLT_LLU_19_15_AME_202203310824_202203310824_1_8000000011_20220331082313.NEW");
        }
    }
}
