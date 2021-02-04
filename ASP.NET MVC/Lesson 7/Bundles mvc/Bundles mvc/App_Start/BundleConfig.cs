using System.Web;
using System.Web.Optimization;
using System.Web.UI.WebControls;

namespace Bundles_mvc
{
    public class BundleConfig
    {
        // For more information on bundling, visit https://go.microsoft.com/fwlink/?LinkId=301862
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new ScriptBundle("~/bundles/jquery").Include(
                        "~/Scripts/jquery-{version}.js"));

            bundles.Add(new ScriptBundle("~/bundles/jqueryval").Include(
                        "~/Scripts/jquery.validate*"));

            // Use the development version of Modernizr to develop with and learn from. Then, when you're
            // ready for production, use the build tool at https://modernizr.com to pick only the tests you need.
            bundles.Add(new ScriptBundle("~/bundles/modernizr").Include(
                        "~/Scripts/modernizr-*"));

            bundles.Add(new ScriptBundle("~/bundles/bootstrap").Include(
                      "~/Scripts/bootstrap.js"));

            bundles.Add(new StyleBundle("~/Content/css").Include(
                      "~/Content/bootstrap.css",
                      "~/Content/site.css"));

            bundles.Add(new StyleBundle("~/Content/template").Include(
                "~/Content/template/animate.min.css",
                "~/Content/template/jquery-ui.css",
                "~/Content/template/jquery.mCustomScrollbar.min.css",
                "~/Content/template/meanmenu.css",
                "~/Content/template/nice-select.css",
                "~/Content/template/normalize.css",
                "~/Content/template/owl.carousel.min.css",
                "~/Content/template/responsive.css",
                "~/Content/template/slick.css",
                "~/Content/template/style.css"
                ));

            bundles.Add(new ScriptBundle("~/Scripts/template").Include(
                    "~/Scripts/templeate/custom.js",
                       "~/Scripts/templeate/jquery-3.0.0.min.js",
                       "~/Scripts/templeate/jquery.mCustomScrollbar.concat.min.js",
                       "~/Scripts/templeate/jquery.min.js",
                       "~/Scripts/templeate/jquery.validate.js",
                       "~/Scripts/templeate/plugin.js",
                       "~/Scripts/templeate/popper.min.js",
                       "~/url/https:cdnjs.cloudflare.com/ajax/libs/fancybox/2.1.5/jquery.fancybox.min.js"
                ));



        }
    }
}
