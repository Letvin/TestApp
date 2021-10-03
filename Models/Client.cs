using System.Collections.Generic;

namespace AskonaTestApp.Models
{
    /// <summary>
    /// Клиент
    /// </summary>
    public class Client : BaseEntity
    {
        /// <summary>
        /// Почта
        /// </summary>
        public string Email { get; set; }
        
        /// <summary>
        /// Заказы клиента
        /// </summary>
        public virtual ICollection<Order> Orders { get; set; }
    }
}