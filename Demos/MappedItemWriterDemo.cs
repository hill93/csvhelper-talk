using CvsHelperTalk.Csv.Entities;
using CvsHelperTalk.Csv.Writers;

namespace CvsHelperTalk.Demos
{
    public class MappedItemWriterDemo
    {
        public void Run()
        {
            var mappedItemWriter = new MappedItemWriter();

            var items = new List<MappedItem>
            {
                new()
                {
                    People = new()
                    {
                        new()
                        {
                            FirstName = "Philippa",
                            LastName = "Gould",
                            Age = 30
                        },
                        new()
                        {
                            FirstName = "William",
                            LastName = "Mound",
                            Age = 29
                        },
                        new()
                        {
                            FirstName = "Henry",
                            LastName = "Hill",
                            Age = 31
                        }
                    }
                },
                new()
                {
                    People = new()
                    {
                        new()
                        {
                            FirstName = "Steve",
                            LastName = "Smith",
                            Age = 43
                        },
                        new()
                        {
                            FirstName = "Tom",
                            LastName = "Njerry",
                            Age = 60
                        },
                        new()
                        {
                            FirstName = "Wallace",
                            LastName = "Andgromit",
                            Age = 75
                        },
                        new()
                        {
                            FirstName = "Afake",
                            LastName = "Person",
                            Age = 100
                        }
                    }
                },
                new()
                {
                    People = new()
                    {
                        new()
                        {
                            FirstName = "Anew",
                            LastName = "Friend",
                            Age = 22
                        }
                    }
                },
                new()
                {
                    People = new()
                    {
                        new()
                        {
                            FirstName = "Lots",
                            LastName = "Andlots",
                            Age = 43
                        },
                        new()
                        {
                            FirstName = "And",
                            LastName = "Lots",
                            Age = 60
                        },
                        new()
                        {
                            FirstName = "Andlots",
                            LastName = "And",
                            Age = 75
                        },
                        new()
                        {
                            FirstName = "Lots",
                            LastName = "And",
                            Age = 100
                        },
                        new()
                        {
                            FirstName = "Lotsandlots",
                            LastName = "Andlots",
                            Age = 43
                        },
                        new()
                        {
                            FirstName = "And",
                            LastName = "Lotsand",
                            Age = 60
                        },
                        new()
                        {
                            FirstName = "Lots",
                            LastName = "Of",
                            Age = 75
                        },
                        new()
                        {
                            FirstName = "New",
                            LastName = "Peeps",
                            Age = 100
                        }
                    }
                }
            };

            mappedItemWriter.WriteRange(items);
        }
    }
}
