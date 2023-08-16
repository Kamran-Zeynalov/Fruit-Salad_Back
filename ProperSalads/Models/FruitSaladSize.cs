namespace ProperSalads.Models
{
    public class FruitSaladSize : BaseModel
    {
        public int FruitSaladId { get; set; }
        public int SizeId { get; set; }
        public FruitSalad? FruitSalad { get; set; }
        public Size? Size { get; set; }


    }
}
