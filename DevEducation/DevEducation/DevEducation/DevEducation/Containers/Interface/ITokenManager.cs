using System;
using System.Collections.Generic;
using System.Text;

namespace DevEducation.Container
{
   public interface ITokenManager
    {
        int UserId { get; set; }
        void SetToken(string token);
        string GetToken();
    }
}
