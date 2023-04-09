namespace Stolovaya.API.Models.Store
{
    /// <summary>
    /// Торговая точка
    /// </summary>
    public class Store : Entity
    {
        public string Name { get; set; }

        /// <summary>
        /// Описание магазина
        /// </summary>
        public string Description { get; set; }

        /// <summary>
        /// Время работы
        /// </summary>
        public DateTime TimeStart { get; set; }

        /// <summary>
        /// Время работы
        /// </summary>
        public DateTime TimeEnd { get; set; }
    }
}
