using System;
using System.Collections.Generic;
using System.Text;

namespace SportBox7.Domain.Common
{
    public interface IEditableEntity
    {
        public string CreatorId { get; set; }

        public string ModeratorId { get; set; }

        public DateTime CreationDate { get; set; }

        public DateTime LastModDate { get; set; }
    }
}
