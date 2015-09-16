using ICareHealth.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ICareHealth.Repository.Interfaces
{
    public interface IUserRepo
    {
        void Save(User user);

        IList<User> GetAll();
    }
}
