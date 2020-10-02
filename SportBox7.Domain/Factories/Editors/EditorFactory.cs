using SportBox7.Domain.Exeptions;
using SportBox7.Domain.Models.Editors;
using System;
using System.Collections.Generic;
using System.Text;

namespace SportBox7.Domain.Factories.Editors
{
    internal class EditorFactory : IEditorFactory
    {
        private string firstName = default!;
        private string lastName = default!;

        private bool isFirstNameSet = false;
        private bool isLastNameSet = false;


        public IEditorFactory WithFirstName(string firstName)
        {
            this.firstName = firstName;
            this.isFirstNameSet = true;

            return this;
        }

        public IEditorFactory WithLastName(string lastName)
        {
            this.lastName = lastName;
            this.isFirstNameSet = true;

            return this;
        }

        public Editor Build()
        {
            if (this.isFirstNameSet! || this.isLastNameSet! )
            {
                throw new InvalidEditorException("FirstName and LastName must have values!");
            }

            return new Editor(this.firstName, this.lastName);
        }

    }
}
