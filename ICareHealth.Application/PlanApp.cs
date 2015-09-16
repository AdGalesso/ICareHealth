using ICareHealth.Application.Interface;
using ICareHealth.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ICareHealth.Application
{
    public class PlanApp : IPlanApp
    {
        //just a fake ok?!
        public IList<Plan> GetAll()
        {
            var list = new List<Plan>();

            list.Add(new Plan() { Id = 1, Name = "Super Clinical", Value = 1300 });
            list.Add(new Plan() { Id = 2, Name = "Everyday Care", Value = 750 });
            list.Add(new Plan() { Id = 3, Name = "My Way Care", Value = 500 });
            list.Add(new Plan() { Id = 4, Name = "Basic Clinical", Value = 200 });
            list.Add(new Plan() { Id = 5, Name = "Baby Care", Value = 400 });

            return list;
        }
    }
}
