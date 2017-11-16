using FinalFantasy14API.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalFantasy14API.Domain.Services
{
    public interface ITraitsService
    {
        IEnumerable<Trait> GetAllTraits();
        IEnumerable<Trait> GetTraitByName();

        IEnumerable<Trait> GetTraitsByClass(string className);
        IEnumerable<Trait> GetTraitsByJob(string jobName);
    }
}
