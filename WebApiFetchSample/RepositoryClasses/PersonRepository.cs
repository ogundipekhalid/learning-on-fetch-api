using System.Text.Json;
using WebApiFetchSample.Entity;
using WebApiFetchSample.Interface;

namespace WebApiFetchSample.RepositoryClasses
{
    public partial class PersonRepository : IRepository<person>
    {
        private string GetPeopleFromFlile()
        {
            string ret = string.Empty;
            string fileName = Directory.GetCurrentDirectory();
            fileName += @"\Assect\people.json";
            if(File.Exists(fileName))
                ret = File.ReadAllText(fileName); 
            return ret;
        }
         public bool Delete(int id)
        {
            throw new NotImplementedException();
        }

        public List<person> Get()
        {
            throw new NotImplementedException();
        }

        public person? Get(int id)
        {
            throw new NotImplementedException();
        }

        public person? insert(person entity)
        {
            throw new NotImplementedException();
        }

        public person? update(person entity)
        {
            throw new NotImplementedException();
        }
    }
}
