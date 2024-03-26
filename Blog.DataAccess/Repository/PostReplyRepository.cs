using Blog.DataAccess.Repository.IRepository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Blog.Models;
using Blog.DataAccess.Data;

namespace Blog.DataAccess.Repository
{
    public class PostReplyRepository : Repository<PostReply>, IPostReplyRepository
    {
        private readonly ApplicationDbContext _db;

        public PostReplyRepository(ApplicationDbContext db):base(db) 
        {
            _db = db;
        }

        public void Save()
        {
            _db.SaveChanges();   
        }

        public void Update(PostReply obj)
        {
            _db.PostReplyProperties.Update(obj);
        }
    }
}

