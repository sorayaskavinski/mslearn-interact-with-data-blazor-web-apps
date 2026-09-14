namespace BlazingPizza
{
    public class Topping
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public decimal Price { get; set; }

       public string GetFormattedPrice() => $"R$ {Price:0.00}".Replace(".", ",");
    }
}
