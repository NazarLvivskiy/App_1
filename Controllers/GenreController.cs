using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using App_1.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace App_1.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class GenreController : ControllerBase
    {
        IRepository<Genre> repository;

        public GenreController(IRepository<Genre> _repository)
        {
            repository = _repository;
        }

        [HttpGet("{id}")]
        public  ActionResult<Genre> Get(int id)
        {
            return repository.Get(id);
        }


        [HttpGet]
        public ActionResult<List<Genre>> GetAll()
        {
            return repository.GetAll();
        }

        [HttpPost]
        public ActionResult<Genre> Post(Genre genre)
        {
            if (genre == null)
            {
                return BadRequest();
            }

            repository.Add(genre);
            return Ok(genre);
        }

        [HttpPost]
        public ActionResult<Genre> Put(Genre genre)
        {
            if (genre == null)
            {
                return BadRequest();
            }

            repository.Update(genre);
            return Ok(genre);
        }

        [HttpDelete("{id}")]
        public ActionResult<Genre> Delete(int id)
        {
            repository.Delete(id);
            return Ok("Deleted");
        }
    }
}
