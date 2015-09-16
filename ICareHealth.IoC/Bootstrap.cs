using EZServiceLocation;
using ICareHealth.IoC.Maps;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ICareHealth.IoC
{
    public static class Bootstrap
    {
        public static void MapAll()
        {
            ServiceLocator.Current.LoadServiceMap<BestPlanMap>();
        }
    }
}
