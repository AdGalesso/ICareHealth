using System.Web;
using System.Web.Optimization;

namespace ICareHealth.Web
{
    public class BundleConfig
    {
        // For more information on bundling, visit http://go.microsoft.com/fwlink/?LinkId=301862
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new ScriptBundle("~/bundles/modernizr").Include(
                        "~/Scripts/modernizr-*"));

            bundles.Add(new StyleBundle("~/Content/css").Include(
                      "~/Content/bootstrap.css",
                      "~/Content/site.css"));

            bundles.Add(new StyleBundle("~/Content/fontawesome").Include(
                    "~/Content/font-awesome.min.css"));

            bundles.Add(new ScriptBundle("~/bundles/bestplan").Include(
                "~/Scripts/user.controller.js"));
        }
    }
}
