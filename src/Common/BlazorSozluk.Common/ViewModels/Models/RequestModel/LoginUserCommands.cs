using BlazorSozluk.Common.ViewModels.Models.Queries;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlazorSozluk.Common.ViewModels.Models.RequestModels
{
    public class LoginUserCommand : IRequest<LoginUserViewModel>
    {
        public LoginUserCommand(string emailAdress, string password)
        {
            EmailAdress = emailAdress;
            Password = password;
        }
        public LoginUserCommand()
        {
            
        }
        public string EmailAdress { get; private set; }
        public string Password { get; private set; }
    }
}
