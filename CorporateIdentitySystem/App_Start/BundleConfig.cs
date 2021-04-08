using System.Web;
using System.Web.Optimization;

namespace CorporateIdentitySystem
{
    public class BundleConfig
    {
        // 如需統合的詳細資訊，請瀏覽 https://go.microsoft.com/fwlink/?LinkId=301862
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new ScriptBundle("~/bundles/jquery").Include(
                        "~/Scripts/jquery-{version}.js"));

            bundles.Add(new ScriptBundle("~/bundles/jqueryval").Include(
                        "~/Scripts/jquery.validate*"));

            bundles.Add(new ScriptBundle("~/bundles/bootstrap").Include(
                      "~/Scripts/bootstrap.bundle.js"));

            bundles.Add(new StyleBundle("~/Content/bootstrap").Include(
                    "~/Content/vendor/bootstrap.min.css"));

            bundles.Add(new StyleBundle("~/Content/css").Include(
                    "~/Content/layout.min.css"));
        }
    }
}
