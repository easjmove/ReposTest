using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using BooksAPI.Managers;
using BooksAPI.Models;

namespace BooksAPI.Controllers
{
    [Route("api/[controller]")]
    // the controller is available on ..../api/books
    // [controller] means the name of the controller minus "Controller"
    [ApiController]
    public class BooksController : ControllerBase
    {
        private readonly BooksRepository _repository;

        public BooksController(BooksRepository repository)
        {
            _repository = repository;
        }

        // GET: api/<BooksController>
        [HttpGet]
        public IEnumerable<Book> Get()
        {
            return _repository.GetAll();
        }

        // GET api/<BooksController>/5
        [HttpGet("{id}")]
        public Book Get(int id)
        {
            return _repository.GetById(id);
        }

        // POST api/<BooksController>
        [HttpPost]
        public Book Post([FromBody] Book value)
        {
            return _repository.Add(value);
        }

        // PUT api/<BooksController>/5
        [HttpPut("{id}")]
        public Book Put(int id, [FromBody] Book value)
        {
            return _repository.Update(id, value);
        }

        // DELETE api/<BooksController>/5
        [HttpDelete("{id}")]
        public Book Delete(int id)
        {
            return _repository.Delete(id);
        }
    }
}