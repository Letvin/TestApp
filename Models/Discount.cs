using System;

namespace AskonaTestApp.Models
{
    /// <summary>
    /// Акция
    /// </summary>
    public class Discount : BaseEntity
    {
        /// <summary>
        /// Дата окончания акции
        /// </summary>
        public DateTime EndDate { get; set; }
        
        /// <summary>
        /// Процент скидки
        /// </summary>
        public int Percent { get; set; }
        
        /// <summary>
        /// Ид марки
        /// </summary>
        public int ManufacturerId { get; set; }
        
        public virtual Manufacturer Manufacturer { get; set; }
    }
}