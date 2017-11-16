using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FinalFantasy14API.Domain.Repositories;
using FinalFantasy14API.Dal;

namespace FinalFantasy14API.Dal.Repositories
{
    public class FFClassRepository : Repository<FF14Context, FFClass>, IFFClassRepository
    {

        //turn on verbose
        //call stack on

        public IEnumerable<FinalFantasy14API.Domain.Models.FFClass> GetAllClasses()
        {
            return MapToDomainModelList(GetAll());
        }
        
        IEnumerable<Domain.Models.FFClass> IFFClassRepository.GetClassByName(string name)
        {            
            return MapToDomainModelList(FindBy(x => x.ClassName == name));
        }

        public int getClassId(string className)
        {            
            IQueryable<int> classId = FindBy(x => x.ClassName == className).Select(y => y.FFClassId);
            return classId.First();
        }



        #region Mapper
        public IEnumerable<FinalFantasy14API.Domain.Models.FFClass> MapToDomainModelList(IQueryable<FFClass> modelSource)
        {
            List<FinalFantasy14API.Domain.Models.FFClass> domainModel = 
                new List<FinalFantasy14API.Domain.Models.FFClass>();

            FinalFantasy14API.Domain.Models.FFClass newClassAdd;

            foreach(FFClass ffClass in modelSource)
            {
                newClassAdd = new Domain.Models.FFClass();

                newClassAdd.ClassName = ffClass.ClassName;
                newClassAdd.WeaponType = ffClass.weaponType;
                newClassAdd.Role = ffClass.Role;
                newClassAdd.DiscipleOf = ffClass.DiscipleOf;
                newClassAdd.StartingCity = ffClass.startingCity;

                domainModel.Add(newClassAdd);
            }

            return domainModel.AsEnumerable<FinalFantasy14API.Domain.Models.FFClass>();
        }   

        #endregion


       
    }
}
