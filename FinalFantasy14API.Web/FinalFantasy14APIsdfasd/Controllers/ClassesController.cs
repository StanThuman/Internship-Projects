using FinalFantasy14API.Domain.Services;
using FinalFantasy14API.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace FinalFantasy14API.Web.Controllers
{
    public class ClassesController : ApiController
    {
        private readonly IFFClassService _classService;


        public ClassesController(IFFClassService db)
        {
            _classService = db;

        }
      

        // GET api/values
        public IEnumerable<FFClass> Get()
        {

            return _classService.GetAllClasses();

            //return new string[] { "value1", "value2" };
        }

        // GET api/values/5
        //public string Get(int id)
        //{
        //    return "value";
        //}
        public IEnumerable<FFClass> Get(string name)
        {
            
            return _classService.GetClassByName(name);
        }

        //[Route("api/Classes/skills")]
        //public string Skills(int name)
        //{
        //    return "SKILLS MAN";
        //}


        // POST api/values
        public void Post([FromBody]string value)
        {
        }

        // PUT api/values/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/values/5
        public void Delete(int id)
        {
        }
    }
}
