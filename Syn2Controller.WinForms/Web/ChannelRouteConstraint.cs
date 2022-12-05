using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Routing;
using System.Globalization;

namespace Syn2Controller.WinForms.Web;

internal class ChannelRouteConstraint : IRouteConstraint
{
    public bool Match(HttpContext? httpContext, IRouter? route, string routeKey, RouteValueDictionary values, RouteDirection routeDirection)
    {
        if (!values.TryGetValue(routeKey, out var routeValue) || routeValue is not string value)
        {
            return false;
        }

        return Constants.ChannelNames.Contains(value, StringComparer.InvariantCultureIgnoreCase);
    }
}
