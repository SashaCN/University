using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using University.Models;

namespace University
{
    public class FileController<T> : IFile<T>
    {
        string IFile<T>.FilePath { get; set; } = "Database\\";

        public FileController (string file)
        {
            ((IFile<T>)this).FilePath += file;
        }

        List<T> IFile<T>.read()
        {
            using (FileStream fs = new FileStream(((IFile<T>)this).FilePath, FileMode.OpenOrCreate))
            {
                return JsonSerializer.Deserialize<List<T>>(fs);
            }
        }

        void IFile<T>.write(List<T> list)
        {
            using (FileStream fs = new FileStream(((IFile<T>)this).FilePath, FileMode.OpenOrCreate))
            {
                JsonSerializer.Serialize<List<T>>(fs, list);
            }
        }
    }
}
