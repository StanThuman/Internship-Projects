using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FinalFantasy14API.Domain.Repositories;
using FinalFantasy14API.Domain.Models;

namespace FinalFantasy14API.Dal.Repositories
{
    public class JobRespository : Repository<FF14Context, Job>, IJobRepository
    {


        public IEnumerable<FinalFantasy14API.Domain.Models.Job> GetAllJobs()
        {
            return MapToDomainModel(GetAll());
        }

        public IEnumerable<FinalFantasy14API.Domain.Models.Job> GetJobByName(string name)
        {
            return MapToDomainModel(FindBy(x => x.JobName == name));
        }

        public int GetJobId(string name)
        {           
            IQueryable<int> job = FindBy(x => x.JobName == name).Select(y => y.JobId);


            return job.First();
        }





        #region mapper

        public IEnumerable<FinalFantasy14API.Domain.Models.Job> MapToDomainModel(IEnumerable<Job> modelSource)
        {
            List<FinalFantasy14API.Domain.Models.Job> domainJobList = new List<Domain.Models.Job>();

            FinalFantasy14API.Domain.Models.Job oneJob;
            foreach(Job modelJob in modelSource){
                
                oneJob = new Domain.Models.Job();
                oneJob.JobName = modelJob.JobName;
                oneJob.Role = modelJob.Role;
                oneJob.WeaponType = modelJob.WeaponType;
                oneJob.MainClass= modelJob.PrimaryClassRequirement;
                oneJob.SubClass= modelJob.subClassRequirement;
                domainJobList.Add(oneJob);
            }

            return domainJobList.AsEnumerable();
        }

        #endregion


            
    }
}
