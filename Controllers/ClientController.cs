using System.Collections.Generic;
using System.Threading.Tasks;
using AskonaTestApp.Contracts;
using AskonaTestApp.DTOs;
using AskonaTestApp.IRepositories;

namespace AskonaTestApp.Controllers
{
    /// <summary>
    /// Контроллер для работы с клиентами
    /// </summary>
    public class ClientController : ControllerBase
    {
        private readonly IClientBusiness _clientBusiness;
        
        public ClientController(IClientBusiness clientBusiness)
        {
            _clientBusiness = clientBusiness;
        }

        /// <summary>
        /// Отправить письма 10 самым активным покупателям
        /// </summary>
        [HttpGet]
        public async Task SendEmailsToTopClients()
        {
            await _clientBusiness.SendEmailsToTopClients();
        }
    }
}