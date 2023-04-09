namespace Stolovaya.API.Models.Store
{
    /// <summary>
    /// Свзяь магазин - блюдо
    /// </summary>
    public class DishStore
    {
        public Guid StoreId { get; set; }
        public Store Store { get; set; }

        public Guid DishId { get; set; }
        public Dish Dish { get; set; }
    }
}
