using System;
using System.Threading.Tasks;
using AskonaTestApp.Contracts;
using AskonaTestApp.DTOs;

namespace AskonaTestApp.Controllers
{
    /// <summary>
    /// Контроллер для работы с марками велосипедов
    /// </summary>
    public class ManufacturerController : BaseController
    {
        private readonly IManufacturerBusiness _manufacturerBusiness;

        public ManufacturerController(IManufacturerBusiness manufacturerBusiness)
        {
            _manufacturerBusiness = manufacturerBusiness;
        }

        /// <summary>
        /// Получить самую прибыльную марку с указанного периода
        /// </summary>
        /// <param name="dateFrom">Дата начала отсчета</param>
        /// <returns>Самая прибыльная марка</returns>
        public async Task<ManufacturerDto> GetTopManufacturer(DateTime dateFrom)
        {
            return await _manufacturerBusiness.GetTopManufacturer(dateFrom);
        }
    }
}