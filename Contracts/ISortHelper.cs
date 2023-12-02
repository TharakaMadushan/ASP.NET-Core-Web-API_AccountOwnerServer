using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Contracts
{
    public interface ISortHelper<T>
    {
        IQueryable<T> ApplySort(IQueryable<T> entities, string orderByQueryString);
    }
}
