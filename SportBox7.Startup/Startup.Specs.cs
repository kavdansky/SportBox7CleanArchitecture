﻿namespace SportBox7.Startup
{
    using CarRentalSystem.Infrastructure.Identity;
    using MediatR;
    using Microsoft.AspNetCore.Identity;
    using Microsoft.AspNetCore.Mvc.Controllers;
    using Microsoft.Extensions.Configuration;
    using Microsoft.Extensions.DependencyInjection;
    using MyTested.AspNetCore.Mvc;
    using SportBox7.Application.Features.Articles;
    using SportBox7.Domain.Factories.Articles;
    using SportBox7.Infrastructure.Identity;

    public class TestStartup : Startup
    {
        public TestStartup(IConfiguration configuration) 
            : base(configuration)
        {

        }

        public void ConfigureTestServices(IServiceCollection services)
        {
            base.ConfigureServices(services);

            ValidateServices(services);

            services.ReplaceTransient<UserManager<User>>(_ => IdentityFakes.FakeUserManager);
            services.ReplaceTransient<IJwtTokenGenerator>(_ => JwtTokenGeneratorFakes.FakeJwtTokenGenerator);
        }

        private static void ValidateServices(IServiceCollection services)
        {
            var provider = services.BuildServiceProvider();

            provider.GetRequiredService<IArticleFactory>();
            provider.GetRequiredService<IMediator>();
            provider.GetRequiredService<IArticleRepository>();
            provider.GetRequiredService<IControllerFactory>();
        }
    }
}
