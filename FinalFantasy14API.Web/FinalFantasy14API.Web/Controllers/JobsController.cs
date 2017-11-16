using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using FinalFantasy14API.Domain.Services;
using FinalFantasy14API.Domain.Models;
using System.Web.Http.Cors;


namespace FinalFantasy14API.Web.Controllers
{
    [EnableCors(origins: "*", headers: "*", methods: "*")]
    public class JobsController : ApiController
    {

        private readonly IJobService _jobService;

        public JobsController(IJobService jobService)
        {
            _jobService = jobService;
        }
        // GET api/jobs
        public IEnumerable<Job> Get()
        {
            return _jobService.GetAllJobs();
        }

        // GET api/jobs/5
        public IEnumerable<Job> Get(string name)
        {
            //System.Diagnostics.Debug.Write(_jobService.GetJobByName(name));
            return _jobService.GetJobByName(name);
        }

        [Route("api/jobs/{name}/skills")]
        public IEnumerable<Skill> GetSkillsByJobName(string name)        
        {
            return _jobService.GetSkillsByJobName(name);
        }

        [Route("api/jobs/{name}/traits")]
        public IEnumerable<FinalFantasy14API.Domain.Models.Trait> GetTraitsByJob(string name)
        {
            return _jobService.GetTraitsByJobName(name);
        }

        // POST api/jobs
        //public void Post([FromBody]string value)
        //{
        //}

        //// PUT api/jobs/5
        //public void Put(int id, [FromBody]string value)
        //{
        //}

        //// DELETE api/jobs/5
        //public void Delete(int id)
        //{
        //}
    }
}
