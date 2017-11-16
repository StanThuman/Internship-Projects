using FinalFantasy14API.Domain.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FinalFantasy14API.Domain.Repositories;

namespace FinalFantasy14API.Dal.Services
{
    public class JobService : IJobService
    {
        IJobRepository _jobRepository;
        ISkillRepository _skillRepository;
        ITraitRepository _traitRepository;

        public JobService(IJobRepository jobRepository, ISkillRepository skillRepository, ITraitRepository traitRepository)
        {
            _jobRepository = jobRepository;
            _skillRepository = skillRepository;
            _traitRepository = traitRepository;
        }

        public IEnumerable<Domain.Models.Job> GetAllJobs()
        {
            return _jobRepository.GetAllJobs();
        }

        public IEnumerable<Domain.Models.Job> GetJobByName(string name)
        {            
            return _jobRepository.GetJobByName(name);
        }


        public IEnumerable<Domain.Models.Skill> GetSkillsByJobName(string jobName)
        {
            int jobId = _jobRepository.GetJobId(jobName);
            

            return _skillRepository.GetSkillSetByJobId(jobId);
        }


        public IEnumerable<Domain.Models.Trait> GetTraitsByJobName(string jobName)
        {
            int jobId = _jobRepository.GetJobId(jobName);

            return _traitRepository.GetTraitsByJob(jobId);
            
        }


        
    }
}
