namespace ProperSalads.Models
{
    public class Category : BaseModel
    {
        public string? Name { get; set; }
        public ICollection<FruitCategory>? fruitCategories { get; set; }

    }
}
