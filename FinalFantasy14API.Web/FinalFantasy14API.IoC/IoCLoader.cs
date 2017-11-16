using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FinalFantasy14API.Dal.Repositories;
using FinalFantasy14API.Domain.Repositories;

using FinalFantasy14API.Dal.Services;
using FinalFantasy14API.Domain.Services;
using Ninject;


namespace FinalFantasy14API.IoC
{
    public class IoCLoader
    {
        public static void RegisterServices(IKernel kernel)
        {
            //repo binding
            kernel.Bind<IFFClassRepository>().To<FFClassRepository>();
            kernel.Bind<IJobRepository>().To<JobRespository>();
            kernel.Bind<ISkillRepository>().To<SkillRepository>();
            kernel.Bind<ITraitRepository>().To<TraitRepository>();

            //service binding
            kernel.Bind<IFFClassService>().To<FFClassService>();
            kernel.Bind<IJobService>().To<JobService>();
            


        }
    }
}
