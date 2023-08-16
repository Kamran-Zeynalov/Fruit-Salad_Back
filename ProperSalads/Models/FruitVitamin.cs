namespace ProperSalads.Models
{
    public class FruitVitamin : BaseModel
    {
        public int FruitId { get; set; }
        public int VitaminId { get; set; }
        public Fruit? Fruit { get; set; }
        public Vitamin? Vitamin { get; set; }


    }
}
