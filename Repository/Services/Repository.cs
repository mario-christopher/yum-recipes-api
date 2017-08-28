using System;
using System.Collections.Generic;
using System.Linq;
using Repository.Models;

namespace Repository.Services
{
    public class Repository<T> : IRepository<T> where T : BaseModel
    {
        protected YumRecipeDB _ctx;

        public Repository(YumRecipeDB ctx)
        {
            this._ctx = ctx;
        }

        public IEnumerable<T> GetList()
        {
            return this._ctx.Set<T>().AsEnumerable();
        }

        public T GetOne(int id)
        {
            return this._ctx.Set<T>().Find(id);
        }

        public T Save(T toSave)
        {
            if (toSave.ID == 0)
            {
                this._ctx.Add(toSave);
                toSave.CreatedBy = 0;
                toSave.CreatedDate = DateTime.Now;
            }
            toSave.ModifiedBy = 0;
            toSave.ModifiedDate = DateTime.Now;
            this._ctx.SaveChanges();
            return toSave;
        }

        public void Delete(T toDelete)
        {
            this._ctx.Remove(toDelete);
            this._ctx.SaveChanges();
        }
    }
}