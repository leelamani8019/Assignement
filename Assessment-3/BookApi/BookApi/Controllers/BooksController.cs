using Bookdetials;
using Bookdetials.models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace BookApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BooksController : ControllerBase
    {
        private readonly BookContext _context;

        public BooksController(BookContext context)
        {
            _context = context;
        }
        [HttpPost]
        public ActionResult Create(Book book)
        {
            if (book == null)
            {
                return BadRequest();
            }
            else
            {
                _context.Books.Add(book);
                _context.SaveChanges();
                return Ok("Created Successfully");
            }
        }
        [HttpGet]
        public ActionResult Index()
        {
            var books = _context.Books.ToList();
            _context.SaveChanges();
            if (books != null)
            {
                string jsondata = JsonConvert.SerializeObject(books);
                return Ok(jsondata);
            }
            else
            {
                return NotFound();
            }
        }
        [HttpGet("id")]
        public ActionResult GetEmployee(int Id)
        {
            try
            {
                var books = _context.Books.Find(Id);
                return Ok(books);

            }
            catch
            {
                return NotFound();

            }

        }
        [HttpGet("search")]
        public ActionResult Details(string search)
        {
            var employee = _context.Books.Where(e => e.Name== search || e.Zoner == search).ToList();
            if (employee != null)
            {
                var json = JsonConvert.SerializeObject(employee);
                return Ok(json);
            }
            else
            {
                return NotFound(search);
            }

        }
        [HttpPut]
        public IActionResult Update(int bookId, Book book)
        {
            if (book == null)
            {
                return BadRequest("Book object can't be null");
            }
            if (_context == null)
            {
                return NotFound("Table doesn't exists");
            }
            var Update = _context.Books.Where(e => e.Id == bookId).FirstOrDefault();
            if (Update == null)
            {
                return NotFound("Book with this BookId doesn't exists");
            }
            _context.Books.Remove(Update);
            Update.Name = book.Name;
            Update.Zoner = book.Zoner;
            Update.ReleaseDate = book.ReleaseDate;
            Update.cost = book.cost;
            Update.bookimg = book.bookimg;

            _context.Books.Update(Update);
            _context.SaveChanges();

            return Ok(_context.Books);
        }
        [HttpDelete("id")]
        public ActionResult Delete(int id)
        {
            if (id <= 0)
            {
                return NotFound();
            }
            else
            {
                var delbook = _context.Books.Find(id);
                _context.Books.Remove(delbook);
                _context.SaveChanges();
                return Ok("Deleted Successfully");
            }

        }

    }
}
