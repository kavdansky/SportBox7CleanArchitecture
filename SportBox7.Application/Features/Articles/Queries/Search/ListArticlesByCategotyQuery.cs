using MediatR;
using SportBox7.Application.Features.CarAds;
using SportBox7.Application.Features.Queries.Search;
using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace SportBox7.Application.Features.Articles.Queries.Search
{
    public class ListArticlesByCategotyQuery : IRequest<SearchArticleOutputModel>
    {
        public string? Category { get; set; }

        public class ListArticleByCategotyHandler : IRequestHandler<ListArticlesByCategotyQuery, SearchArticleOutputModel>
        {
            private readonly IArticleRepository articleRepository;

            public ListArticleByCategotyHandler(IArticleRepository repository) =>
                this.articleRepository = repository;
           

            public async Task<SearchArticleOutputModel> Handle(ListArticlesByCategotyQuery request, CancellationToken cancellationToken)
            {
                var articleList = await this.articleRepository.GetArticleListingsByCategory(request.Category);
                
                return new SearchArticleOutputModel(articleList);
            }
        }
    }
}
