using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Primitives
{
    public abstract class AggregateRoot
    {
        private readonly List<DomainEvent> _events = new();
        public ICollection<DomainEvent> GetDomainEvents() => _events;

        protected void Raise(DomainEvent _event)
        {
            _events.Add(_event);
        }
    }
}
