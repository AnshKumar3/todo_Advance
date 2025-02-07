using System.Xml.Schema;

namespace menu.Models
{
    public class Dish
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        = string.Empty;
        public decimal Price { get; set; }
        public string Category { get; set; }
        public string Image { get; set; }
        public string ImageThumbnail { get; set; }
        public bool IsMenuOfTheWeek { get; set; }
        public bool IsInStock { get; set; }
        = false;
        public object DishIngredients { get; internal set; }
        public object DishIngredient { get; internal set; }
    }
}
