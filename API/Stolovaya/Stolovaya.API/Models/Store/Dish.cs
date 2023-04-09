namespace Stolovaya.API.Models.Store
{
    /// <summary>
    /// Блюдо
    /// </summary>
    public class Dish : Entity
    {
        public string Name { get; set; }

        public string Description { get; set; } 

        public List<Ingredient> Ingredients { get; set; }
    
        /// <summary>
        /// Дата приготовления
        /// </summary>
        public DateTime DateCooking { get; set; }

        public double Price { get; set; }
    }
}
