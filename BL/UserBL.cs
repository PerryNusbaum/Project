using IBL;
using IDAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL
{

    public class UserBL : IUserBL
    {
        private readonly IUserDAL userDAL;
        public UserBL(IUserDAL _userDal) {
            userDAL = _userDal;
        }
        public bool Add(object user)
        {
            if (user != null)
            {
                return userDAL.Add(user);
            }
            return false;
        }

        public bool Delete(int id)
        {
            return userDAL.DeleteById(id);
        }

        public List<object> GetAll()
        {
            return userDAL.GetAll();
        }

        public object GetById(int id)
        {
            return userDAL.GetById(id);
        }

        public bool Update(object user)
        {
            return userDAL.UpdateById(user);
        }
    }
}
