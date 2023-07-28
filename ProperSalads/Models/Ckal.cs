namespace ProperSalads.Models
{
    public class Ckal : BaseModel
    {
        public string Name { get; set; } = null!;
        public int fruitSaladId { get; set; }
        public FruitSalad fruitSalad { get; set; } = null!;
    }
}
