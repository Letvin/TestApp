namespace AskonaTestApp.Models
{
    /// <summary>
    /// Марка (производитель) велосипеда
    /// </summary>
    public class Manufacturer : BaseEntity
    {
        /// <summary>
        /// Название марки
        /// </summary>
        public string Name { get; set; }
    }
}