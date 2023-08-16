namespace ProperSalads.Models
{
    public class Size : BaseModel
    {
        public string Name { get; set; } = null!;
        public ICollection<FruitSaladSize>? fruitSaladSizes { get; set; }
    }
}
