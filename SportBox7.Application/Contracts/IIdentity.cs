using SportBox7.Application.Common;
using SportBox7.Application.Features.Identity;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace SportBox7.Application.Contracts
{
    public interface IIdentity
    {
        Task<Result> Register(UserInputModel userInput);

        Task<Result<LoginOutputModel>> Login(UserInputModel userInput);
    }
}
