using ClassLibrary3.Steps;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary3.UpdatedBody
{
    class Updatedbody

    {

        public string createuserupdatedbody1;
        public string createuserupdatedbody2;
        public string createuserupdatedbody3;

        public Updatedbody()
        {
            createuserupdatedbody1 = "{\"name\":\""+ APISteps.getemployeesResponseObj.name +"\",\"job\":\"leader\"}";
            createuserupdatedbody2 = "{\"name\":\"john\",\"job\":\"driver\"}";
            createuserupdatedbody3 = "{\"name\":\"john\",\"job\":\"driver\"}";
        }

    }
}
