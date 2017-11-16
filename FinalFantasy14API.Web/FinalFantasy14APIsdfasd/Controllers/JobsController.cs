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
    public class JobsController : ApiController
    {
        private readonly IJobService _jobService;

        public JobsController(IJobService jobService)
        {
            _jobService = jobService;
        }

        public IEnumerable<Job> Get()
        {
            return _jobService.GetAllJobs();
        }

        public IEnumerable<Job> Get(string name)
        {
            return _jobService.GetJobByName(name);
        }
    }
}
