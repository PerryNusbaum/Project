using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public interface ICRUD<T>
    {
        List<T> GetAll(Func<T, bool>? condition = null);
        T GetItemByID(int id);
        int AddItem(T item);
        bool DeleteItemByID(int id);
        bool UpdateItemByID(T item);

    }
}
