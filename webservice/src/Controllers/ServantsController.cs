using FGOData.Models.Data;
using FGOData.Models.Serialization;
using System.Collections.Generic;
using System.Linq;
using System.Web.Http;
using System.Web.OData;

namespace FGOData.Controllers
{
    public class ServantsController : ODataController
    {
        ServantsContext db = new ServantsContext();
        private IList<Servant> _servants = new List<Servant>
        {
            new AltriaPendragonSaber(),
            new SthenoAssassin()
        };


        [EnableQuery]
        public IQueryable<Servant> Get()
        {
            return _servants.AsQueryable();
        }

        [EnableQuery]
        public SingleResult<Servant> Get([FromODataUri] int key)
        {
            IQueryable<Servant> result = _servants.AsQueryable().Where(p => p.Id == key);
            return SingleResult.Create(result);
        }
    }
}