using System;

namespace Integracao.Data.Models
{
    public class Entity
    {
        public Guid Id { get; set; }
        public bool IsDeleted { get; private set; }

        public void SoftDelete()
            => IsDeleted = true;

        public void Active()
            => IsDeleted = false;
    }
}
