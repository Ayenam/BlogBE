using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Blog.Models;
using Microsoft.EntityFrameworkCore.Diagnostics;
namespace Blog.DataAccess.Repository.IRepository
{
    public interface IPostRepository :IRepository<Post>
    {
        void Update(Post obj);
    }
}
