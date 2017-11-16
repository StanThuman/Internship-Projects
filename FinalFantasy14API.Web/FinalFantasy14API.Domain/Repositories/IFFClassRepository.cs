using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FinalFantasy14API.Domain.Models;

namespace FinalFantasy14API.Domain.Repositories
{
    public interface IFFClassRepository
    {
        IEnumerable<FFClass> GetAllClasses();
        IEnumerable<FFClass> GetClassByName(string name);        
        int getClassId(string className);      
    }
}
