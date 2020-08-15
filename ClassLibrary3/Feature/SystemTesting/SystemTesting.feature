Feature: SystemTesting

@Test1
Scenario: Get API respnse using given endpoint
    Given RestService "getemployees" with config in "ServiceDetailsJSONString" Json file
	Then I call "GET" service "getemployees" with modified parameter with updated body "" as "False"
	  | Veriable | Value  |   
	  | Connectionvalues | Accept  |
      | Urlsuffix    | /users/1    |
	Given verify response should return "OK" as statuscode
	Then verify following response values
      | nodePath      | value    |
	  |  address.street |Kulas Light|
	  |  address.geo.lng |81.1496|
	  | name |Leanne Graham |
	  | website | hildegard.org  |
	Given I have "WELLSFARGO" client database details
	

@Test2
Scenario: Post createuser API respnse using given endpoint
  Given RestService "createuser" with config in "ServiceDetailsJSONString" Json file
     Then I call "POST" service "createuser" with modified parameter with updated body "createuserupdatedbody1" as "True"
	 | Veriable    | Value            |
	 | ContentType | application/json |
	 | MethodType  | POST             |
	 
	Given verify response should return "OK" as statuscode
	Then verify following response values
      | nodePath      | value    |
      | name |Leanne Graham|
	  | job | leader  |


	  @Test3
Scenario: Get and Post API respnse using given endpoint
     Given RestService "getemployees" with config in "ServiceDetailsJSONString" Json file
	Then I call "GET" service "getemployees" with modified parameter with updated body "" as "False"
	  | Veriable | Value  |   
	  | Connectionvalues | Accept  |
      | Urlsuffix    | /users/1    |
	Given verify response should return "OK" as statuscode
	Then verify following response values
      | nodePath      | value    |
	  |  address.street |Kulas Light|
	  |  address.geo.lng |81.1496|
	  | name |Leanne Graham |
	  | website | hildegard.org  |

  Given RestService "createuser" with config in "ServiceDetailsJSONString" Json file
   Then I call "POST" service "createuser" with modified parameter with updated body "createuserupdatedbody1" as "True"
	 | Veriable | Value  |   
	  | ContentType | application/json   |
      | MethodType    | POST    |
	Given verify response should return "OK" as statuscode
	Then verify following response values
      | nodePath      | value    |
      | name |Leanne Graham|
	  | job | leader  |

	   Given RestService "getemployees" with config in "ServiceDetailsJSONString" Json file
	Then I call "GET" service "getemployees" with modified parameter with updated body "" as "False"
	  | Veriable | Value  |   
	  | Connectionvalues | Accept  |
      | Urlsuffix    | /users/1    |
	Given verify response should return "OK" as statuscode
	Then verify following response values
      | nodePath      | value    |
	  |  address.street |Kulas Light|
	  |  address.geo.lng |81.1496|
	  | name |Leanne Graham |
	  | website | hildegard.org  |

	  Given RestService "createuser" with config in "ServiceDetailsJSONString" Json file
     Then I call "POST" service "createuser" with modified parameter with updated body "" as "False"
	 | Veriable    | Value            |
	 | ContentType | application/json |
	 | MethodType  | POST             |
	 
	Given verify response should return "OK" as statuscode
	Then verify following response values
      | nodePath      | value    |
      | name |morpheus|
	  | job | leader  |