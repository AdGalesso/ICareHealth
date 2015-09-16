using ICareHealth.Domain;
using ICareHealth.Repository.Context;
using ICareHealth.Repository.Interfaces;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ICareHealth.Repository
{
    public class UserRepo : IUserRepo
    {
        public void Save(User user)
        {
            user.Id = Guid.NewGuid();
            user.Save = user.Plan.Save = DateTime.Now;

            using (var context = new UserContext())
            {
                context.TBUser.Add(user);
                context.SaveChanges();
            }
        }

        public IList<User> GetAll()
        {
            using (var context = new UserContext())
            {
                return (from u in context.TBUser.Include("Plan")
                        orderby u.Save descending
                        select u).ToList();
            }
        }
    }
}
