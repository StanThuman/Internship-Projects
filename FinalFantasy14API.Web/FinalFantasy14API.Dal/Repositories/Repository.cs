using FinalFantasy14API.Domain.Repositories;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace FinalFantasy14API.Dal.Repositories
{
    //C = DB context name while T = the model type
    public class Repository<C, T> :IRepository<T>
        where C : DbContext, new()
        where T: class
    {
        private C _db = new C();

        public C Context()
        {
            if (_db == null)
            {
                _db = new C();
            }
            return _db;
        }
        public IQueryable<T> GetAll()
        {
            
            return _db.Set<T>();            
        }

        public IQueryable<T> FindBy(Expression<Func<T, bool>> predicate)
        {
            IQueryable<T> query = _db.Set<T>().Where(predicate);
            return query;
        }

        

               
    }
}
