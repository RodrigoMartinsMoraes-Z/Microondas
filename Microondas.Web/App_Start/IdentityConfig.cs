using Microsoft.AspNet.Identity;

using System.Threading.Tasks;

namespace Microondas.Web
{
    public class EmailService : IIdentityMessageService
    {
        public Task SendAsync(IdentityMessage message)
        {
            // Conecte seu serviço de email aqui para enviar um email.
            return Task.FromResult(0);
        }
    }

    public class SmsService : IIdentityMessageService
    {
        public Task SendAsync(IdentityMessage message)
        {
            // Conecte seu serviço de SMS aqui para enviar uma mensagem de texto.
            return Task.FromResult(0);
        }
    }
}
