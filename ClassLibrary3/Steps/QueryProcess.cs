using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;
using System.Reflection;

namespace ClassLibrary3.Steps
{


    public class QueryProcess
    {     
    

public static string GetQuery(String Query)
        {
            string val="";

            Queries myInstance = new Queries();
            Type myType = typeof(Queries);
            FieldInfo[] myFields = myType.GetFields(BindingFlags.Public | BindingFlags.Instance);
            
            for (int i = 0; i < myFields.Length; i++)
            {
                if (myFields[i].Name.ToString().Equals(Query))
                    {
                    Console.WriteLine(myFields[i].GetValue(myInstance));
                     val = myFields[i].GetValue(myInstance).ToString();
                   }
            }


            return val;
        }

      

    }

   
    
}
