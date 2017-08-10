using System.Web.Http;
using System.Web.OData.Builder;
using System.Web.OData.Extensions;
using FGOData.Models.Serialization;

namespace FGOData
{
    public static class WebApiConfig
    {
        public static void Register(HttpConfiguration config)
        {
            ODataModelBuilder builder = new ODataConventionModelBuilder();
            builder.EntitySet<Servant>("Servants");
            config.MapODataServiceRoute(
                routeName: "ODataRoute",
                routePrefix: null,
                model: builder.GetEdmModel());
        }
    }
}
