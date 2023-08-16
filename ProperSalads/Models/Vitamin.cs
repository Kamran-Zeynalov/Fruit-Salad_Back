namespace ProperSalads.Models
{
    public class Vitamin : BaseModel
    {
        public string? Name { get; set; }
        public ICollection<FruitVitamin>? fruitSaladVitamins { get; set; }
    }
}
