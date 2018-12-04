using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using webapi.Model;

namespace webapi.Controllers
{
    [ApiController]
    public class Controller : ControllerBase
    {
        private DatabaseContext databaseContext;

        public Controller(DatabaseContext databaseContext)
        {
            this.databaseContext = databaseContext;
        }

        [Route("getPersons")]
        [HttpGet]
        public ActionResult<IEnumerable<Person>> Get()
        {
            return databaseContext.Persons.ToList();
        }

        [Route("insertPerson")]
        [HttpPost]
        //public void Post([FromBody] Person person)
        public void Post([FromForm] Person p)
        {
            databaseContext.Persons.Add(p);
            databaseContext.SaveChanges();
        }
    }
}