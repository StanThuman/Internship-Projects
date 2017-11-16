using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FinalFantasy14API.Domain.Models;

namespace FinalFantasy14API.Domain.Repositories
{
    public interface IJobRepository
    {
        IEnumerable<Job> GetAllJobs();
        IEnumerable<Job> GetJobByName(string name);

        int GetJobId(string name);
    }
}
