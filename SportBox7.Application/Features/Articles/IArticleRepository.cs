namespace SportBox7.Application.Features.Articles
{
    using System.Collections.Generic;
    using System.Threading;
    using System.Threading.Tasks;
    using Contracts;
    using Domain.Models.Articles;
    using Queries.Search;
 

    public interface IArticleRepository : IRepository<Article>
    {
        Task<IEnumerable<ArticleListingModel>> GetArticleListingsByCategory(
            string? category = default,
            CancellationToken cancellationToken = default);

        Task<Category> GetCategory(
            int categoryId,
            CancellationToken cancellationToken = default);

        Task<int> Total(CancellationToken cancellationToken = default);
    }
}
