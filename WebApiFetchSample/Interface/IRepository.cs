namespace WebApiFetchSample.Interface
{
    public interface IRepository<T> where T : class
    {
        List<T> Get();
        T? Get(int id);
        T? insert(T entity);
        T? update(T entity);
        bool Delete(int id);
    }
}
