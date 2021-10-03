using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AskonaTestApp.Contracts;
using AskonaTestApp.IRepositories;

namespace AskonaTestApp.Business
{
    /// <summary>
    /// Бизнесовая логика работы с клиентами
    /// </summary>
    public class ClientBusiness : IClientBusiness
    {
        private readonly IClientRepository _clientRepository;
        private readonly IEmailSenderService _emailSenderService;

        public ClientBusiness(IClientRepository clientRepository, IEmailSenderService emailSenderService)
        {
            _clientRepository = clientRepository;
            _emailSenderService = emailSenderService;
        }

        /// <inheritdoc />
        public async Task SendEmailsToTopClients()
        {
            var topClients = await _clientRepository.GetTopTenClients();
            foreach (var client in topClients)
            {
                if (!client.Orders.Any())
                {
                    continue;
                }
                
                var lastBicycle = client.Orders
                    .OrderByDescending(o => o.Date)
                    .Select(o => o.Bicycle)
                    .First();

                var body = $"Скидки на велосипед - {lastBicycle.Name}";
                await _emailSenderService.SendEmail(client.Email, body);
            }
        }
    }
}