using InterFloraWebAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace InterFloraWebAPI.Controllers
{
    public class OrderController : ApiController
    {
        /// <summary>
        /// Add new order
        /// </summary>
        /// <param name="order">Order Model</param>
        /// <remarks>Insert new order</remarks>
        /// <response code="400">Bad request</response>
        /// <response code="500">Internal Server Error</response>
        public HttpResponseMessage Post([FromBody]Order order)
        {
            order.TimeSent = DateTime.Now;
            return Request.CreateResponse(HttpStatusCode.OK, order);
        }
    }
}
