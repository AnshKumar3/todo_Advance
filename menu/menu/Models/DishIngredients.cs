namespace menu.Models
{
    public class DishIngredients
    {
        public int DishId { get; set; }
        public Dish Dish { get; set; }
        public int IngredientsId { get; set; }
        public Dish Ingredients { get; set; }

        public List<DishIngredients>? DishIngredient { get; set; }
}
}
