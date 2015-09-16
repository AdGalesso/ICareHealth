using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ICareHealth.Domain
{
    public class User : Base<Guid>
    {
        public string Name { get; set; }

        public int BirthYear { get; set; }

        public int Age { get { return DateTime.Now.Year - BirthYear; } }

        public string Gender { get; set; }

        public Plan Plan { get; set; }

        public User()
        {
            BirthYear = DateTime.Now.Year;
            Plan = new Plan();
        }

        public bool IsValid()
        {
            return !string.IsNullOrEmpty(Name) && Age >= 0 && (Gender == "M" || Gender == "F");
        }

        /// <summary>
        /// Method to find a plan
        /// More then 3 names we will consider to be a rich person =)
        /// </summary>
        /// <param name="plans">The list of plans from 'database'</param>
        public void SearchBestPlan(IList<Plan> plans)
        {
            var personNames = Name.Split(' ').Count();

            if (Age < 10)
            {
                Plan = personNames > 3 ? plans.First() : plans.Last();
            }
            else if (personNames > 3)
            {
                if (Age > 60)
                    Plan = Gender == "M" ? plans[1] : plans.First();
                else
                    Plan = Gender == "M" ? plans[2] : plans[1];
            }
            else
            {
                if (Age > 50)
                    Plan = Gender == "M" ? plans[3] : plans[2];
                else
                    Plan = plans[3];
            }
        }
    }
}
