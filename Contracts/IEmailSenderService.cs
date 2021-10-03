using System.Threading.Tasks;

namespace AskonaTestApp.Contracts
{
    /// <summary>
    /// Контракт сервиса для отправки Email
    /// </summary>
    public interface IEmailSenderService
    {
        /// <summary>
        /// Отравить письмо
        /// </summary>
        /// <param name="email">Почта для отправки</param>
        /// <param name="body">Тело письма</param>
        Task SendEmail(string email, string body);
    }
}