using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebApiAsp.Net6.Data;
using WebApiAsp.Net6.Models;

namespace WebApiAsp.Net6.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BookController : ControllerBase
    {
        private readonly MyDbContext _context;

        public BookController(MyDbContext context) 
        {
            _context = context;
        }

        [HttpGet("GetAll")]
        public IActionResult GetAll()
        {
            try
            {
                var data = _context.Books.Select(book => new BookModel
                {
                    Id = book.Id,
                    Title = book.Title,
                    Description = book.Description,
                    Price = book.Price
                }).ToList();
                return Ok(data);
            }
            catch(Exception ex)
            {
                return BadRequest("Error occurred: " + ex.Message);
            }
        }
    }   
}
