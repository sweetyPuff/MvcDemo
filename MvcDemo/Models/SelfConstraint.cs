using System.Web;
using System.Web.Routing;

namespace MvcDemo.Models
{
    public class SelfConstraint : IRouteConstraint
    {
        public bool Match(HttpContextBase httpContext, Route route, string parameterName, RouteValueDictionary values,
            RouteDirection routeDirection)
        {
            var id = values[parameterName] as string;
            return id == "Test";
        }
    }
}