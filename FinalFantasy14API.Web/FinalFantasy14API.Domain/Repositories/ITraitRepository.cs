using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FinalFantasy14API.Domain.Models;
namespace FinalFantasy14API.Domain.Repositories
{
    public interface ITraitRepository
    {
        IEnumerable<Trait> GetAllTraits();
        IEnumerable<Trait> GetTraitByName(string name);

        IEnumerable<Trait> GetTraitsByClass(int classId);
        IEnumerable<Trait> GetTraitsByJob(int jobId);
    }
}
