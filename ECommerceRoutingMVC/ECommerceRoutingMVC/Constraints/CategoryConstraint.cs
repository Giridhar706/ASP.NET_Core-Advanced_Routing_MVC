using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Routing;

namespace ECommerceRoutingMVC.Constraints
{
    public class CategoryConstraint : IRouteConstraint
    {
        private readonly string[] validCategories =
        {
            "electronics",
            "fashion",
            "books"
        };

        public bool Match(
            HttpContext httpContext,
            IRouter route,
            string routeKey,
            RouteValueDictionary values,
            RouteDirection routeDirection)
        {
            if (values.ContainsKey(routeKey))
            {
                string category =
                    values[routeKey].ToString().ToLower();

                return validCategories.Contains(category);
            }

            return false;
        }
    }
}