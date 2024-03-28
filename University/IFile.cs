using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using University.Models;

namespace University
{
     public interface IFile<T>
    {
        public string FilePath { get; set; }

        public void writeList(List<T> list);
        public void writeObject(T obj);
        public List<T> readList();
        public T readObject();
    }
}
