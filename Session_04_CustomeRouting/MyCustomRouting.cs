using Microsoft.AspNetCore.Routing;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Session_04_CustomeRouting
{
    public class MyCustomRouting : IRouter
    {
        private IRouter _defaultRouter;

        public MyCustomRouting(IRouter router)
        {
            _defaultRouter = router;
        }

        /// <summary>
        /// Generate New Address
        /// </summary>
        /// <param name="context"></param>
        /// <returns></returns>
        public VirtualPathData GetVirtualPath(VirtualPathContext context)
        {
            return _defaultRouter.GetVirtualPath(context);
        }

        /// <summary>
        /// Get Urls
        /// </summary>
        /// <param name="context"></param>
        /// <returns></returns>
        public async Task RouteAsync(RouteContext context)
        {
            var path = context.HttpContext.Request.Path.Value;
            if (path.Contains(".aspx"))
            {
                var pathArrey = context.HttpContext.Request.Path.Value.Split('/');
                if (pathArrey.Length == 3)
                {
                    context.RouteData.Values["controller"] = pathArrey[1];
                    context.RouteData.Values["action"] = pathArrey[2].Split('.')[0];
                }
                else if (pathArrey.Length==2)
                {
                    context.RouteData.Values["controller"] = "Home";
                    context.RouteData.Values["action"] = pathArrey[1].Split('.')[0];
                }
                else
                {
                    context.RouteData.Values["controller"] = "Home";
                    context.RouteData.Values["action"] = "index";
                }
            }

                

                await _defaultRouter.RouteAsync(context);
            
        }
    }


}
