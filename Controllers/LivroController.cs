using LivrariaOnline.Communication.Request;
using LivrariaOnline.Communication.Response;
using LivrariaOnline.Entities;
using Microsoft.AspNetCore.Mvc;

namespace LivrariaOnline.Controllers;


[Route("api/[controller]")]
[ApiController]
public class LivroController : ControllerBase

{
    [HttpGet("todos-livros")]
    [ProducesResponseType(typeof(Livro), StatusCodes.Status200OK)]
    [ProducesResponseType(typeof(string), StatusCodes.Status400BadRequest)]

    public IActionResult GetTodosLivros()
    {
        List<Livro> response = new List<Livro>();
        response.Add(new Livro()
        {
            Id = 1,
            Autor = "João",
            Estoque = 1,
            Genero = Genero.Ação,
            Nome = "Lorem Ipsum",
            Preco = 79.90
        });

         response.Add(new Livro()
        {
            Id = 2,
            Autor = "João",
            Estoque = 1,
            Genero = Genero.Ação,
            Nome = "Lorem Ipsum",
            Preco = 79.90
        });


        return Ok(response);
    }

    [HttpGet]
    [Route("{nome}")]
    [ProducesResponseType(typeof(Livro), StatusCodes.Status200OK)]
    [ProducesResponseType(typeof(string), StatusCodes.Status400BadRequest)]

    public IActionResult GetLivro([FromRoute] string nome)
    {
        var response = new Livro
        {
            Autor = "João",
            Estoque = 1,
            Genero = Genero.Ação,
            Id = 1,
            Nome = "Lorem Impsum",
            Preco = 79.90
        };

        return Ok(response);
    }

    [HttpPost]
    [ProducesResponseType(typeof(ResponseCreateLivroJson),StatusCodes.Status201Created)]
    public IActionResult Create([FromBody]RequestCreateLivroJson request)
    
    {
        var livro = new RequestCreateLivroJson
        {
            Id = 1,
            Autor = request.Autor,
            Estoque = request.Estoque,
            Genero = request.Genero,
            Nome = request.Nome,
            Preco = request.Preco
        };

        return Created(string.Empty, livro);
    }

    [HttpPut]
    [Route("{id}")]
    [ProducesResponseType(StatusCodes.Status204NoContent)]
    public IActionResult Update([FromRoute]int id, [FromBody]RequestUpdateLivroJson request)
    
    {
        var response = new RequestUpdateLivroJson
        {
            Estoque = request.Estoque,
            Preco = request.Preco
        };

        return NoContent();
    }

    [HttpDelete]
    [Route("{id}")]
    [ProducesResponseType(StatusCodes.Status204NoContent)]

    public IActionResult DeletarLivro([FromRoute]int id)
    {
        return NoContent();
    }
}
