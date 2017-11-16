using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FinalFantasy14API.Domain.Repositories;
using FinalFantasy14API.Domain.Models;

namespace FinalFantasy14API.Dal.Repositories
{
    public class TraitRepository : Repository<FF14Context, Trait>, ITraitRepository
    {


        public IEnumerable<FinalFantasy14API.Domain.Models.Trait> GetAllTraits()
        {
            return MapToDomainModel(GetAll());
        }

        public IEnumerable<FinalFantasy14API.Domain.Models.Trait> GetTraitByName(string name)
        {
            return MapToDomainModel(FindBy(x => x.TraitName == name));
        } 

        
        public IEnumerable<Domain.Models.Trait> GetTraitsByClass(int classId)
        {
            var query = Context().Traits.Join(
                Context().Class_Traits,
                t => t.TraitId,
                ct => ct.TraitId,
                (t, ct) => new { Trait = t, Class_Traits = ct }).ToList()
                .Where(classTraits => classTraits.Class_Traits.FFClassId == classId).Select( trait =>
                new Trait
                {
                    TraitName = trait.Trait.TraitName,
                    LevelAcquired = trait.Trait.LevelAcquired,
                    Description = trait.Trait.Description
                });

            return MapToDomainModel(query.ToList().AsEnumerable());
        }

        public IEnumerable<Domain.Models.Trait> GetTraitsByJob(int jobId)
        {
            var query = Context().Traits.Join(
                Context().Job_Traits,
                t => t.TraitId,
                jt => jt.TraitId,
                (t, ct) => new { Trait = t, Job_Traits = ct }).ToList()
                .Where(jobTraits => jobTraits.Job_Traits.JobId == jobId).Select(trait =>
                new Trait
                {
                    TraitName = trait.Trait.TraitName,
                    LevelAcquired = trait.Trait.LevelAcquired,
                    Description = trait.Trait.Description
                });

            return MapToDomainModel(query.ToList().AsEnumerable());
            
        }

        public IEnumerable<FinalFantasy14API.Domain.Models.Trait> MapToDomainModel(IEnumerable<Trait> modelSource)
        {
            List<FinalFantasy14API.Domain.Models.Trait> newTraitList = new List<FinalFantasy14API.Domain.Models.Trait>();
            FinalFantasy14API.Domain.Models.Trait oneTrait;


            foreach(Trait trait in modelSource){
                oneTrait = new Domain.Models.Trait();
                oneTrait.TraitName = trait.TraitName;
                oneTrait.LevelAcquired = trait.LevelAcquired;
                oneTrait.Description = trait.Description;

                newTraitList.Add(oneTrait);
            }
            return newTraitList;
        }




    }
}
