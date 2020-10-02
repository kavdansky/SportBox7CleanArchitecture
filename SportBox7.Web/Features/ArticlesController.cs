using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.AspNetCore.Mvc;
using SportBox7.Domain.Factories.Editors;
using SportBox7.Domain.Models.Articles;
using SportBox7.Domain.Models.Editors;

namespace SportBox7.Web.Features
{
    [ApiController]
    [Route("[controller]")]
    public class ArticlesController: ControllerBase
    {


        [HttpGet]
        public string Get() => "Test";
    }
}
