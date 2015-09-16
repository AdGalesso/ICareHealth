using EZServiceLocation;
using ICareHealth.Application.Interface;
using ICareHealth.Domain;
using ICareHealth.Repository.Interfaces;

namespace ICareHealth.Application
{
    public class BestPlanApp : IBestPlanApp
    {
        public IPlanApp _planApp;
        public IUserApp _userApp;

        public BestPlanApp(IUserApp userApp, IPlanApp planApp)
        {
            _userApp = userApp;
            _planApp = planApp;
        }

        public User GetMyBestPlan(User user)
        {
            var plans = _planApp.GetAll();

            user.SearchBestPlan(plans);
            user.Plan.SetPromotionalValue(user.Age);

            _userApp.userRepo = ServiceLocator.Current.GetService<IUserRepo>();
            _userApp.Save(user);

            return user;
        }
    }
}
