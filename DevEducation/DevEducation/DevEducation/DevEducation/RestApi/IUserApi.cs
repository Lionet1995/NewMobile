using DevEducation.DTO;
using Refit;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace DevEducation.RestApi
{

    [Headers("Content-Type: application/json")]
    interface IUserApi
    {
        [Post("/token")]
        Task<LoginOutputModel> Login(LoginDto model);
    }
}
