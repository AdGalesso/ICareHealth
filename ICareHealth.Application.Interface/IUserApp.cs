using ICareHealth.Domain;
using ICareHealth.Repository.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ICareHealth.Application.Interface
{
    public interface IUserApp
    {
        IUserRepo userRepo { get; set; }

        void Save(User user);

        IList<User> GetAll();
    }
}
