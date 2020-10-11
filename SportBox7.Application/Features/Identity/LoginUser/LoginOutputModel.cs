using System;
using System.Collections.Generic;
using System.Text;

namespace SportBox7.Application.Features.Identity.LoginUser
{
    public class LoginOutputModel
    {
        public LoginOutputModel(string token)
            => this.Token = token;

        public string Token { get; }
    }
}
