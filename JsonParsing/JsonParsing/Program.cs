using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Data;
using Newtonsoft.Json.Linq;

namespace JsonParsing
{
    class Program
    {
        static void Main(string[] args)
        {
            MakeRequest();
        }

        public static string GetJsonString()
        {
            string json = @"{ CPU: 'Intel',Drives: [ 'DVD read/writer','500 gigabyte hard drive' ] }";
            return json;
        }

        public static void MakeRequest()
        {
            string url = @"";
            HttpClient client = new HttpClient();
            //client.BaseAddress = new Uri(url);

            // Add an Accept header for JSON format.
            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
            HttpResponseMessage response = (HttpResponseMessage)client.GetAsync("http://localhost:4681/api/project").Result;

            if (response.IsSuccessStatusCode)
            {
                var pl = response.Content.ReadAsStringAsync().Result;

                Newtonsoft.Json.JsonSerializerSettings setting = new Newtonsoft.Json.JsonSerializerSettings();
                setting.CheckAdditionalContent = false;
                

                DataSet ds = Newtonsoft.Json.JsonConvert.DeserializeObject<DataSet>(pl,setting);



            }
        }

        public class ProjectList
        {
            public List<Project> Projects = new List<Project>();
            public int Start { get; set; }
            public int Count { get; set; }
            public int Total { get; set; }


        }

        public class Project
        {
            public int Job_ID { get; set; }
            public string Job_Name { get; set; }
            public string Description { get; set; }
            public string Descr { get; set; }
        }
    }
}
