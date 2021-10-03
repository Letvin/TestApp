using System.Collections.Generic;
using System.Threading.Tasks;
using AskonaTestApp.Models;

namespace AskonaTestApp.IRepositories
{
    /// <summary>
    /// Контракт репозитория для работы с сущностями клиентов
    /// </summary>
    public interface IClientRepository
    {
        /// <summary>
        /// Получить 10 самых активных покупателей
        /// </summary>
        /// <returns>10 самых активных покупателелей</returns>
        Task<IEnumerable<ClientDto>> GetTopTenClients();
    }
}