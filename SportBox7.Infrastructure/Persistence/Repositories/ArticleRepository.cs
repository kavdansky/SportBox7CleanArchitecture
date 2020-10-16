namespace SportBox7.Infrastructure.Persistence.Repositories
{
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading;
    using System.Threading.Tasks;
    using Application.Features;
    using Application.Features.Articles.Queries.Search;
    using Domain.Models.Articles;
    using Microsoft.EntityFrameworkCore;
    using SportBox7.Application.Features.Articles;
    using SportBox7.Application.Features.Queries.Search;

    internal class ArticleRepository : DataRepository<Article>, IArticleRepository
    {
        public ArticleRepository(SportBox7DbContext db)
            : base(db)
        {
        }

        public async Task<IEnumerable<ArticleListingModel>> GetArticleListingsByCategory(
            string? category = default,
            CancellationToken cancellationToken = default)
        {
            var query = this.All();

            if (!string.IsNullOrWhiteSpace(category))
            {
                query = query
                    .Where(article => EF
                        .Functions
                        .Like(article.Category.CategoryNameEN, $"%{category}%"))
                    .OrderBy(cr=> cr.CreationDate);
            }

            return await query
                .Select(art => new ArticleListingModel(
                    art.Id,
                    art.Title,
                    art.Body,
                    art.ImageUrl,
                    art.Category.CategoryNameEN))
                .ToListAsync(cancellationToken);
        }

        public async Task<Category> GetCategory(
            int categoryId,
            CancellationToken cancellationToken = default)
            =>  await this.db
                .Categories
                .FirstOrDefaultAsync(c => c.Id == categoryId, cancellationToken);

        public async Task<int> Total(CancellationToken cancellationToken = default)
            => await this
                .All()
                .CountAsync(cancellationToken);

        
    }
}
