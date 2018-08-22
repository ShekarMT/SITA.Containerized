
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace SITA_MultiProject16.Repository.Interface 
{
    /// <summary>
    /// Generic Interface defining all actions possible for Every Controller
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public interface IBaseRepository<T> where T : class
    {
        Task<T> Get(string id);
        Task<IList<T>> GetAll(params Expression<Func<T, bool>>[] navigationProperties);
        Task Create(T entity);
        Task<bool> Delete(string id, Type type);
        Task<bool> Update(string id, T data);
    }
}
