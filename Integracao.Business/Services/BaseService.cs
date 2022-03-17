using Integracao.Business.Interfaces;
using Integracao.Data.Models;
using System.Net;

namespace Integracao.Business.Services
{
    public abstract class BaseService
    {
        private readonly INotificationService _notificationService;
        protected BaseService(INotificationService notificationService)
            => _notificationService = notificationService;

        protected void ErrorNotification(HttpStatusCode statusCode, string message)
            => _notificationService.Add(new Error(statusCode, message));

        protected Error GetErrors()
            => _notificationService.GetErrors();
    }
}
