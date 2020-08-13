using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary3.UpdatedBody
{
    class UpdatedBodyProcess
    {
        public static string GetQuery(String updatedBody)
        {
            string val = "";

            Updatedbody myInstance = new Updatedbody();
            Type myType = typeof(Updatedbody);
            FieldInfo[] myFields = myType.GetFields(BindingFlags.Public | BindingFlags.Instance);

            for (int i = 0; i < myFields.Length; i++)
            {
                if (myFields[i].Name.ToString().Equals(updatedBody))
                {
                    Console.WriteLine(myFields[i].GetValue(myInstance));
                    val = myFields[i].GetValue(myInstance).ToString();
                }
            }


            return val;
        }



    }
}

