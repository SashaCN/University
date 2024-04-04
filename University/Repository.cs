using Newtonsoft.Json;

namespace University
{
    public class Repository<T> //: IRepository<T>
    {
        private static string _filePath = "Database\\";
        private static Repository<T> _instance;

        public Repository(string path)
        {
            _filePath += path;
        }

        public static Repository<T> GetRepo(string path)
        {
            if (_instance == null)
                _instance = new Repository<T>(path);
            return _instance;
        }

        public List<T> GetAll(Func<T, bool> filter = null)
        {

            try
            {
                var result = new List<T>();
                string[] lines = File.ReadAllLines(_filePath);
                foreach (string line in lines)
                {
                    T item = JsonConvert.DeserializeObject<T>(line);
                    if (filter == null || filter(item))
                    {
                        result.Add(item);
                    }
                }

                return result;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error while reading file: {ex.Message}");
                return null;
            }
        }


        public T GetOne()
        {
            try
            {
                string line = File.ReadAllText(_filePath);
                T item = JsonConvert.DeserializeObject<T>(line);
                return item;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error while reading file: {ex.Message}");
                return default;
            }
        }


        public void Create(T entity)
        {
            try
            {
                string json = JsonConvert.SerializeObject(entity, Newtonsoft.Json.Formatting.Indented);
                File.AppendAllText(_filePath, json);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error while writing file: {ex.Message}");
            }
        }
    }
}
