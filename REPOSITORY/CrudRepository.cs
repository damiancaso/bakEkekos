using EKEKOSDATABASEMODEL;
using Microsoft.EntityFrameworkCore;

namespace REPOSITORY
{
    public class CrudRepository<TEntity> where TEntity : class
    {
        #region DECLARACIÓN DE VARIABLES Y CONSTRUCTOR
        internal _dbEkekos_v01 db;
        //DBSET EN EL ALGUN MOMENTO SERÁ CARGO, PERSONA, COLABORADOR
        internal DbSet<TEntity> dbSet;

        public CrudRepository()
        {
            db = new _dbEkekos_v01();
            dbSet = db.Set<TEntity>();
        }

        #endregion DECLARACIÓN DE VARIABLES


        public void Dispose()
        {
            GC.SuppressFinalize(this);
        }

        public TEntity Create(TEntity entity)
        {
            dbSet.Add(entity);
            db.SaveChanges();
            return entity;
        }

        public List<TEntity> CreateMultiple(List<TEntity> lista)
        {
            dbSet.AddRange(lista);
            db.SaveChanges();
            return lista;
        }

        //object puede ser entero, shor, string (tipo de dato primario)
        public int Delete(object id)
        {
            TEntity entityToDelete = dbSet.Find(id);
            dbSet.Remove(entityToDelete);
            return db.SaveChanges();
        }

        public int DeleteMultipleItems(List<TEntity> lista)
        {
            throw new NotImplementedException();
        }



        public List<TEntity> GetAll()
        {
            IQueryable<TEntity> query = dbSet;
            return query.ToList();
        }

        public TEntity GetById(object id)
        {
            return dbSet.Find(id);
        }

        public TEntity Update(TEntity entity)
        {
            dbSet.Update(entity);
            db.SaveChanges();
            return entity;
        }

        public List<TEntity> UpdateMultiple(List<TEntity> lista)
        {
            dbSet.UpdateRange(lista);
            db.SaveChanges();
            return lista;
        }

    }
}
