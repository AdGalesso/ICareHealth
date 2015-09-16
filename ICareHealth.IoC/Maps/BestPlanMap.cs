using EZServiceLocation;
using ICareHealth.Application;
using ICareHealth.Application.Interface;
using ICareHealth.Repository;
using ICareHealth.Repository.Interfaces;

namespace ICareHealth.IoC.Maps
{
    public class BestPlanMap : ServiceMap
    {
        public override void Load()
        {
            For<IPlanApp>().Use<PlanApp>();
            For<IUserApp>().Use<UserApp>();
            For<IBestPlanApp>().Use<BestPlanApp>(new ConstructorDependency(typeof(IUserApp), typeof(IPlanApp)));
            For<IUserRepo>().Use<UserRepo>();
        }
    }
}
