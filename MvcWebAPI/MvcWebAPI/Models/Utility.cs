using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MvcWebAPI.Models
{
    public class Utility
    {

        public static ProjectList GetProject()
        {
            ProjectList pl = new ProjectList();
            pl.Count = 10;
            pl.Start =1;
            pl.Total = 500;

            pl.Projects.Add(new Project() { Job_ID = 1, Job_Name = "abc", Description = "nothing" });
            pl.Projects.Add(new Project() { Job_ID = 2, Job_Name = "abc2", Description = "nothing" });
            pl.Projects.Add(new Project() { Job_ID = 3, Job_Name = "abc3", Description = "nothing" });

            return pl;
        }
    }

    public class ProjectList
    {
        public List<Project> Projects = new List<Project>();
        public int Start { get; set; }
        public int Count { get; set; }
        public int Total { get; set; }
        

    }
}