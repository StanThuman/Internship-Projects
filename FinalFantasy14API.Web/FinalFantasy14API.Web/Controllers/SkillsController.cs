using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using FinalFantasy14API.Domain.Repositories;
using FinalFantasy14API.Domain.Models;
using System.Web.Http.Cors;


namespace FinalFantasy14API.Web.Controllers
{
    [EnableCors(origins: "*", headers: "*", methods: "*")]
    public class SkillsController : ApiController
    {
        
        ISkillRepository _skillRepository;

        public SkillsController(ISkillRepository skillRepository)
        {
            _skillRepository = skillRepository;
        }
        
        // GET api/skills
        public IEnumerable<Skill> Get()
        {
            return _skillRepository.GetAllSkills();
        }

        
        public IEnumerable<Skill> Get(string name)
        {
            return _skillRepository.GetSkillByName(name);
        }

        // POST api/skills
        public void Post([FromBody]string value)
        {

        }

        // PUT api/skills/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/skills/5
        public void Delete(int id)
        {
        }
    }
}
