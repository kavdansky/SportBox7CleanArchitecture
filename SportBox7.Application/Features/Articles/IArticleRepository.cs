namespace SportBox7.Application.Features.CarAds
{
    using System.Collections.Generic;
    using System.Threading;
    using System.Threading.Tasks;
    using Contracts;
    using Domain.Models.Articles;
    using Queries.Search;
    using SportBox7.Application.Features.Articles.Queries.Search;

    public interface IArticleRepository : IRepository<Article>
    {
        Task<IEnumerable<ArticleListingModel>> GetArticleListingsByCategory(
            string? category = default,
            CancellationToken cancellationToken = default);

        Task<int> Total(CancellationToken cancellationToken = default);
    }
}
