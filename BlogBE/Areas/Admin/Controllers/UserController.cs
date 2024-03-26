using Blog.DataAccess.Data;
using Blog.DataAccess.Repository;
using Blog.DataAccess.Repository.IRepository;
using Blog.Models;
using Blog.Utility;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace BlogBE.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Route("User")]
    [Authorize(Roles =SD.Role_Admin)]
    public class UserController : Controller
    {
        private readonly IUnitOfWork _unitOfWork;

        public UserController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }
        [HttpGet("Index")]
        public IActionResult Index()
        {
            //TO LIST ALL USERS
            //List<User> objUserList = _db.UserProperties.ToList();
            List<User> objUserList = _unitOfWork.User.GetAll().ToList();


            // TO LIST ONE USER
            //    var firstUser = _userRepo.UserProperties.FirstOrDefault(); // Retrieve the first user from the database

            // TO LIST A SPECIFIC USER BY ID
            //COME BACK TO AFTER SOLVING IDENTITY
            //var firstUser = _unitOfWork.User.Get(u => u.Id == 2);

            //List<User> firstObjUserList = new List<User>(); // Create a new list

            //if (firstUser != null)
            //{
            //    firstObjUserList.Add(firstUser); // Add the first user to the list
            //}

            //return View(firstObjUserList);
            return View();
        }
        [HttpGet("{username}")]
        public IActionResult User_Profile(string username)
        {
            //var user = _db.UserProperties.FirstOrDefault(u => u.username == username);
            //var user = _unitOfWork.User.Get(u => u.username == username);

            //if (user == null)
            //{
            //    return NotFound();
            //}
            return View();
        }
    }
}
