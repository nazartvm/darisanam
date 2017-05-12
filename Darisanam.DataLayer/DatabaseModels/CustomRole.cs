using Microsoft.AspNet.Identity.EntityFramework;

namespace Akton.BLL.User
{
    public class CustomRole : IdentityRole<int, CustomUserRole>
    {
        public CustomRole()
        {
        }

        public CustomRole(string name)
        {
            Name = name;
        }
    }
}