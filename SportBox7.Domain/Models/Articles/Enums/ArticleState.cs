using SportBox7.Domain.Common;
using System;
using System.Collections.Generic;
using System.Text;

namespace SportBox7.Domain.Models.Articles.Enums
{
    public class ArticleState : Enumeration
    {
        public static readonly ArticleState RawArticle = new ArticleState(1, nameof(RawArticle));
        public static readonly ArticleState Draft = new ArticleState(2, nameof(Draft));
        public static readonly ArticleState ForReview = new ArticleState(3, nameof(ForReview));
        public static readonly ArticleState Published = new ArticleState(4, nameof(Published));

        private ArticleState(int value)
            : this(value, FromValue<ArticleState>(value).Name)
        {
        }

        private ArticleState(int value, string name)
            : base(value, name)
        {
        }
    }
}
