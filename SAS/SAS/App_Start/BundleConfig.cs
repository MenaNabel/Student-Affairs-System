using System.Web;
using System.Web.Optimization;

namespace SAS
{
    public class BundleConfig
    {
        // For more information on bundling, visit https://go.microsoft.com/fwlink/?LinkId=301862
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new ScriptBundle("~/bundles/jquery").Include(
                        "~/Scripts/jquery-{version}.js"));

            bundles.Add(new ScriptBundle("~/mybundles/jquery").Include(
            "~/Scripts/myScripts/jquery-3.2.1.min.js" ,
            "~/Scripts/myScripts/jquery-migrate-3.0.0.js",
            "~/Scripts/myScripts/popper.min.js",
            "~/Scripts/myScripts/owl.carousel.min.js",
            "~/Scripts/myScripts/jquery.waypoints.min.js",
            "~/Scripts/myScripts/jquery.stellar.min.js",
            "~/Scripts/myScripts/jquery.animateNumber.min.js",
            "~/Scripts/myScripts/jquery.magnific-popup.min.js",
            "~/Scripts/myScripts/main.js" ,
            "~/Scripts/myScripts/mainTable.js"

            ));



            bundles.Add(new ScriptBundle("~/bundles/jqueryval").Include(
                        "~/Scripts/jquery.validate*"));

            // Use the development version of Modernizr to develop with and learn from. Then, when you're
            // ready for production, use the build tool at https://modernizr.com to pick only the tests you need.
            bundles.Add(new ScriptBundle("~/bundles/modernizr").Include(
                        "~/Scripts/modernizr-*"));

            bundles.Add(new ScriptBundle("~/bundles/bootstrap").Include(
                      "~/Scripts/bootstrap.js"));

            bundles.Add(new ScriptBundle("~/bundles/mybootstrap").Include(
                      "~/Scripts/myScripts/bootstrap.min.js"));

            bundles.Add(new StyleBundle("~/Content/css").Include(
                      "~/Content/bootstrap.css",
                      "~/Content/site.css" ,
                      "~/Content/myContent/style.css"));
            bundles.Add(new StyleBundle("~/Content/CustomStyle").Include(
                "~/Content/myContent/bootstrap.css" ,
                "~/Content/myContent/animate.css",
                "~/Content/myContent/owl.carousel.min.css",
                "~/Content/myContent/style.css" 
                //"~/Content/myContent/mainTable.css"
                ));
            bundles.Add(new StyleBundle("~/Content/ErrorStyle").Include(
                "~/Content/Errors/style.css"
                ));
        }
    }
}
