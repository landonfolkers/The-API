using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using TodoApi.Models;
using System.Linq;

namespace TheApi.Controllers
{
    [Route("api/[controller]")]
    public class TodoController : Controller
    {
        private readonly Context _context;

        public TodoController(Context context)
        {
            _context = context;

            if (_context.Items.Count() == 0)
            {
                _context.Items.Add(new Item { Name = "Item1" });
                _context.SaveChanges();
            }
        }
    }
}
