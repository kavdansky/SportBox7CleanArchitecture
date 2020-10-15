using System;
using System.Collections.Generic;
using System.Text;

namespace SportBox7.Application.Features.Identity.Commands
{
    public class UserInputModel
    {
        public string Email { get; } = default!;
        public string Password { get; } = default!;
    }
}
