using System;
using System.Collections.Generic;
using Repository.Models;

namespace Repository.Services
{
    public interface IRepository<T> where T : BaseModel
    {
        T GetOne(int id);

        IEnumerable<T> GetList();

        T Save(T toSave);

        void Delete(T toDelete);
    }
}