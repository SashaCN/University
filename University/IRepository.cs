using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace University
{
    internal interface IRepository<T> where T : class
    {
        List<T> GetAll(Func<T, bool> filter = null);
        T GetOne();
        void Create(T entity);
    }
}
