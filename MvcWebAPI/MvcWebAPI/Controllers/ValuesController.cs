using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using MvcWebAPI.Models;

namespace MvcWebAPI.Controllers
{
    public class ValuesController : ApiController
    {
        // GET api/values
        public ProjectList Get()
        {
            return Utility.GetProject();
        }

        // GET api/values/5
        public Project Get(int id)
        {
            return new Project();
        }

        // POST api/values
        public void Post(string value)
        {
        }

        // PUT api/values/5
        public void Put(int id, string value)
        {
        }

        // DELETE api/values/5
        public void Delete(int id)
        {
        }
    }
}