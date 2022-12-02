using Ecommerce.Data;
using Microsoft.AspNetCore.Mvc;

namespace Ecommerce.Controllers
{
    public class ActorsController : Controller
    {
        //startby injecting appdbcontect
        private readonly AppDbContext _dbContext;

        public ActorsController(AppDbContext dbContext)
        {
            _dbContext = dbContext;
        }
        //Index in=s the default view for this controller
        //it is accessed by nevigationg to our controller Actors in browers and slash Index
        //since its the default if we dont put /index, it will still be accessed
        public IActionResult Index()
        {
            //get the data to return to the view

            var data = _dbContext.Actors.ToList();
            //pass data to the view 
            return View(data);
        }
    }
}
