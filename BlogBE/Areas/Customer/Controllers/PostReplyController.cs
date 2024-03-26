using Blog.DataAccess.Data;
using Blog.DataAccess.Repository.IRepository;
using Blog.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace BlogBE.Areas.Customer.Controllers
{
    [Area("Customer")]
    public class PostReplyController : Controller
    {
        private IUnitOfWork _unitOfWork;

        public PostReplyController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }
        //[HttpGet("{fatherId}")]
        public IActionResult PostReply()
        {
            return View();
        }

    }
}
