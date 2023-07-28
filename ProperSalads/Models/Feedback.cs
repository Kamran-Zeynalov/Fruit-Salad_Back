namespace ProperSalads.Models
{
    public class Feedback : BaseModel
    {
        public string? Comment { get; set; }
        public int fruitSaladId { get; set; }
        public FruitSalad fruitSalad { get; set; } = null!;
    }
}
