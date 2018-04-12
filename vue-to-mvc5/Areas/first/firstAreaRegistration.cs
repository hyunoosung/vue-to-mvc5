using System.Web.Mvc;

namespace vue_to_mvc5.Areas.first
{
    public class firstAreaRegistration : AreaRegistration 
    {
        public override string AreaName 
        {
            get 
            {
                return "first";
            }
        }

        public override void RegisterArea(AreaRegistrationContext context) 
        {
            context.MapRoute(
                "first_default",
                "first/{controller}/{action}/{id}",
                new { action = "Index", id = UrlParameter.Optional }
            );
        }
    }
}