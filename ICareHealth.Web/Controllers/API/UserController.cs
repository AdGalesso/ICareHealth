using EZServiceLocation;
using ICareHealth.Application.Interface;
using ICareHealth.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace ICareHealth.Web.Controllers.API
{
    public class UserController : ApiController
    {
        IBestPlanApp bestPlanApp;
        IUserApp userApp;

        public UserController()
        {
            bestPlanApp = ServiceLocator.Current.GetService<IBestPlanApp>();
            userApp = ServiceLocator.Current.GetService<IUserApp>();
        }

        [HttpGet]
        public object GetAll()
        {
            return userApp.GetAll().Select(u => new
            {
                Name = u.Name,
                Age = u.Age,
                Gender = u.Gender,
                Plan = new
                {
                    u.Plan.Name,
                    u.Plan.Value
                }
            });
        }

        [HttpPut]
        public User GetMyBestPlan(User user)
        {
            return bestPlanApp.GetMyBestPlan(user);
        }
    }
}
