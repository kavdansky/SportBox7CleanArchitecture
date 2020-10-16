using System;
using System.Collections.Generic;
using System.Text;
using MediatR;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Options;
using SportBox7.Application;
using SportBox7.Application.Contracts;
using SportBox7.Application.Features.Articles.Queries.Search;
using SportBox7.Application.Features.Queries.Search;
using SportBox7.Domain.Factories.Editors;
using SportBox7.Domain.Models.Articles;
using SportBox7.Domain.Models.Editors;
using SportBox7.Web.Common;
using SportBox7.Application.Features.Articles.Commands.Create;
using Microsoft.AspNetCore.Authorization;

namespace SportBox7.Web.Features
{
    [ApiController]
    [Route("[controller]")]
    public class ArticlesController: ApiController
    {
        
        [HttpGet]
        public async Task<ActionResult<SearchArticleOutputModel>> Search(
             [FromQuery] ListArticlesByCategoryQuery query)
           => (SearchArticleOutputModel)await this.Mediator.Send(query);

        [HttpPost]
        [Authorize]
        public async Task<ActionResult<CreateArticleOutputModel>> Create(
            CreateArticleCommand command)
            => await this.Send(command);
    }
}
