using SportBox7.Domain.Exeptions;
using System;
using System.Collections.Generic;
using System.Text;

namespace SportBox7.Domain.Common
{
    public abstract class EditableEntity : IEditableEntity
    {
        private string creatorId;
        private string moderatorId;
        private DateTime creationDate;
        private DateTime lastModeDate;

        public string CreatorId 
        { 
            get => this.creatorId;
            set => this.creatorId = value ?? throw new InvalidEntityException("Creator ID cannot be null.");
        }

        public DateTime CreationDate 
        { 
            get => this.creationDate; 
            set => this.creationDate = value;
        }

        public DateTime LastModDate
        {
            get => this.lastModeDate; 
            set => this.lastModeDate = value;
        }
        public string ModeratorId 
        { 
            get => this.moderatorId; 
            set => this.moderatorId = value ?? throw new InvalidEntityException("Moderator ID cannot be null"); 
        }
    }
}
