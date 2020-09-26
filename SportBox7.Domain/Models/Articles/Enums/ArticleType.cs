using SportBox7.Domain.Common;
using System;
using System.Collections.Generic;
using System.Text;

namespace SportBox7.Domain.Models.Articles.Enums
{
    public class ArticleType: Enumeration
    {
        public static readonly ArticleType NewsArticle = new ArticleType(1, nameof(NewsArticle));
        public static readonly ArticleType PeriodicArticle = new ArticleType(2, nameof(PeriodicArticle));
        

        private ArticleType(int value)
            : this(value, FromValue<ArticleState>(value).Name)
        {
        }

        private ArticleType(int value, string name)
            : base(value, name)
        {
        }
    }
}
