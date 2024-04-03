using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace University
{
    public interface IReadFile<T>
    {
        public List<T> readList();
        public T readObject();
    }
}
