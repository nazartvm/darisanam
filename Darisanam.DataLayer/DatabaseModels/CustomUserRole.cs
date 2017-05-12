using Microsoft.AspNet.Identity.EntityFramework;
using System.ComponentModel.DataAnnotations.Schema;

namespace Akton.BLL.User
{
    public class CustomUserRole : IdentityUserRole<int>
    {
    }
}