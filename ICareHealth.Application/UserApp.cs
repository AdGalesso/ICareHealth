using EZServiceLocation;
using ICareHealth.Application.Interface;
using ICareHealth.Domain;
using ICareHealth.Repository.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ICareHealth.Application
{
    public class UserApp : IUserApp
    {
        public IUserRepo userRepo { get; set; }

        public UserApp()
        {
            userRepo = null;
        }

        public void Save(User user)
        {
            if (user.IsValid())
                userRepo.Save(user);
        }

        public IList<User> GetAll()
        {
            userRepo = ServiceLocator.Current.GetService<IUserRepo>();

            return userRepo.GetAll();
        }
    }
}
