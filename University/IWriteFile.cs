using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace University
{
    public interface IWriteFile<T>
    {
        public void writeList(List<T> list);
        public void writeObject(T obj);
    }
}
