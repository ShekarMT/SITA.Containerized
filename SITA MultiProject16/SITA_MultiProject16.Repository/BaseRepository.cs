
using SITA_MultiProject16.Repository;
using SITA_MultiProject16.Repository.Interface;
using System;
using System.Data.Entity;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Reflection;
using System.Linq.Expressions;
using SITA.NGP.Framework.Infra;

namespace SITA_MultiProject16.Repository
{
    /// <summary>
    /// Generic Layer to handle basic CRUD operations at Application Level
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public class BaseRepository<T> : IBaseRepository<T> where T : class
    {
        #region Private Members
        private readonly AirportEntities _dbContext;
        //private IList<object> _tblList;
        #endregion

        #region Ctor
        public BaseRepository()
        {
            _dbContext = new AirportEntities();
            _dbContext.Database.Connection.Open();

            #region Attempt to extract all DbSet Names from DBContext Object
            //var props = _dbContext.GetType().GetProperties();
            //var dbSetProperties = new List<PropertyInfo>();
			//
            //foreach (var property in props)
            //{
            //    var setType = property.PropertyType;
			//
            //    var isDbSet = setType.IsGenericType && (typeof(IDbSet<>).IsAssignableFrom(setType.GetGenericTypeDefinition()) || setType.GetInterface(typeof(IDbSet<>).FullName) != null);
			//
            //    if (isDbSet)
            //    {
            //        dbSetProperties.Add(property);
            //    }
            //}
			//
            //_tblList = dbSetProperties.Select(x => x.GetValue(_dbContext, null)).ToList();
            #endregion
        }
        #endregion

        #region Generic CRUD Methods
        //[MethodAspectBase]
        public async Task Create(T entity)
        {
            _dbContext.Entry(entity).State = EntityState.Added;
            _dbContext.SaveChanges();
        }

        public async Task<bool> Delete(string id,Type type)
        {
            var table = _dbContext.Set(type);
            foreach(Type t in table)
            {
                if (t.GetMember("Id").FirstOrDefault().ToString().Equals(id))
                {
                    _dbContext.Entry(t).State = EntityState.Deleted;
                    _dbContext.SaveChanges();
                    return true;
                }
            }
            return false;
        }

        public async Task<T> Get(string id)
        {
            throw new NotImplementedException();
        }

        public async virtual Task<IList<T>> GetAll(params Expression<Func<T, bool>>[] navigationProperties)
        {
            List<T> list = new List<T>();

            //Apply eager loading
            foreach (Expression<Func<T, bool>> navigationProperty in navigationProperties)
                list = _dbContext.Set<T>().Where(navigationProperty.Compile()).ToList();

            return list;
        }

        public async Task<bool> Update(string id, T data)
        {
            throw new NotImplementedException();
        }
        #endregion
    }
}
