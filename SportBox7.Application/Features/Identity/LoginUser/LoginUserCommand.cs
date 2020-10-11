using MediatR;
using SportBox7.Application.Common;
using SportBox7.Application.Contracts;
using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace SportBox7.Application.Features.Identity.LoginUser
{
    public class LoginUserCommand: UserInputModel, IRequest<Result<LoginOutputModel>>
    {
        public LoginUserCommand(string email, string password)
            :base(email, password)
        {
        }

        public class LoginUserCommandHandler : IRequestHandler<LoginUserCommand, Result<LoginOutputModel>>
        {
            private readonly IIdentity identity;

            public LoginUserCommandHandler(IIdentity identity) =>
                this.identity = identity;

            public async Task<Result<LoginOutputModel>> Handle(LoginUserCommand request, CancellationToken cancellationToken) =>
                await this.identity.Login(request);
        }
    }
}
