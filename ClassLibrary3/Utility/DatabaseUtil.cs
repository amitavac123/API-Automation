using ClassLibrary3.Steps;
using MongoDB.Bson;
using MongoDB.Driver;
using Newtonsoft.Json.Linq;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Data.OleDb;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechTalk.SpecFlow;
using TechTalk.SpecFlow.Assist;

namespace ClassLibrary3.Utility
{
    class DatabaseUtil
    {
        public static string connetionString;
        public static MongoClient dbClient;
        private static object db;
        private static object columnName;

        public static void setClient(string DBName)
        {
            try
            {
                switch (DBName)
                {
                    case "\"WELLSFARGO\"":

                        MongoClient dbClient = new MongoClient("mongodb://127.0.0.1:27017");
                        Console.Write("Connection Open  !");
                        break;

                    case "WELLSFARGO1":

                        connetionString = @"Data Source=WIN-50GP30FGO75;Initial Catalog=Demodb;User ID=sa;Password=demol23";
                        // cnn = new SqlConnection(connetionString);
                        //cnn.Open();
                        Console.Write("Connection Open  !");
                        break;
                    default:
                        Console.WriteLine("Default case");
                        break;
                }
            }
            catch (Exception e)
            {
                Console.Write("DB Connection Failed", e);
            }
        }

        public static void executeQuery(string Query)
        {
            String query = QueryProcess.GetQuery(Query);
            string actualquery = replaceParametersWithActualValue(query);
            Console.Write(actualquery);
           /* IMongoDatabase db = dbClient.GetDatabase("test");
            var collList = db.ListCollections().ToList();
            var things = db.GetCollection<BsonDocument>("things");
            var resultDoc = things.Find(new BsonDocument()).ToList();
            foreach (var item in resultDoc)
            {
                Console.WriteLine(item.ToString());
            }*/
        }

        public static String replaceParametersWithActualValue(String query)
        {


            foreach (DictionaryEntry item in ClassLibrary3.Steps.APISteps.parameter)
            {
                String keyText = item.Key.ToString();
                //CommonUtilities.waitTime(1);
                String param = "${" + keyText + "}";
                if (param != null && query != null)
                {
                    query = query.Replace(param, item.Value.ToString());
                }
            }
            return query;
        }


        public static void verifyDataInTable(Table table)
        {
            for (int i = 0; i <= table.Rows.Count - 1; i++)
            {
                int rowNumber = Int32.Parse(table.Rows[i][0]); 
                var columnName = table.Rows[i][1];
                var columnValue = table.Rows[i][2];
                if (columnValue.ToString().Contains("$"))
                {
                    columnValue = replaceParametersWithActualValue(columnValue);
                }

                validateRow(rowNumber,columnName, columnValue);
            }

            void validateRow(int rowNumber, string columnName, string columnValue)
            {
                Console.Write(rowNumber+ columnName + columnValue);
                Console.Write("Verify DB value with dtatatable value");
            }
        }

        public static void verifyDataField(Table table)
        {

            int colCount = table.Header.Count;
            
            for (int i= 0;i<colCount;i++)
            {
                var header = table.Header.ElementAt(i);

                var value = table.Rows[0][i];

                Console.Write("Verify DB value with dtatatable value");

            }

        }

        
    }
}
