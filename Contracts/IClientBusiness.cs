using System.Threading.Tasks;

namespace AskonaTestApp.Contracts
{
    /// <summary>
    /// Контракт класса с бизнесовой логикой клиентов
    /// </summary>
    public interface IClientBusiness
    {
        /// <summary>
        /// Отправить письма самым активным клиентам
        /// </summary>
        Task SendEmailsToTopClients();
    }
}