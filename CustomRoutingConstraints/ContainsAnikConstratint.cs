namespace routing_tut.CustomRoutingConstraints
{
	public class ContainsAnikConstratint : IRouteConstraint
	{
		public bool Match(HttpContext? httpContext, IRouter? route, string routeKey, RouteValueDictionary values, RouteDirection routeDirection)
		{
			if(values.TryGetValue(routeKey, out object passedValue))
			{
				if(passedValue is string stringObj)
				{
					if (stringObj.Contains("anik"))
					{
						return true;
					}
				}
			}
			return false;
		}
	}
}
