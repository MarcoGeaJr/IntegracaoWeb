using Integracao.Business.Interfaces;
using Integracao.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Integracao.Business.Services
{
    public class NotificationService : INotificationService
    {
        private List<Error> _erros;

        public NotificationService()
            => _erros = new List<Error>();

        public void Add(Error Error)
            =>  _erros.Add(Error);

        public Error GetErrors()
            => _erros.First();

        public bool hasError()
            => _erros.Count > 0;
    }
}
