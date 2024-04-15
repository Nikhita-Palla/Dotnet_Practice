using EntityFramework.Data;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace EntityFramework.Controllers
{
    [Route("api/book")]
    [ApiController]
    public class BookController : ControllerBase
    {
        private readonly AppDBContext dbContext;
        public BookController(AppDBContext dbContext)
        {
            this.dbContext = dbContext;
        }

        [HttpPost("")]
        public IActionResult AddBook( Book bookDto)
        {
            var book = new Book
            {
                Title = bookDto.Title,
                Description = bookDto.Description,
                NoOfPages = bookDto.NoOfPages,
                IsActive = bookDto.IsActive,
                CreatedOn = DateTime.Now,
                LanguageId = bookDto.LanguageId
                // Set other properties as needed
            };

            dbContext.Books.Add(book);
            dbContext.SaveChanges();
            return Ok(book);
        }
    }
}
