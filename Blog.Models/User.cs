using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;
namespace Blog.Models
{
    public class User :IdentityUser
    {
 
        [Required]
        public string Name { get; set; }
        public string profile_description { get; set; }
        public DateTime created_at { get; set; }
        public DateTime? last_online { get; set; }

        public ICollection<Post> Posts { get; set; }
    }
}
