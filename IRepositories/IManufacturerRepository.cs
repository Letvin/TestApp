using System;
using System.Threading.Tasks;
using AskonaTestApp.DTOs;

namespace AskonaTestApp.IRepositories
{
    /// <summary>
    /// Контракт репозитория для работы с сущностями марок велосипедов
    /// </summary>
    public interface IManufacturerRepository
    {
        /// <summary>
        /// Получить самую прибыльную марку с указанного периода 
        /// </summary>
        /// <param name="dateFrom">Дата начала отсчета</param>
        /// <returns>Самая прибыльная марка</returns>
        Task<ManufacturerDto> GetTopManufacturer(DateTime dateFrom);
    }
}