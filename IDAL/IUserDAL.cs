namespace IDAL;

public interface IUserDAL
{
    bool Add(object user);
    bool UpdateById(object user);
    bool DeleteById(int id);
    object GetById(int id);
    List<object> GetAll(Func<Object, bool>? condition = null);
}
