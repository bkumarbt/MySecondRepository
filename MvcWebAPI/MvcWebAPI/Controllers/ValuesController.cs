using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using MvcWebAPI.Models;

namespace MvcWebAPI.Controllers
{
    public class ProjectController : ApiController
    {
        // GET api/values
        [Queryable]
        public IQueryable<Project> Get()
        {
            ProjectRepository repository = new ProjectRepository();
            return repository.Projects.AsQueryable(); ;
           // return Utility.GetProject();

        }

        // GET api/values/5
        public Project Get(int id)
        {
            // Changes done by bharat
            return new Project() {  Job_ID=1,Job_Name="Bharat", Description="Kumar"};
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