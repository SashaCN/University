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

        public void write(List<T> list);
        public List<T> read();
    }
}
