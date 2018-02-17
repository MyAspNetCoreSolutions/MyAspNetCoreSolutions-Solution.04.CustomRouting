using Microsoft.AspNetCore.Routing;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Session_04_CustomeRouting
{
    public class MyCustomRouting : IRouter
    {
        /// <summary>
        /// Generate New Address
        /// </summary>
        /// <param name="context"></param>
        /// <returns></returns>
        public VirtualPathData GetVirtualPath(VirtualPathContext context)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Get Urls
        /// </summary>
        /// <param name="context"></param>
        /// <returns></returns>
        public Task RouteAsync(RouteContext context)
        {
            throw new NotImplementedException();
        }
    }
}
