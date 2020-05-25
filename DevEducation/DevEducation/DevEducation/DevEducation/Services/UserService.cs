using Autofac;
using DevEducation.Container;
using DevEducation.DTO;
using DevEducation.RestApi;
using DevEducation.RestApiInterfaces;
using Refit;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace DevEducation.Models
{
    class UserService : IUserService
    {
        private readonly IUserApi _client;

        public UserService()
        {
            HttpClient client = new HttpClient
            {
                BaseAddress = new Uri("http://80.78.240.16:5100/")
            };
            _client = RestService.For<IUserApi>(client);
        }

        public async Task Auth(LoginDto model)
        {
            
                var authResult = await _client.Login(model);
            if (authResult.Token != null)
            {
                App.container.Resolve<ITokenManager>().SetToken(authResult.Token);
                App.container.Resolve<ITokenManager>().UserId = authResult.UserId;
            }
            
        }


    }
}
