﻿using System;

namespace APIMonitor
{
    class Program
    {
        string inputfile = string.Empty;
        string outputfile = string.Empty;
        
        static void Main(string[] args)
        {
            
            var status =new CreateHtml().CreateHTMLMonitor(".//Files//reponsemonitor.json","ApiMonitor.html");
        }

    }
}
