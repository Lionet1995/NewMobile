using DevEducation.DTO;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace DevEducation.RestApiInterfaces
{
    interface IUserService 
    {
        Task Auth(LoginDto model);


    }
}
