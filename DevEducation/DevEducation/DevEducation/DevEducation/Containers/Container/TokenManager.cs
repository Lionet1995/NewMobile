using System;
using System.Collections.Generic;
using System.Text;

namespace DevEducation.Container
{
    public class TokenManager : ITokenManager
    {
        public int UserId { get; set; }

        private string _token;
        public string GetToken() => _token;

        public void SetToken(string token)
        {
            _token = "Bearer " + token;
        }
    }
}
