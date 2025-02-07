namespace menu.Models
{
    public class Ingredients
    {
        public string Id { get; set; }
        public string Name { get; set; }

        public List<DishIngredients>? DishIngredient { get; set; }

    }
}
