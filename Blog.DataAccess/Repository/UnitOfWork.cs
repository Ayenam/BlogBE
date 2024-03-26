using Blog.DataAccess.Data;
using Blog.DataAccess.Repository.IRepository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blog.DataAccess.Repository
{
    public class UnitOfWork : IUnitOfWork
    {
        private ApplicationDbContext _db;
        public IUserRepository User { get; private set; }

        public IPostRepository Post { get; private set; }
        public IPostReplyRepository PostReply { get; private set; }

        public UnitOfWork(ApplicationDbContext db)
        {
            _db = db;
            User = new UserRepository(_db);
            Post = new PostRepository(_db);
            PostReply = new PostReplyRepository(_db);
        }



        public void Save()
        {
            _db.SaveChanges();
        }
    }
}
