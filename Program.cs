using System;
using Microsoft.CodeAnalysis.CSharp.Scripting;

namespace APIMonitor
{
    class Program
    {
        string inputfile = string.Empty;
        string outputfile = string.Empty;
        
        static async System.Threading.Tasks.Task Main(string[] args)
        {

            //var status =new CreateHtml().CreateHTMLMonitor(".//Files//reponsemonitor.json","ApiMonitor.html");
            User user = new User();
            user.id = "anju";
            user.email ="sandeep";
            string url = "https://{user.id}/{user.email}/2";
            string url1 = "https://{name}/2";

                var result = await CSharpScript.EvaluateAsync<string>(
    "var name = \"" + user + "\"; " +
    "return $\"" + url + "\";");

            
            Console.WriteLine(result);

        }

       

    }

    public class User{
             public string id = "1234";
             public string email = "sandeepsekhar555";
    }

   
}
