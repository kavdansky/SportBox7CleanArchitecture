using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Options;
using SportBox7.Application;
using SportBox7.Application.Contracts;
using SportBox7.Domain.Factories.Editors;
using SportBox7.Domain.Models.Articles;
using SportBox7.Domain.Models.Editors;

namespace SportBox7.Web.Features
{
    [ApiController]
    [Route("[controller]")]
    public class ArticlesController: ControllerBase
    {
        private readonly IRepository<Article> articles;
        private readonly IOptions<ApplicationSettings> settings;

        public ArticlesController(IRepository<Article> articles, IOptions<ApplicationSettings> settings)
        {
            this.articles = articles;
            this.settings = settings;
        }

        [HttpGet]
        public object Get() => new
        {
            Settings = this.settings,
            Articles = this.articles.All()
        };
    }
}
