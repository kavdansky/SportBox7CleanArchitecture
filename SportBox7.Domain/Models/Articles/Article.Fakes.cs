using FakeItEasy;
using SportBox7.Domain.Models.Articles.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace SportBox7.Domain.Models.Articles
{
    public class ArticleFakes
    {
        public class ArticleDummyFactory : IDummyFactory
        {
            
            public bool CanCreate(Type type) => true;

            public object? Create(Type type) 
                => new Article(
                    "Test Title",
                    "Test Body",
                    "TestH1Tag",
                    "http://imageurl",
                    "http://seourl",
                    "TestMetaDescription",
                    "Test MetaKeywords",
                    new Category("Волейбол", "Volleyball"),
                    ArticleType.NewsArticle, 
                    DateTime.Now
                    );

            public Priority Priority => Priority.Default;
        }
    }
}
