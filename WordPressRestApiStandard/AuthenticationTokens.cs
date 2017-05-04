using System;
using System.Text;

namespace WordPressRestApiStandard
{
    public class AuthenticationTokens
    {
        public string UserName { get; set; }
        public string ApplicationPassword { get; set; }
        
        public string CreateHeaderToken()
        {
            string retval = Convert.ToBase64String(Encoding.UTF8.GetBytes(UserName+":"+ApplicationPassword));
            return retval;
        }

    }
}