using Newtonsoft.Json;

namespace CvsHelperTalk.Csv.Entities
{
    public class NutritionalInfo
    {
        [JsonProperty("energy")]
        public int Energy { get; set; }

        [JsonProperty("protein")]
        public decimal Protein { get; set; }

        [JsonProperty("carbs")]
        public decimal Carbohydrates { get; set; }

        [JsonProperty("sugar")]
        public decimal Sugars { get; set; }
    }
}
