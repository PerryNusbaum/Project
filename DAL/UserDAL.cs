using DAL.Models;
using IDAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using context = DAL.Models._Nusbaum_UserAccountsContext;
namespace DAL
{
    //public class UserDAL : ICRUD<User>
    //{
    //    public int AddItem(User item)
    //    {
    //        try
    //        {
    //            using context ctx = new context();
    //            ctx.Users.Add(item);
    //            ctx.SaveChanges();
    //            return item.UserId;
    //        }
    //        catch
    //        {
    //            throw;
    //        }
    //    }

    //    public bool DeleteItemByID(int id)
    //    {
    //        try
    //        {
    //            using context ctx = new context();
    //            User? item = ctx.Users.Find(id);
    //            if (item != null)
    //            {
    //                ctx.Users.Remove(item);
    //                ctx.SaveChanges();
    //                return true;
    //            }
    //            return false;
    //        }
    //        catch
    //        {
    //            throw;
    //        }
    //    }

    //    public List<User> GetAll(Func<User, bool>? condition = null)
    //    {
    //        try
    //        {
    //            using context ctx = new context();
    //            return condition == null ? ctx.Users.ToList() : ctx.Users.Where(condition).ToList();
    //        }
    //        catch
    //        {
    //            // Console.WriteLine($"Error in GetAll method: {ex.Message}");
    //            throw;
    //        }
    //    }

    //    public User? GetItemByID(int id)
    //    {
    //        try
    //        {
    //            using context ctx = new context();
    //            return ctx.Users.Find(id);
    //        }
    //        catch
    //        {
    //            throw;
    //        }
    //    }

    //    public bool UpdateItemByID(User item)
    //    {
    //        using context ctx = new context();
    //        User? oldItem = ctx.Users.Find(item.UserId);
    //        if (oldItem == null)
    //        {
    //            // User not found
    //            return false;
    //        }
    //        // Update the existing entity with the new values from item
    //        ctx.Entry(oldItem).CurrentValues.SetValues(item);
    //        // Save changes to the database
    //        ctx.SaveChanges();

    //        return true;
    //    }
    //}

    public class UserDAL : IUserDAL
    {
        public bool Add(object user)
        {
            try
            {
                using context ctx = new context();
                ctx.Add(user);
                ctx.SaveChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }

        public bool DeleteById(int id)
        {
            try
            {
                using context ctx = new context();
                User? item = ctx.Users.Find(id);
                if (item != null)
                {
                    ctx.Users.Remove(item);
                    ctx.SaveChanges();
                    return true;
                }
                return false;
            }
            catch
            {
                throw;
            }
        }

        public List<object> GetAll(Func<object, bool>? condition = null)
        {
            try
            {
                using context ctx = new context();
                return condition != null ? ctx.Users.Where(condition).ToList() : ctx.Users.Select(u=>u as object).ToList();
            }
            catch
            {
                return null;
            }
        }

        public object GetById(int id)
        {
            try
            {
                using context ctx = new context();
                return ctx.Users.Find(id);
            }
            catch
            {
                return null;
            }
        }

        public bool UpdateById(object user)
        {
            using context ctx = new context();
            ctx.Users.Attach(user as User);
            ctx.SaveChanges();

            return true;
        }
    }
}

