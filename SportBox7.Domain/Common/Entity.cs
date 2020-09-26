using System;
using System.Collections.Generic;
using System.Text;

namespace SportBox7.Domain.Common
{
    public abstract class Entity<TKey>
    {
        public virtual TKey Id { get; set; } = default!;

        // Add GetHashCode(), Equals(), etc.
    }
}
