using System;
using System.Collections.Generic;
using System.IO;
using Newtonsoft.Json;
public class CreateHtml{


        public bool CreateHTMLMonitor(string input, string output)
        {
            
            string json = File.ReadAllText(input);
            var _response = JsonConvert.DeserializeObject<List<ResponseClass>>(json);

            string html = File.ReadAllText(".//Files//sample.html");
            string ReplaceHeaderValues = ReplacingHeaderValues(html);
           // string ReplaceContentValues = ReplaceContentValues(ReplaceHeaderValues,_response);


           File.WriteAllText(".//Files//"+output,ReplaceHeaderValues);

            return true;
            
        }

        public string ReplacingHeaderValues(string html)
        {
             string Env = "SIT";
             string Executiontime = DateTime.Now.ToString();
                string ExecutionUser = "chandrs";

                string newstring1 = html.Replace("EnvPlaceHolder",Env);
                string newstring2 = newstring1.Replace("ExecutionTimePlaceHolder",Executiontime);
                string newstring3 = newstring2.Replace("ExecutionUserPlaceHolder",ExecutionUser);
                
                return newstring3;

        }

    // public string ReplaceContentValues(string html,List<ResponseClass> _list)
    //     {
            

    //             string newstring1 = html.Replace("EnvPlaceHolder",Env);
    //             string newstring2 = newstring1.Replace("ExecutionTimePlaceHolder",Executiontime);
    //             string newstring3 = newstring2.Replace("ExecutionUserPlaceHolder",ExecutionUser);
                
    //             return newstring3;

    //     }







}