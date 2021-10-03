using System.ComponentModel.DataAnnotations.Schema;

namespace AskonaTestApp.Models
{
    /// <summary>
    /// Велосипед
    /// </summary>
    public class Bicycle : BaseEntity
    {
        /// <summary>
        /// Название модели велосипеда
        /// </summary>
        public string Name { get; set; }
        
        /// <summary>
        /// Ид марки велосипеда
        /// </summary>
        public int ManufacturerId { get; set; }
        
        [ForeignKey(nameof(ManufacturerId))]
        public virtual Manufacturer Manufacturer { get; set; }
        
        
    }
}