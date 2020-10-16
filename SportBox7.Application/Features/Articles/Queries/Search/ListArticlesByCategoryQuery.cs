using MediatR;
using SportBox7.Application.Features.Queries.Search;
using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace SportBox7.Application.Features.Articles.Queries.Search
{
    public class ListArticlesByCategoryQuery : IRequest<SearchArticleOutputModel>
    {
        public string? Category { get; set; }

        public class ListArticleByCategotyHandler : IRequestHandler<ListArticlesByCategoryQuery, SearchArticleOutputModel>
        {
            private readonly IArticleRepository articleRepository;

            public ListArticleByCategotyHandler(IArticleRepository repository) =>
                this.articleRepository = repository;
           

            public async Task<SearchArticleOutputModel> Handle(ListArticlesByCategoryQuery request, CancellationToken cancellationToken)
            {
                var articleList = await this.articleRepository.GetArticleListingsByCategory(request.Category);
                
                return new SearchArticleOutputModel(articleList);
            }
        }
    }
}
