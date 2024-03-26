using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace Blog.Models
{
    public class PostReply
    {
        [Key]
        public int PostReplyId { get; set; }
        [Required]
        public int fatherId { get; set; }
        [Required]
        public string username { get; set; }
        [Required]
        public string content { get; set; }
        [Required]

        public DateTime created_at { get; set; }
        public DateTime last_modified { get; set; }
        public int likes { get; set; }

        public int PostId { get; set; }
        [ForeignKey("PostId")]
        public Post Post { get; set; }

    }
}
