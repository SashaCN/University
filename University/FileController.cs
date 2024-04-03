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

        List<T> IReadFile<T>.readList()
        {
            var list = new List<T>();

            try
            {
                using var fs = new FileStream(((IFile<T>)this).FilePath, FileMode.Open, FileAccess.Read);
                list = JsonSerializer.Deserialize<List<T>>(fs);
            }
            catch (Exception)
            {
                list = [];
            }

            return list;
        }

        T IReadFile<T>.readObject()
        {
            using var fs = new FileStream(((IFile<T>)this).FilePath, FileMode.Open, FileAccess.Read);
            return JsonSerializer.Deserialize<T>(fs);
        }

        void IWriteFile<T>.writeList(List<T> list)
        {
            using var fs = new FileStream(((IFile<T>)this).FilePath, FileMode.OpenOrCreate);
            JsonSerializer.Serialize(fs, list);
        }

        void IWriteFile<T>.writeObject(T obj)
        {
            using var fs = new FileStream(((IFile<T>)this).FilePath, FileMode.OpenOrCreate);
            JsonSerializer.Serialize(fs, obj);
        }
    }
}
