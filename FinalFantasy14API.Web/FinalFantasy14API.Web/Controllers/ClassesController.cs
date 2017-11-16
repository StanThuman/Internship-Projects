using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using FinalFantasy14API.Domain.Services;
using FinalFantasy14API.Domain.Models;
using System.Web.Http.Filters;
using System.Web.Http.Cors;


namespace FinalFantasy14API.Web.Controllers
{
    [EnableCors(origins: "*", headers: "*", methods: "*")]
    public class ClassesController : ApiController
    {
        private readonly IFFClassService _classService;
        private readonly IJobService _jobService;

        public ClassesController(IFFClassService db, IJobService jDb)
        {            
            _classService = db;
            _jobService = jDb;
        }


        // GET api/values
        public IEnumerable<FinalFantasy14API.Domain.Models.FFClass> Get()
        {
            return _classService.GetAllClasses();
        }

        // GET api/values/5
        public IEnumerable<FFClass> Get(string name)
        {
            return _classService.GetClassByName(name);
        }

        [Route("api/classes/{name}/skills")]
        public IEnumerable<FinalFantasy14API.Domain.Models.Skill> GetSkillsByClass(string name)
        {
            return _classService.GetSkillsByClassName(name);
        }

        //[Route("api/job/{name}/skills")]
        //public IEnumerable<FinalFantasy14API.Domain.Models.Skill> GetSkillsByJob(string name)
        //{
        //    return _jobService.GetSkillsByJobName(name);
        //}

        [Route("api/classes/{name}/traits")]
        public IEnumerable<FinalFantasy14API.Domain.Models.Trait> GetTraitsByClass(string name)
        {
            return _classService.GetTraitsByClassName(name);
        }

        //// POST api/values
        //public void Post([FromBody]string value)
        //{
        //}

        //// PUT api/values/5
        //public void Put(int id, [FromBody]string value)
        //{
        //}

        //// DELETE api/values/5
        //public void Delete(int id)
        //{
        //}
    }
}
