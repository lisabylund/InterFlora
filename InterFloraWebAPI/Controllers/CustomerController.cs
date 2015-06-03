using InterFloraWebAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace InterFloraWebAPI.Controllers
{
    public class CustomerController : ApiController
    {

        // POST api/customer
        public HttpResponseMessage Post([FromBody]Order order)
        {
            return Request.CreateResponse(HttpStatusCode.OK, order);
        }

        // PUT api/customer/5
        public void Put(int id, [FromBody]string value)
        {
        }

    }
}
