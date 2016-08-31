using Nancy;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Nancy.ModelBinding;

namespace NancyFXExample
{
    public class RootRoutes : NancyModule
    {
        public RootRoutes()
        {
            /*
            Get["/"] = parameters =>
            {
                return "Hello World";
            };
            Get["jsontest"] = parameters =>
            {
                var test = new
                {
                    Name = "Peter Shaw",
                    Twitter = "shawty_ds",
                    Occupation = "Software Developer"
                };

                return Response.AsJson(test);
           };
            */
            Get["/"] = Index;
            Get["jsontest"] = JsonTest;
            Get["hello/{name}"] = HelloName;
            Post["posttest"] = PostTest;
        }

        private dynamic Index(dynamic parameters)
        {
            return "Jai Jinendra Moni" ;
        }

        private dynamic JsonTest(dynamic parameters)
        {
            var test = new
            {
                Name = "Peter Shaw",
                Twitter = "shawty_ds",
                Occupation = "Software Developer"
            };

            return Response.AsJson(test);
        }
        private dynamic HelloName(dynamic parameters)
        {
            var name = parameters.name;

            return String.Format("Hello there {0}", name);
        }
        private dynamic PostTest(dynamic parameters)
        {
            var myPerson = this.Bind<Person>();
            
            return String.Format("Hello there {0} with twitter handle {1} who works as a {2}", myPerson.Name, myPerson.Twitter, myPerson.Occupation);
        }
    }
     public class Person
   {
      public string Name { get; set; }
      public string Twitter { get; set; }
      public string Occupation { get; set; }
 
   }
}
