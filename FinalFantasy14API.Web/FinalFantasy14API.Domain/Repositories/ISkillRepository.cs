using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FinalFantasy14API.Domain.Models;

namespace FinalFantasy14API.Domain.Repositories
{
    public interface ISkillRepository
    {
        IEnumerable<Skill> GetAllSkills();
        IEnumerable<Skill> GetSkillByName(string name);

        IEnumerable<Skill> GetSkillSetByClassId(int classId);
        IEnumerable<Skill> GetSkillSetByJobId(int jobId);
        
    }
}
