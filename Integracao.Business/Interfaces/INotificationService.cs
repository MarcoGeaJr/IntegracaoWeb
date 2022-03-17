using Integracao.Data.Models;

namespace Integracao.Business.Interfaces
{
    public interface INotificationService
    {
        void Add(Error Error);
        Error GetErrors();

        bool hasError();
    }
}
