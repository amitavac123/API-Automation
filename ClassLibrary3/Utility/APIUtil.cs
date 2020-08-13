using System;
using System.Linq;
using System.Text;
using Newtonsoft.Json.Linq;
using System.Collections;
using System.IO;
using System.Text.RegularExpressions;
using TechTalk.SpecFlow;
using ClassLibrary3.Steps;
using System.Runtime.InteropServices;
using Newtonsoft.Json;
using System.Collections.Generic;
using NUnit.Framework;
using System.Runtime.Remoting;

namespace ClassLibrary3.Utility
{
    class APIUtil
    {

        // Process Request object class with modified filed parameter provided in data set

        public static string CallServiceWithModifiedParameter(Table table, string json)
        {

            dynamic data= JsonConvert.DeserializeObject(json);
             for (int i = 0; i <= table.Rows.Count - 1; i++)
            {
                var Veriable = table.Rows[i][0];
                var Value = table.Rows[i][1];
                data.Property(Veriable).Value = Value;

            }
            var json1 = Newtonsoft.Json.JsonConvert.SerializeObject(data);

            return json1;

        }


     
    }
}