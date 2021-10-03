using System;
using System.Threading.Tasks;
using AskonaTestApp.DTOs;

namespace AskonaTestApp.Contracts
{
    /// <summary>
    /// Контракт класса с бизнесовой логикой марок велосипедов
    /// (В данный момент будет просто делегировать работу репозиторию, но в будущем может обрасти логикой)
    /// </summary>
    public interface IManufacturerBusiness
    {
        /// <summary>
        /// Получить самую прибыльную марку с указанного периода 
        /// </summary>
        /// <param name="dateFrom">Дата начала отсчета</param>
        /// <returns>Самая прибыльная марка</returns>
        Task<ManufacturerDto> GetTopManufacturer(DateTime dateFrom);
    }
}