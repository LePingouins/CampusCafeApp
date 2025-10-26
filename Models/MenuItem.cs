namespace CampusCafeApp.Models
{
    public class MenuItem
    {
        public int Id { get; set; }                 // PK
        public string Name { get; set; } = string.Empty;
        public string Category { get; set; } = string.Empty; // e.g., "Drink", "Sandwich", "Dessert"
        public decimal Price { get; set; }
        public bool IsAvailable { get; set; }
    }
}
