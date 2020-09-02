using System;
using System.Collections.Generic;
using System.Text;

namespace SportBox7.Domain.Common
{
    public abstract class Entity<TKey>
    {
        public virtual TKey Id { get; set; }

        // Add GetHashCode(), Equals(), etc.
    }
}
