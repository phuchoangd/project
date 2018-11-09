using StockExchanges.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace StockExchanges.Service
{
    public interface IEntityService<T> : IService where T : BaseEntity
    {
        void Create(T entity);
        void Delete(T entity);
        IEnumerable<T> GetAll();
        void Update(T entity);
    }
}
