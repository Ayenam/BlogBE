using Blog.DataAccess.Data;
using Blog.DataAccess.Repository.IRepository;
using Blog.Models;
using Blog.Models.ViewModels;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System.Dynamic;
using System.Threading.Tasks;

namespace BlogBE.Areas.Customer.Controllers
{
    [Area("Customer")]
    [Route("Post")]
    public class PostController : Controller
    {
        private IUnitOfWork _unitOfWork;

        private UserManager<User> _userManager;
        public PostController(IUnitOfWork unitOfWork,UserManager<User> userManager)
        {
            _unitOfWork = unitOfWork;
            _userManager = userManager;
        }
        [HttpGet("Index")]
        public IActionResult Index()
        {
            //List<Post> objPostList = _db.PostProperties.ToList();
            List<Post> objPostList = _unitOfWork.Post.GetAll().ToList();

            return View(objPostList);
        }
        [HttpGet("Reply")]
        public IActionResult Reply()
        {
            return View();
        }

        [HttpGet("{Unique_Id_Post}")]
        public IActionResult Post_Id(int Unique_Id_Post)
        {
            //var post = _db.PostProperties.FirstOrDefault(u => u.Unique_Id_Post == Unique_Id_Post);


            PostVM postVM = new()
            {
                Post = _unitOfWork.Post.Get(u => u.Unique_Id_Post == Unique_Id_Post),
                PostReply = _unitOfWork.PostReply.GetAll().Where(u => u.PostId == Unique_Id_Post).ToList()
                //PostReply = _unitOfWork.PostReply.GetAll().Where(u => u.PostId == Unique_Id_Post).ToList()


            };

            return View(postVM);
        }


        [HttpGet]
        public IActionResult Create_Post()
        {
            // Optionally, you can initialize any required data before rendering the view
            return View();
        }

        [HttpPost]
        public async Task< IActionResult> Create_Post(Post obj)
        {
            var user = await _userManager.GetUserAsync(User);


            obj.DisplayName = user.Name;
            obj.author_user_id = user.Id;
            obj.created_at = DateTime.Now;

            if (ModelState.IsValid)
            {
            _unitOfWork.Post.Add(obj);
            _unitOfWork.Save();

            }

            return RedirectToAction("Index");
        }



    }
}
