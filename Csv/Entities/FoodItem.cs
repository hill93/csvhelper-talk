using CsvHelper.Configuration.Attributes;
using CvsHelperTalk.Csv.Enum;
using CvsHelperTalk.Csv.TypeConverters;

namespace CvsHelperTalk.Csv.Entities
{
    public class FoodItem
    {
        public int Id { get; set; }

        [Name("name")]
        public string Name { get; set; }

        [Index(2)]
        public string Description { get; set; }

        [Name("price")]
        public decimal Price { get; set; }

        [Name("units")]
        public Unit Unit { get; set; }

        [Name("quantity")]
        public decimal Quantity { get; set; }

        [Name("dateAdded")]
        [Format("dd/MM/yyyy")]
        public DateTime DateAdded { get; set; }

        [Name("inStock")]
        [BooleanTrueValues("yes","y","oui")]
        [BooleanFalseValues("no","n","non")]
        public bool InStock { get; set; }

        [Name("nutritionalInfo")]
        [TypeConverter(typeof(JsonConverter<NutritionalInfo>))]
        public NutritionalInfo NutritionalInfo { get; set; }

        //This won't work without Ignore
        [Ignore]
        public int Deliciousness { get; set; }

        //This works with/without header
        [Optional]
        public bool OnOffer { get; set; }
    }
}
