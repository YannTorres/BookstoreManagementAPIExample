using BookstoreManagementAPI.Comunication.Requests;
using Microsoft.AspNetCore.Mvc;

namespace BookstoreManagementAPI.Controllers;
[Route("api/[controller]")]
[ApiController]
public class BooksController : BookstoreManagementBaseController
{
    [HttpGet]
    [Route("{id}")]
    [ProducesResponseType(typeof(Book), StatusCodes.Status200OK)]
    public IActionResult GetBookById(int id)
    {
        var response = new Book()
        {
            Id = id,
            Title = "Três Mosqueteiros",
            Author = "Alexandre Dumas",
            Genders = "Ação",
            Price = 50.99,
            QuantityInStock = 1000,
        };

        return Ok(response);
    }

    [HttpGet]
    [ProducesResponseType(typeof(List<Book>), StatusCodes.Status200OK)]
    public IActionResult GetAllBooks()
    {
        var response = new List<Book>()
        {
            new Book()
            {
                Id = 1,
                Title = "Três Mosqueteiros",
                Author = "Alexandre Dumas",
                Genders = "Romance",
                Price = 50.99,
                QuantityInStock = 1000,
            },
            new Book()
            {
                Id = 2,
                Title = "Arte da Guerra",
                Author = "Sun Tzu",
                Genders = "Ação",
                Price = 38.99,
                QuantityInStock = 5000,
            },
            new Book()
            {
                Id = 3,
                Title = "Eu o Robô",
                Author = "Isaac Asimov",
                Genders = "Ficção",
                Price = 68.99,
                QuantityInStock = 200,
            },
        };

        return Ok(response);
    }

    [HttpPost]
    [ProducesResponseType(typeof(RequestRegisterBookJson), StatusCodes.Status201Created)]
    public IActionResult PostNewBook([FromBody] RequestRegisterBookJson request)
    {
        var response = new RequestRegisterBookJson()
        {
            Title = request.Title,
            Author = request.Author,
        };

        return Created(string.Empty, response);
    }

    [HttpPut]
    [Route("{id}")]
    [ProducesResponseType(StatusCodes.Status204NoContent)]
    public IActionResult PutNewBookInformation(int id, [FromBody] RequestUpdateBookJson request)
    {
        /* Atualizaria o Livro no Banco pelo ID */

        return Ok(request);
    }

    [HttpDelete]
    [Route("{id}")]
    [ProducesResponseType(StatusCodes.Status204NoContent)]
    public IActionResult DeleteBook(int id)
    {
        return NoContent();
    }
}
