using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using FinalFantasy14API.Domain.Models;
using FinalFantasy14API.Domain.Repositories;
using System.Web.Http.Cors;


namespace FinalFantasy14API.Web.Controllers
{
    [EnableCors(origins: "*", headers: "*", methods: "*")]
    public class TraitsController : ApiController
    {
        ITraitRepository _traitsRepository;

        public TraitsController(ITraitRepository traitRepository){
            _traitsRepository = traitRepository;
        }

        // GET api/traits
        public IEnumerable<Trait> Get()
        {
            return _traitsRepository.GetAllTraits();
        }

        // GET api/traits/5
        public IEnumerable<Trait> Get(string name)
        {
            return _traitsRepository.GetTraitByName(name);
        }

        // POST api/traits
        public void Post([FromBody]string value)
        {
        }

        // PUT api/traits/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/traits/5
        public void Delete(int id)
        {
        }
    }
}
