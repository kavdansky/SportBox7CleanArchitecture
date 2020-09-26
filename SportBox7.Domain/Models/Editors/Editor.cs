using Castle.Components.DictionaryAdapter;
using SportBox7.Domain.Common;
using SportBox7.Domain.Exeptions;
using SportBox7.Domain.Models.Articles;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace SportBox7.Domain.Models.Editors
{
    public class Editor: Entity<string>, IAggregateRoot
    {
        private readonly HashSet<Article> articles;

        internal Editor(string firstName, string lastName)
        {
            this.Validate(firstName, lastName);
            this.FirstName = firstName;
            this.LastName = lastName;
            this.articles = new HashSet<Article>();

        }

        public string FirstName { get; private set; }

        public string LastName { get; private set; }

        public IReadOnlyCollection<Article> Articles => this.articles.ToList().AsReadOnly();

        public void AddArticle(Article article) => this.articles.Add(article);

        private void Validate(string firstName, string lastName)
        {
            ValidateFirstName(firstName);
            ValidateLastName(lastName);
        }

        private void ValidateLastName(string lastName)
        {
            Validator.CheckForEmptyString<InvalidEditorException>(lastName, "lastName");
            Validator.CheckStringLength<InvalidEditorException>(lastName, 3, 40, "lastName");
        }

        private void ValidateFirstName(string firstName)
        {
            Validator.CheckForEmptyString<InvalidEditorException>(firstName, "firstName");
            Validator.CheckStringLength<InvalidEditorException>(firstName, 3, 40, "firstName");
        }
    }
}
