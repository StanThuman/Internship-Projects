using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FinalFantasy14API.Domain.Services;
using FinalFantasy14API.Domain.Repositories;

namespace FinalFantasy14API.Dal.Repositories
{
    public class SkillRepository : Repository<FF14Context, Skill>, ISkillRepository
    {

        //gets all skills
        public IEnumerable<FinalFantasy14API.Domain.Models.Skill> GetAllSkills()
        {
            return MapToDomainModel(GetAll());
        }

        //gets one skill
        public IEnumerable<FinalFantasy14API.Domain.Models.Skill> GetSkillByName(string name)
        {
            
            return MapToDomainModel(FindBy(x => x.ActionName == name));
        }

        
        //gets the skills of the class accordinging to the class Id
        public IEnumerable<Domain.Models.Skill> GetSkillSetByClassId(int classId)
        {
            //var result = Context().Skills.Join(Context().Class_Skills,
            //    p => p.SkillId,
            //    m => m.SkillsId,
            //    (p, m) => new { Skill = p, Class_Skills = m }).Where(classSkill => classSkill.Class_Skills.FFClassId == classId);

            var query = Context().Skills.Join(Context().Class_Skills,
                p => p.SkillId,
                m => m.SkillsId,
                (p, m) => new { Skill = p, Class_Skills = m }).ToList().Where(classSkill => classSkill.Class_Skills.FFClassId == classId)
                .Select(skill => new Skill
                {
                    ActionName = skill.Skill.ActionName,
                    LevelAcquired = skill.Skill.LevelAcquired,
                    TpCost = skill.Skill.TpCost,
                    MpCost = skill.Skill.MpCost,
                    CastTime = skill.Skill.CastTime,
                    Cooldown = skill.Skill.Cooldown,
                    Range = skill.Skill.Range,
                    Radius = skill.Skill.Radius,
                    Description = skill.Skill.Description
                });              

            return MapToDomainModel(query.ToList().AsEnumerable());
        }

        public IEnumerable<Domain.Models.Skill> GetSkillSetByJobId(int jobId)
        {
            var query = Context().Skills.Join(Context().Job_Skills,
                p => p.SkillId,
                m => m.SkillsId,
                (p, m) => new { Skill = p, job_Skills = m }).ToList().Where(jobSkill => jobSkill.job_Skills.JobId == jobId)
                .Select(skill => new Skill
                {
                    ActionName = skill.Skill.ActionName,
                    LevelAcquired = skill.Skill.LevelAcquired,
                    TpCost = skill.Skill.TpCost,
                    MpCost = skill.Skill.MpCost,
                    CastTime = skill.Skill.CastTime,
                    Cooldown = skill.Skill.Cooldown,
                    Range = skill.Skill.Range,
                    Radius = skill.Skill.Radius,
                    Description = skill.Skill.Description
                });

            return MapToDomainModel(query.ToList().AsEnumerable());
        }




        #region mapper
        public IEnumerable<FinalFantasy14API.Domain.Models.Skill> MapToDomainModel(IEnumerable<Skill> modelSource)
        {
            List<FinalFantasy14API.Domain.Models.Skill> SkillList = new List<FinalFantasy14API.Domain.Models.Skill>();
            FinalFantasy14API.Domain.Models.Skill oneSkill;

            foreach (Skill skill in modelSource)
            {
                oneSkill = new FinalFantasy14API.Domain.Models.Skill();
                oneSkill.ActionName = skill.ActionName;
                oneSkill.LevelAcquired = skill.LevelAcquired;
                oneSkill.TpCost = skill.TpCost;
                oneSkill.MpCost = skill.MpCost;
                oneSkill.CastTime = skill.CastTime;
                oneSkill.Cooldown = skill.Cooldown;
                oneSkill.Range = skill.Range;
                oneSkill.Radius = skill.Radius;
                oneSkill.Description = skill.Description;

                SkillList.Add(oneSkill);
            }

            return SkillList;
        }
        #endregion






    }
}
