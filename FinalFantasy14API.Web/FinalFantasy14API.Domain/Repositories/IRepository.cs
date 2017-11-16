using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace FinalFantasy14API.Domain.Repositories
{
    //only used by DAL
    public interface IRepository<T>
        where T: class
    {
        IQueryable<T> GetAll();
        IQueryable<T> FindBy(Expression<Func<T, bool>> predicate);

        


        
        //public void Add(T newAdd);
        //public void Update(T newAdd);
        //public void Delete(T delete);

        
    }
}
