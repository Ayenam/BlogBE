using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blog.Models.ViewModels
{
    public class PostVM
    {
        public Post Post { get; set; }
        public List<PostReply> PostReply { get; set; }

        //public List<PostReply> PostReplyList { get; set; }
    }
}
