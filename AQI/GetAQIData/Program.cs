using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Net;
using System.IO;
using System.Timers;

namespace GetAQIData
{
    class Program
    {        
        static void Main(string[] args)
        {
            GetOriginalData god = new GetOriginalData();
            god.Start();
            ExtractData extract = new ExtractData();
            extract.Start();
            Console.ReadLine();
        }
    }
}
