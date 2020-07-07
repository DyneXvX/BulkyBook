using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Reflection.Metadata.Ecma335;
using System.Text;

namespace BulkyBook.DataAccess.Repository.IRepository
{
    public interface IRepository<T> where T:class //have no clue what type of object - just made up T
    {
        T Get(int id); //based on id will get a category

        IEnumerable<T> GetAll(                                  
            Expression<Func<T, bool>> filter = null,            //it we want to retrieve all categories we pass empty
            Func<IQueryable<T>, IOrderedQueryable<T>> orderBy = null,
            string includeProperties = null                     //if we want to include Properties
        );

        T GetFirstOrDefault(
            Expression<Func<T, bool>> filter = null,
            string includeProperties = null                     
        );

        void Add(T entity);
        void Remove(int id);

        void Remove(T entity);

        void RemoveRange(IEnumerable<T> entity);
    }
}
