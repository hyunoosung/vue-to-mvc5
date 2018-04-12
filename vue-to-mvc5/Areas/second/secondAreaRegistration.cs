using System.Web.Mvc;

namespace vue_to_mvc5.Areas.second
{
    public class secondAreaRegistration : AreaRegistration 
    {
        public override string AreaName 
        {
            get 
            {
                return "second";
            }
        }

        public override void RegisterArea(AreaRegistrationContext context) 
        {
            context.MapRoute(
                "second_default",
                "second/{controller}/{action}/{id}",
                new { action = "Index", id = UrlParameter.Optional }
            );
        }
    }
}