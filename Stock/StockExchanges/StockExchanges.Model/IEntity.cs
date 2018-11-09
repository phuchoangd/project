using System;
using System.Collections.Generic;
using System.Text;

namespace StockExchanges.Model
{
    public interface IEntity<T>
    {
        T Id { get; set; }
    }
}
