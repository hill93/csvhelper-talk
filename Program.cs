// See https://aka.ms/new-console-template for more information

using CvsHelperTalk.Csv.Entities;
using CvsHelperTalk.Csv.Readers;
using CvsHelperTalk.Csv.Writers;

var foodItemReader = new FoodItemReader();
var foodItemWriter = new FoodItemWriter();

var items = foodItemReader.Read();

//Add a new item
var item = new FoodItem
{
    Id = 4,
    Name = "Peanut Butter",
    Description = "One of them big tubs, very nice",
    Price = 6.5M,
    Unit = CvsHelperTalk.Csv.Enum.Unit.Grams,
    Quantity = 1000,
    DateAdded = DateTime.Now,
    InStock = true,
    NutritionalInfo = new()
    {
        Energy = 2673,
        Protein = 26.3M,
        Carbohydrates = 9.2M,
        Sugars = 4.2M
    }
};

items.Add(item);

foodItemWriter.AppendRange(new() { item});

//Update items - milk now in stock!
var milk = items.FirstOrDefault(x => x.Name == "Milk");

milk.InStock = true;

foodItemWriter.WriteRange(items);