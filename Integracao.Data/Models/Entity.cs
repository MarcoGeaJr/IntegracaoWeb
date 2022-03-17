using System;

namespace Integracao.Data.Models
{
    public abstract class Entity
    {
        public Guid Id { get; set; }
        public bool IsDeleted { get; private set; } = false;

        public void Desactive() // Soft-delete
            => IsDeleted = true;

        public void Active()
            => IsDeleted = false;
    }
}
