using System;
using System.Collections.Generic;
using System.Text;

namespace SportBox7.Domain.Models.Articles
{
    public class Article
    {

        public string CreatorId { get; set; }

        public string ModeratorId { get; set; }

        public DateTime CreationDate { get; set; }

        public DateTime LastModDate { get; set; }

        public string Title { get; set; }

        public string Body { get; set; }

        public string H1Tag { get; set; }

        public string ImageUrl { get; set; }

        public bool EnableComments { get; set; }

        public string SourceURL { get; set; }

        public string SourceName { get; set; }

        public int CategoryId { get; set; }

        //public Category Category { get; set; }
        //
        //public ArticleState State { get; set; }
        //
        //public virtual User User { get; set; }
        //
        //public bool IsDeleted { get; set; }
        //
        //public virtual ArticleSeoData ArticleSeoData { get; set; }
        //
        //public virtual ICollection<SocialSignal> SocialSignals { get; set; }
    }
}
