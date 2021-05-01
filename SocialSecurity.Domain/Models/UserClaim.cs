using IdentityModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;

namespace SocialSecurity.Domain.Models
{
    public class UserClaim
    {

        public UserData Claims(ClaimsPrincipal user)
        {
            UserData newUser = new UserData();
            newUser.UserName = "Test";
            newUser.UserId = "TestId";
//            newUser.UserName = user.Claims.First(claim => claim.Type == JwtClaimTypes.PreferredUserName).Value;
//            newUser.UserId = user.Claims.First(claim => claim.Type == JwtClaimTypes.Subject).Value;
            return newUser;
        }
    }
}
