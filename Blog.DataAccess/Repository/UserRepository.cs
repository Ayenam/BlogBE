using Blog.DataAccess.Data;
using Blog.DataAccess.Repository.IRepository;
using Blog.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Blog.DataAccess.Repository
{
    public class UserRepository : Repository<User>,IUserRepository
    {
        //public void Add(User entity)
        //{
        //    throw new NotImplementedException();
        //}

        //public User Get(Expression<Func<User, bool>> filter)
        //{
        //    throw new NotImplementedException();
        //}

        //public IEnumerable<User> GetAll()
        //{
        //    throw new NotImplementedException();
        //}

        //public void Remove(User entity)
        //{
        //    throw new NotImplementedException();
        //}

        //public void RemoveRange(IEnumerable<User> entity)
        //{
        //    throw new NotImplementedException();
        //}

        private readonly ApplicationDbContext _db;

        public UserRepository(ApplicationDbContext db) :base(db)
        {
            _db= db;
        }

        public void Update(User obj)
        {
            _db.UserProperties.Update(obj);
        }
    }
}
