using SportBox7.Application.Common;
using SportBox7.Application.Features.Identity;
using SportBox7.Application.Features.Identity.LoginUser;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace SportBox7.Application.Features.Identity
{
    public interface IIdentity
    {
        Task<Result> Register(UserInputModel userInput);

        Task<Result<LoginOutputModel>> Login(UserInputModel userInput);
    }
}
