using System;
using System.Collections.Generic;
using System.IO;
using Newtonsoft.Json;
public class CreateHtml{

 public string CreateHTMLMonitor(List<ResponseClass> _responseList, string output)
        {
          //I have no idea what this file does
            //string json = File.ReadAllText(input);
            //var _response = JsonConvert.DeserializeObject<List<ResponseClass>>(json);
            
        //     string html = File.ReadAllText(DirectoryHelper.BaseDirectory+ "\\APIMonitor\\APIMonitorPage.html");
        //     string _ReplaceHeaderValues = ReplacingHeaderValues(html);
        //     string _ReplaceContentValues = ReplaceContentValues(_ReplaceHeaderValues, _responseList);
        //     string outputfile = DirectoryHelper.BaseDirectory + "\\APIMonitor\\" + output;

        //     File.WriteAllText(outputfile, _ReplaceContentValues);

        //     return outputfile;

        // }

        // public string ReplacingHeaderValues(string html)
        // {
        //     string Env = "EnvName";
        //     string Executiontime = DateTime.Now.ToString();
        //     string ExecutionUser = "userName";

        //     string newstring1 = html.Replace("EnvPlaceHolder", Env);
        //     string newstring2 = newstring1.Replace("ExecutionTimePlaceHolder", Executiontime);
        //     string newstring3 = newstring2.Replace("ExecutionUserPlaceHolder", ExecutionUser);

        //     return newstring3;

        // }


        //  public string ReplaceContentValues(string html,List<ResponseClass> responseList)
        // {
        //     string value = string.Empty;
        //     int rownum = 1;
            
        //     string replacerows = string.Empty;
        //     string DetailsDiv = string.Empty;


        //     foreach(ResponseClass item in responseList)
        //     {
        //         replacerows = replacerows + "<tr><td>" + item.APIURL + "</td><td>" + item.Status + "</td><td>" + item.StatusCode + "</td><td>" + item.ResponseTime + "</td><td><a id="+ rownum + " href=\"#\" onclick=\"toggleAppearance(this.id);\">ResponseContent</a></td></tr>";
        //         DetailsDiv = DetailsDiv + "<div id=details" + rownum + " class=detailsdiv>" + item.Response+"</div>";
        //         rownum= rownum + 1;
        //     }
       

        //     string newstring = html.Replace("MonitorPlaceHolder", replacerows);
        //     newstring = newstring.Replace("PlaceHolderForDetailsDIV", DetailsDiv);

        //     return newstring;
        return "";

         }

}
