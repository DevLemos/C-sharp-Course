using System.Globalization;

namespace EX10_LINQ_LAMBDA.Entities
{
     class Product
    {
        public int Id { get; set;}
        public string Name { get; set;}
        public double Price { get; set;}
        public Category Category { get; set;}

        public override string ToString()
        {
            return Id
            + ", "
            + Name
            + ", "
            + Price.ToString("F2", CultureInfo.InvariantCulture)
            + ", "
            + Category.Name
            + ", "
            + Category.Tier;
        }
    }
}