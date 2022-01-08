using Business;
using DataAccess.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace ToDoApi2.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BoardController : ControllerBase
    {
        private readonly IBoardBusiness _boardBusiness;
        public BoardController(IBoardBusiness boardbusiness)
        {
            _boardBusiness = boardbusiness;
        }

        // GET: api/<BoardController>
        [HttpGet]
        public IEnumerable<Board> ListAllBoards()
        {
            return _boardBusiness.ListAllBoards();
        }

        // GET api/<BoardController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<BoardController>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<BoardController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<BoardController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            Board b = new Board();
            _boardBusiness.RemoveBoard(b);
        }
    }
}
