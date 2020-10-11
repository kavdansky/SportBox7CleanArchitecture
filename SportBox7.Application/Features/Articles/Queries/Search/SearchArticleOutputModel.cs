namespace SportBox7.Application.Features.Queries.Search
{
    using SportBox7.Application.Features.Articles.Queries.Search;
    using SportBox7.Application.Features.Queries.Search;
    using System.Collections.Generic;
    using System.Linq;

    public class SearchArticleOutputModel
    {
        internal SearchArticleOutputModel(IEnumerable<ArticleListingModel> articles)
        {
            this.Articles = articles;
            
        }

        public IEnumerable<ArticleListingModel> Articles { get; }

        public int Total { get
            {
                return Articles.Count();
            }
        }
    }
}
