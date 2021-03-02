using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Utilities.Security.Jwt
{
    public class AccessToken
    {
        public DateTime Expiration { get; set; }

        public string Token { get; set; }


    }
}
