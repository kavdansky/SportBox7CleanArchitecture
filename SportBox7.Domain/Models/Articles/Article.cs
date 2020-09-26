using SportBox7.Domain.Common;
using System;
using SportBox7.Domain.Exeptions;
using System.Collections.Generic;
using System.Text;
using SportBox7.Domain.Models.Articles.Enums;

namespace SportBox7.Domain.Models.Articles
{
    public class Article: EditableEntity<int>, IAggregateRoot
    {

        internal Article(string title, string body, string h1Tag, string imageUrl, string seoUrl, string metaDescription, string metaKeywords, Category category, ArticleType articleType, DateTime targetDate)
        {
            this.Validate(title, body, h1Tag, imageUrl, metaKeywords, metaDescription);
           
            this.TargetDate = targetDate;
            this.ArticleType = ArticleType.PeriodicArticle;           
            this.CreationDate = DateTime.Now;
            this.LastModDate = this.CreationDate;
            this.Title = title;
            this.Body = body;
            this.H1Tag = h1Tag;
            this.ImageUrl = imageUrl;
            this.SeoUrl = seoUrl;
            this.MetaKeywords = metaKeywords;
            this.MetaDescription = metaDescription;
            this.Category = category;
            this.ArticleState = ArticleState.Draft;
            this.ArticleType = ArticleType;
        }

        private void Validate(string title, string body, string h1Tag, string imageUrl, string metaKeywords, string metaDescription)
        {
            this.ValidateTitle(title);
            this.ValidateBody(body);
            this.ValidateH1Tag(h1Tag);
            this.ValidateImageUrl(imageUrl);
            this.ValidateMetaKeywords(metaKeywords);
            this.ValidateMetaDescription(metaDescription);
        }

        public string Title { get; private set; } = default!;

        public string Body { get; private set; } = default!;

        public string H1Tag { get; private set; } = default!;

        public string ImageUrl { get; private set; } = default!;

        public string MetaDescription { get; private set; } = default!;

        public string MetaKeywords { get; private set; } = default!;

        public string SeoUrl { get; private set; } = default!;

        public Source Source { get; private set; } = default!;

        public Category Category { get; private set; }
       
        public DateTime? TargetDate { get; private set; } 

        public ArticleState ArticleState { get; private set; }

        public ArticleType ArticleType { get; private set; }

        public Article UpdateArticleState(ArticleState articleState)
        {
            this.ArticleState = articleState;

            return this;
        }

        public Article UpdateBody(string body)
        {
            this.ValidateBody(body);
            this.Body = body;
            this.LastModDate = DateTime.Now;

            return this;
        }

        public Article UpdateCategory(Category category)
        {
            this.Category = category;
            this.LastModDate = DateTime.Now;

            return this;
        }

        public Article UpdateH1Tag(string h1Tag)
        {
            this.ValidateH1Tag(h1Tag);
            this.H1Tag = h1Tag;
            this.LastModDate = DateTime.Now;

            return this;
        }

        public Article UpdateImageUrl(string imageUrl)
        {
            this.ValidateImageUrl(imageUrl);
            this.ImageUrl = imageUrl;
            this.LastModDate = DateTime.Now;

            return this;
        }

        public Article UpdateMetaDescription(string metaDescription)
        {
            this.ValidateMetaDescription(metaDescription);
            this.MetaDescription = metaDescription;
            this.LastModDate = DateTime.Now;

            return this;
        }

        public Article UpdateMetaKeywords(string metaKeywords)
        {
            this.ValidateMetaKeywords(metaKeywords);
            this.MetaKeywords = metaKeywords;
            this.LastModDate = DateTime.Now;

            return this;
        }

        public Article UpdateSource(Source source)
        {
            this.Source = source;
            this.LastModDate = DateTime.Now;

            return this;
        }

        public Article UpdateSeoUrl(string seoUrl)
        {
            this.ValidateSeoUrl(seoUrl);
            this.SeoUrl = seoUrl;
            this.LastModDate = DateTime.Now;

            return this;
        }

        public Article UpdateSource(string sourceName, string sourceUrl, string sourceImageUrl)
        {
            this.Source = new Source(sourceName, sourceUrl, sourceImageUrl);
            this.LastModDate = DateTime.Now;

            return this;
        }

        public Article UpdateTargetDate(DateTime targetDate)
        {
            if (this.ArticleType == ArticleType.NewsArticle)
            {
                throw new InvalidArticleException("News Articles cannot have a Target Date");
            }
            this.TargetDate = targetDate;
            this.LastModDate = DateTime.Now;

            return this;
        }

        public Article UpdateTitle(string title)
        {

            this.ValidateTitle(title);
            this.Title = title;
            this.LastModDate = DateTime.Now;

            return this;
        }

        private void ValidateSeoUrl(string seoUrl)
        {
            Validator.CheckValidUrl<InvalidArticleException>(seoUrl, "SeoUrl");
        }

        private void ValidateMetaKeywords(string metaKeywords)
        {
            byte min = 5;
            byte max = 60;
            Validator.CheckForEmptyString<InvalidArticleException>(metaKeywords, "MetaDescription");
            Validator.CheckStringLength<InvalidArticleException>(metaKeywords, min, max, "MetaDescription");
        }

        private void ValidateImageUrl(string imageUrl)
        {
            Validator.CheckValidUrl<InvalidArticleException>(imageUrl, "ImageUrl");
            
        }

        private void ValidateH1Tag(string h1Tag)
        {
            byte min = 5;
            byte max = byte.MaxValue;
            Validator.CheckForEmptyString<InvalidArticleException>(h1Tag, "H1Tag");
            Validator.CheckStringLength<InvalidArticleException>(h1Tag, min, max, "H1Tag");
        }

        private void ValidateBody(string body)
        {
            ushort min = 5;
            ushort max = ushort.MaxValue;
            Validator.CheckForEmptyString<InvalidArticleException>(body, "Body");
            Validator.CheckStringLength<InvalidArticleException>(body, min, max, "Body");
        }

        private void ValidateTitle(string ArticleTitle)
        {
            byte min = 5;
            byte max = 60;
            Validator.CheckForEmptyString<InvalidArticleException>(ArticleTitle, "Title");
            Validator.CheckStringLength<InvalidArticleException>(ArticleTitle, min, max, "Title");
        }

        private void ValidateMetaDescription(string metadescription)
        {
            byte min = 5;
            byte max = 60;
            Validator.CheckForEmptyString<InvalidArticleException>(metadescription, "metaDescription");
            Validator.CheckStringLength<InvalidArticleException>(metadescription, min, max, "metaDescription");
        }
    }
}
