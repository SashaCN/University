using System.Text.Json;

namespace University
{
    public class FileController<T> : IFile<T>
    {
        string IFile<T>.FilePath { get; set; } = "Database\\";

        public FileController(string file)
        {
            ((IFile<T>)this).FilePath += file;
        }

        List<T> IFile<T>.readList()
        {
            List<T> list = new List<T>();

            try
            {
                using (FileStream fs = new FileStream(((IFile<T>)this).FilePath, FileMode.Open, FileAccess.Read))
                {
                    list = JsonSerializer.Deserialize<List<T>>(fs);
                }
            }
            catch (Exception)
            {
                list = new List<T>();
            }

            return list;
        }

        T IFile<T>.readObject()
        {
            using (FileStream fs = new FileStream(((IFile<T>)this).FilePath, FileMode.Open, FileAccess.Read))
            {
                return JsonSerializer.Deserialize<T>(fs);
            }
        }

        void IFile<T>.writeList(List<T> list)
        {
            using (FileStream fs = new FileStream(((IFile<T>)this).FilePath, FileMode.OpenOrCreate))
            {
                JsonSerializer.Serialize<List<T>>(fs, list);
            }
        }

        void IFile<T>.writeObject(T obj)
        {
            using (FileStream fs = new FileStream(((IFile<T>)this).FilePath, FileMode.OpenOrCreate))
            {
                JsonSerializer.Serialize<T>(fs, obj);
            }
        }
    }
}
