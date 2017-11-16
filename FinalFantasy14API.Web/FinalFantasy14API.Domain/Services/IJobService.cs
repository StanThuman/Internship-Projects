using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using FinalFantasy14API.Domain.Models;

namespace FinalFantasy14API.Domain.Services
{
    public interface IJobService
    {
        IEnumerable<Job> GetAllJobs();
        IEnumerable<Job> GetJobByName(string jobName);

        IEnumerable<Skill> GetSkillsByJobName(string jobName);

        IEnumerable<Trait> GetTraitsByJobName(string jobName);
    }
}
