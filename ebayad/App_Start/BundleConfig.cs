using System.Web;
using System.Web.Optimization;

namespace ebayad
{
    public class BundleConfig
    {
        // For more information on Bundling, visit http://go.microsoft.com/fwlink/?LinkId=254725
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.IgnoreList.Clear();

            bundles.Add(new ScriptBundle("~/bundles/common").Include(

                "~/Content/themes/light/js/jquery.min.js",
                "~/Content/themes/light/js/popper.min.js",
                "~/Content/themes/light/js/moment.min.js",
                "~/Content/themes/light/js/bootstrap.min.js",
                "~/Content/themes/light/js/simplebar.min.js",

                "~/Content/themes/light/js/daterangepicker.js",
                "~/Content/themes/light/js/jquery.stickOnScroll.js",
                "~/Content/themes/light/js/tinycolor-min.js",
                "~/Content/themes/light/js/config.js",
                "~/Content/themes/light/js/apps.js",
                "~/Content/themes/light/js/gtag.js"
                ));

            bundles.Add(new StyleBundle("~/Content/css").Include(
                "~/Content/themes/light/css/simplebar.css",
                "~/Content/themes/light/css/feather.css",
                "~/Content/themes/light/css/daterangepicker.css"
                ));


            bundles.Add(new ScriptBundle("~/bundles/modernizr").Include(
                        "~/Scripts/modernizr-*"));
           
        }
    }
}