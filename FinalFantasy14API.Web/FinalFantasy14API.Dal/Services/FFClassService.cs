using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FinalFantasy14API.Domain.Services;
using FinalFantasy14API.Domain.Repositories;


namespace FinalFantasy14API.Dal.Services
{
    public class FFClassService : IFFClassService
    {
        private readonly IFFClassRepository _FFClassRepository;
        private readonly ISkillRepository _skillRepository;
        private readonly ITraitRepository _traitRepository;
        
        public FFClassService(IFFClassRepository classRepo, ISkillRepository skillRepository, ITraitRepository traitRepository)
        {
            _FFClassRepository = classRepo;
            _skillRepository = skillRepository;
            _traitRepository = traitRepository;
        }

        public IEnumerable<Domain.Models.FFClass> GetAllClasses()
        {
            return _FFClassRepository.GetAllClasses();
        }

        public IEnumerable<Domain.Models.FFClass> GetClassByName(string className)
        {
            return _FFClassRepository.GetClassByName(className);
        }       

        public IEnumerable<Domain.Models.Skill> GetSkillsByClassName(string className)
        {
            int classId = _FFClassRepository.getClassId(className);   
      
            return _skillRepository.GetSkillSetByClassId(classId);
        }

        public IEnumerable<Domain.Models.Trait> GetTraitsByClassName(string className)
        {
            int classId = _FFClassRepository.getClassId(className);

            return _traitRepository.GetTraitsByClass(classId);
        }

    }
}
