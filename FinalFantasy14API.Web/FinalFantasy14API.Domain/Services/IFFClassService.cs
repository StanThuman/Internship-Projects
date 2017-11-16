using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FinalFantasy14API.Domain.Models;

namespace FinalFantasy14API.Domain.Services
{
    public interface IFFClassService
    {
        IEnumerable<FFClass> GetAllClasses();
        IEnumerable<FFClass> GetClassByName(string className);

        IEnumerable<Domain.Models.Skill> GetSkillsByClassName(string className);
        IEnumerable<Domain.Models.Trait> GetTraitsByClassName(string className);
        
    }
}
