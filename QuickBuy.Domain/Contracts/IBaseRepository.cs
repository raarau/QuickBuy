using System;
using System.Collections.Generic;
using System.Text;

namespace QuickBuy.Domain.Contracts
{
    public interface IBaseRepository<TEntity> : IDisposable where TEntity : class
    {
        /// <summary>
        /// Interface que implementa um objeto genérico do tipo TEntity que será responsavel por realizar o CRUD da aplicação. 
        /// </summary>
        /// <param name="entity"></param>
        void Add(TEntity entity);
        TEntity GetToId(int id);
        IEnumerable<TEntity> GetAll();
        void Update(TEntity entity);
        void Delete(TEntity entity);

    }
}
