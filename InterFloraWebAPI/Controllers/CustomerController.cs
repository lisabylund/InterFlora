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
        /// <summary>
        /// Add new customer to Dynamics CRM
        /// </summary>
        /// <param name="customer">Customer Model</param>
        /// <remarks>Insert new customer to CRM</remarks>
        /// <response code="400">Bad request</response>
        /// <response code="500">Internal Server Error</response>
        public HttpResponseMessage Post([FromBody]Customer customer)
        {
            customer.TimeSent = DateTime.Now;
            return Request.CreateResponse(HttpStatusCode.OK, customer);
        }

        // PUT api/customer/5
        // POST api/customer
        /// <summary>
        /// Update customer in Dynamics CRM
        /// </summary>
        /// <param name="customer">Customer Model</param>
        /// <remarks>Update customer in Dynamics CRM</remarks>
        /// <response code="400">Bad request</response>
        /// <response code="500">Internal Server Error</response>
        public HttpResponseMessage Put([FromBody]Customer customer)
        {
            customer.TimeUpdated = DateTime.Now;
            return Request.CreateResponse(HttpStatusCode.OK, customer);
        }

    }
}
