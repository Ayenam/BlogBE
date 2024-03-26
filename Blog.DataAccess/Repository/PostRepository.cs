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
    public class PostRepository : Repository<Post>, IPostRepository
    {
        private readonly ApplicationDbContext _db;

        public PostRepository(ApplicationDbContext db):base(db) 
        {
            _db = db;
        }

        public void Save()
        {
            _db.SaveChanges();   
        }

        public void Update(Post obj)
        {
            _db.PostProperties.Update(obj);
        }
    }
}

