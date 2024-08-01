namespace IBL;

public interface IUserBL
{
    public bool Add(object user);
    public bool Update(object user);
    public bool Delete(int id);
    public object GetById(int id);
    public List<object> GetAll();
}
