using Blog.Models;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Blog.Models

{
    public class Post
    {
        [Key]
        public int Unique_Id_Post { get; set; }
       
        [Required]
        public string content { get; set; }
        [Required]
        public string content_title { get; set; }
        public string DisplayName { get; set; }
        public int? post_replies { get; set; }

        public DateTime created_at { get; set; }
        public DateTime? last_modified { get; set; }

        public string? author_user_id { get; set; }
        [ForeignKey("author_user_id")]
        public User? User { get; set; }


    }
}
