using SOLIDPrinciple.Models.ContextArea;
using SOLIDPrinciple.Repository.SystemManager;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace SOLIDPrinciple.Repository
{
    public class GenericRepository<TEntity> : IGenericRepository<TEntity> where TEntity : class
    {
        private readonly SOLIDPrincipleDbContext dbContext;
        private readonly DbSet<TEntity> entities;
        public GenericRepository()
        {
            dbContext = new SOLIDPrincipleDbContext();
            entities = dbContext.Set<TEntity>();
        }
        public TEntity AddEntity(TEntity entity)
        {
            try
            {
                return entities.Add(entity);
            }
            catch (Exception ex)
            {
                Helper.Text(ex.Message);
                return entity;
            }
        }

        public EntityState EditEntity(TEntity entity)
        {
            try
            {
                return dbContext.Entry(entity).State = EntityState.Modified;
            }
            catch (Exception ex)
            {
                Helper.Text(ex.Message);
                return EntityState.Unchanged;
            }
        }

        public IEnumerable<TEntity> GetAll(Expression<Func<TEntity, bool>> expression)
        {
            try
            {
                return entities.ToList();
            }
            catch (Exception ex)
            {
                Helper.Text(ex.Message);
                return new List<TEntity>();
            }
        }

        public IEnumerable<TEntity> GetFilterRecord(Expression<Func<TEntity, bool>> expression)
        {
            try
            {
                return entities.Where(expression).ToList();
            }
            catch (Exception ex)
            {
                Helper.Text(ex.Message);
                return new List<TEntity>();
            }
        }

        public TEntity GetFirstOrDefault(Expression<Func<TEntity, bool>> expression)
        {
            try
            {
                return entities.FirstOrDefault(expression);
            }
            catch (Exception ex)
            {
                Helper.Text(ex.Message);
                return new List<TEntity>().FirstOrDefault();
            }
        }

        public TEntity GetLastOrDefault(Expression<Func<TEntity, bool>> expression)
        {
            try
            {
                return entities.LastOrDefault(expression);
            }
            catch (Exception ex)
            {
                Helper.Text(ex.Message);
                return new List<TEntity>().FirstOrDefault();
            }
        }

        public bool IsExist(Expression<Func<TEntity, bool>> expression)
        {
            try
            {
                return entities.Any(expression);
            }
            catch (Exception ex)
            {
                Helper.Text(ex.Message);
                return false;
            }
        }

        public EntityState RemoveEntity(TEntity entity)
        {
            try
            {
                return dbContext.Entry(entity).State = EntityState.Deleted;
            }
            catch (Exception ex)
            {
                Helper.Text(ex.Message);
                return EntityState.Unchanged;
            }
        }

        public int SaveToDatabase()
        {
            try
            {
                return dbContext.SaveChanges();
            }
            catch (Exception ex)
            {
                Helper.Text(ex.Message);
                return 0;
            }
        }
    }
}
