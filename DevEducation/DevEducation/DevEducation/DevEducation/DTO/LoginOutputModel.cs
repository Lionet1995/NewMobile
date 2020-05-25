using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace DevEducation.DTO
{
    class LoginOutputModel
    {
        [JsonProperty("access_token")]
        public string Token { get; set; }
        [JsonProperty("username")]
        public string Login { get; set; }
        [JsonProperty("userId")]
        public int UserId { get; set; }
    }
}
