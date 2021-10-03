using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace AskonaTestApp.Models
{
    /// <summary>
    /// Заказ
    /// </summary>
    public class Order : BaseEntity
    {
        /// <summary>
        /// Дата заказа
        /// </summary>
        public DateTime Date { get; set; }
        
        /// <summary>
        /// Ид велосипеда
        /// </summary>
        public int BicycleId { get; set; }
        
        [ForeignKey(nameof(BicycleId))]
        public virtual Bicycle Bicycle { get; set; }
        
        /// <summary>
        /// Стоимость заказа
        /// </summary>
        public int Cost { get; set; }
        
        /// <summary>
        /// Ид клиента
        /// </summary>
        public int ClientId { get; set; }
        
        public virtual Client Client { get; set; }
    }
}