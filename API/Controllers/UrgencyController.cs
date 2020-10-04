using Hff.JobTracking.Business.Abstract;
using Hff.JobTracking.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace API.Controllers
{
    public class UrgencyController : ApiController
    {
        IUrgencyService _urgencyService;
        public UrgencyController(IUrgencyService urgencyService)
        {
            _urgencyService = urgencyService;
        }
        // GET: api/Urgency
        public IEnumerable<Urgency> Get()
        {
            return _urgencyService.GetUrgencies();
        }

        // GET: api/Urgency/5
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/Urgency
        public void Post([FromBody]string value)
        {
        }

        // PUT: api/Urgency/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/Urgency/5
        public void Delete(int id)
        {
        }
    }
}
