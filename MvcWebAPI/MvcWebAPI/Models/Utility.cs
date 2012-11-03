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

            //pl.Projectss.Add(new Project() {  Job_Name = "abc", Description = "nothing" });
            //pl.Projectss.Add(new Project() { Job_ID = 2, Job_Name = "abc2", Description = "nothing" });
            //pl.Projectss.Add(new Project() { Job_Name = "abc3", Description = "nothing" });


            pl.Items.Add(new Project() { Job_Name = "abc", Description = "nothing" , Current = null});
            pl.Items.Add(new Project() { Job_ID = 2, Job_Name = "abc2", Description = "nothing", Current = null });
            pl.Items.Add(new Project() { Job_Name = "abc3", Description = "nothing", Current = null });
            return pl;
        }
    }

    public class ProjectList
    {
       
        public int Start { get; set; }
        public List<Project> Items = new List<Project>();
        public int Count { get; set; }
             //public List<Project> Projectss = new List<Project>();
        public int Total { get; set; }
        

    }
}