﻿// ------------------------------------------------------------------------------
//  <auto-generated>
//      This code was generated by SpecFlow (https://www.specflow.org/).
//      SpecFlow Version:3.3.0.0
//      SpecFlow Generator Version:3.1.0.0
// 
//      Changes to this file may cause incorrect behavior and will be lost if
//      the code is regenerated.
//  </auto-generated>
// ------------------------------------------------------------------------------
#region Designer generated code
#pragma warning disable
namespace ClassLibrary3.Feature.FeatureJsonObject
{
    using TechTalk.SpecFlow;
    using System;
    using System.Linq;
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("TechTalk.SpecFlow", "3.3.0.0")]
    [System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [NUnit.Framework.TestFixtureAttribute()]
    [NUnit.Framework.DescriptionAttribute("SpecFlowFeature1")]
    public partial class SpecFlowFeature1Feature
    {
        
        private TechTalk.SpecFlow.ITestRunner testRunner;
        
        private string[] _featureTags = ((string[])(null));
        
#line 1 "SpecFlowJasonObj.feature"
#line hidden
        
        [NUnit.Framework.OneTimeSetUpAttribute()]
        public virtual void FeatureSetup()
        {
            testRunner = TechTalk.SpecFlow.TestRunnerManager.GetTestRunner();
            TechTalk.SpecFlow.FeatureInfo featureInfo = new TechTalk.SpecFlow.FeatureInfo(new System.Globalization.CultureInfo("en-US"), "SpecFlowFeature1", null, ProgrammingLanguage.CSharp, ((string[])(null)));
            testRunner.OnFeatureStart(featureInfo);
        }
        
        [NUnit.Framework.OneTimeTearDownAttribute()]
        public virtual void FeatureTearDown()
        {
            testRunner.OnFeatureEnd();
            testRunner = null;
        }
        
        [NUnit.Framework.SetUpAttribute()]
        public virtual void TestInitialize()
        {
        }
        
        [NUnit.Framework.TearDownAttribute()]
        public virtual void TestTearDown()
        {
            testRunner.OnScenarioEnd();
        }
        
        public virtual void ScenarioInitialize(TechTalk.SpecFlow.ScenarioInfo scenarioInfo)
        {
            testRunner.OnScenarioInitialize(scenarioInfo);
            testRunner.ScenarioContext.ScenarioContainer.RegisterInstanceAs<NUnit.Framework.TestContext>(NUnit.Framework.TestContext.CurrentContext);
        }
        
        public virtual void ScenarioStart()
        {
            testRunner.OnScenarioStart();
        }
        
        public virtual void ScenarioCleanup()
        {
            testRunner.CollectScenarioErrors();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Get API respnse using given endpoint")]
        [NUnit.Framework.CategoryAttribute("Test1")]
        public virtual void GetAPIRespnseUsingGivenEndpoint()
        {
            string[] tagsOfScenario = new string[] {
                    "Test1"};
            System.Collections.Specialized.OrderedDictionary argumentsOfScenario = new System.Collections.Specialized.OrderedDictionary();
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Get API respnse using given endpoint", null, tagsOfScenario, argumentsOfScenario);
#line 4
this.ScenarioInitialize(scenarioInfo);
#line hidden
            bool isScenarioIgnored = default(bool);
            bool isFeatureIgnored = default(bool);
            if ((tagsOfScenario != null))
            {
                isScenarioIgnored = tagsOfScenario.Where(__entry => __entry != null).Where(__entry => String.Equals(__entry, "ignore", StringComparison.CurrentCultureIgnoreCase)).Any();
            }
            if ((this._featureTags != null))
            {
                isFeatureIgnored = this._featureTags.Where(__entry => __entry != null).Where(__entry => String.Equals(__entry, "ignore", StringComparison.CurrentCultureIgnoreCase)).Any();
            }
            if ((isScenarioIgnored || isFeatureIgnored))
            {
                testRunner.SkipScenario();
            }
            else
            {
                this.ScenarioStart();
#line 5
    testRunner.Given("RestService \"getemployees\" with config in \"ServiceDetailsJSONString\" Json file", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line hidden
                TechTalk.SpecFlow.Table table1 = new TechTalk.SpecFlow.Table(new string[] {
                            "Veriable",
                            "Value"});
                table1.AddRow(new string[] {
                            "Connectionvalues",
                            "Accept"});
                table1.AddRow(new string[] {
                            "Urlsuffix",
                            "/users/1"});
#line 6
 testRunner.Then("I call \"GET\" service \"getemployees\" with modified parameter with updated body \"\" " +
                        "as \"False\"", ((string)(null)), table1, "Then ");
#line hidden
#line 10
 testRunner.Given("verify response should return \"OK\" as statuscode", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line hidden
                TechTalk.SpecFlow.Table table2 = new TechTalk.SpecFlow.Table(new string[] {
                            "nodePath",
                            "value"});
                table2.AddRow(new string[] {
                            "address.street",
                            "Kulas Light"});
                table2.AddRow(new string[] {
                            "address.geo.lng",
                            "81.1496"});
                table2.AddRow(new string[] {
                            "name",
                            "Leanne Graham"});
                table2.AddRow(new string[] {
                            "website",
                            "hildegard.org"});
#line 11
 testRunner.Then("verify following response values", ((string)(null)), table2, "Then ");
#line hidden
#line 17
 testRunner.Given("I have \"WELLSFARGO\" client database details", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line hidden
#line 18
 testRunner.Given("I execute Select Query \"query2\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line hidden
                TechTalk.SpecFlow.Table table3 = new TechTalk.SpecFlow.Table(new string[] {
                            "ROW_NUMBER",
                            "COLUMN_NAME",
                            "COLUMN_VALUE"});
                table3.AddRow(new string[] {
                            "1",
                            "Name",
                            "${EmpName}"});
                table3.AddRow(new string[] {
                            "1",
                            "department",
                            "Account"});
#line 19
 testRunner.Then("verify from executed query", ((string)(null)), table3, "Then ");
#line hidden
                TechTalk.SpecFlow.Table table4 = new TechTalk.SpecFlow.Table(new string[] {
                            "Name",
                            "department",
                            "designation"});
                table4.AddRow(new string[] {
                            "${EmpName}",
                            "Account",
                            "Accountant"});
#line 23
     testRunner.Then("I verify fields in database", ((string)(null)), table4, "Then ");
#line hidden
            }
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Post createuser API respnse using given endpoint")]
        [NUnit.Framework.CategoryAttribute("Test2")]
        public virtual void PostCreateuserAPIRespnseUsingGivenEndpoint()
        {
            string[] tagsOfScenario = new string[] {
                    "Test2"};
            System.Collections.Specialized.OrderedDictionary argumentsOfScenario = new System.Collections.Specialized.OrderedDictionary();
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Post createuser API respnse using given endpoint", null, tagsOfScenario, argumentsOfScenario);
#line 28
this.ScenarioInitialize(scenarioInfo);
#line hidden
            bool isScenarioIgnored = default(bool);
            bool isFeatureIgnored = default(bool);
            if ((tagsOfScenario != null))
            {
                isScenarioIgnored = tagsOfScenario.Where(__entry => __entry != null).Where(__entry => String.Equals(__entry, "ignore", StringComparison.CurrentCultureIgnoreCase)).Any();
            }
            if ((this._featureTags != null))
            {
                isFeatureIgnored = this._featureTags.Where(__entry => __entry != null).Where(__entry => String.Equals(__entry, "ignore", StringComparison.CurrentCultureIgnoreCase)).Any();
            }
            if ((isScenarioIgnored || isFeatureIgnored))
            {
                testRunner.SkipScenario();
            }
            else
            {
                this.ScenarioStart();
#line 29
  testRunner.Given("RestService \"createuser\" with config in \"ServiceDetailsJSONString\" Json file", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line hidden
                TechTalk.SpecFlow.Table table5 = new TechTalk.SpecFlow.Table(new string[] {
                            "Veriable",
                            "Value"});
                table5.AddRow(new string[] {
                            "ContentType",
                            "application/json"});
                table5.AddRow(new string[] {
                            "MethodType",
                            "POST"});
#line 30
     testRunner.Then("I call \"POST\" service \"createuser\" with modified parameter with updated body \"cre" +
                        "ateuserupdatedbody1\" as \"True\"", ((string)(null)), table5, "Then ");
#line hidden
#line 35
 testRunner.Given("verify response should return \"OK\" as statuscode", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line hidden
                TechTalk.SpecFlow.Table table6 = new TechTalk.SpecFlow.Table(new string[] {
                            "nodePath",
                            "value"});
                table6.AddRow(new string[] {
                            "name",
                            "Leanne Graham"});
                table6.AddRow(new string[] {
                            "job",
                            "leader"});
#line 36
 testRunner.Then("verify following response values", ((string)(null)), table6, "Then ");
#line hidden
            }
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Get and Post API respnse using given endpoint")]
        [NUnit.Framework.CategoryAttribute("Test3")]
        public virtual void GetAndPostAPIRespnseUsingGivenEndpoint()
        {
            string[] tagsOfScenario = new string[] {
                    "Test3"};
            System.Collections.Specialized.OrderedDictionary argumentsOfScenario = new System.Collections.Specialized.OrderedDictionary();
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Get and Post API respnse using given endpoint", null, tagsOfScenario, argumentsOfScenario);
#line 43
this.ScenarioInitialize(scenarioInfo);
#line hidden
            bool isScenarioIgnored = default(bool);
            bool isFeatureIgnored = default(bool);
            if ((tagsOfScenario != null))
            {
                isScenarioIgnored = tagsOfScenario.Where(__entry => __entry != null).Where(__entry => String.Equals(__entry, "ignore", StringComparison.CurrentCultureIgnoreCase)).Any();
            }
            if ((this._featureTags != null))
            {
                isFeatureIgnored = this._featureTags.Where(__entry => __entry != null).Where(__entry => String.Equals(__entry, "ignore", StringComparison.CurrentCultureIgnoreCase)).Any();
            }
            if ((isScenarioIgnored || isFeatureIgnored))
            {
                testRunner.SkipScenario();
            }
            else
            {
                this.ScenarioStart();
#line 44
     testRunner.Given("RestService \"getemployees\" with config in \"ServiceDetailsJSONString\" Json file", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line hidden
                TechTalk.SpecFlow.Table table7 = new TechTalk.SpecFlow.Table(new string[] {
                            "Veriable",
                            "Value"});
                table7.AddRow(new string[] {
                            "Connectionvalues",
                            "Accept"});
                table7.AddRow(new string[] {
                            "Urlsuffix",
                            "/users/1"});
#line 45
 testRunner.Then("I call \"GET\" service \"getemployees\" with modified parameter with updated body \"\" " +
                        "as \"False\"", ((string)(null)), table7, "Then ");
#line hidden
#line 49
 testRunner.Given("verify response should return \"OK\" as statuscode", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line hidden
                TechTalk.SpecFlow.Table table8 = new TechTalk.SpecFlow.Table(new string[] {
                            "nodePath",
                            "value"});
                table8.AddRow(new string[] {
                            "address.street",
                            "Kulas Light"});
                table8.AddRow(new string[] {
                            "address.geo.lng",
                            "81.1496"});
                table8.AddRow(new string[] {
                            "name",
                            "Leanne Graham"});
                table8.AddRow(new string[] {
                            "website",
                            "hildegard.org"});
#line 50
 testRunner.Then("verify following response values", ((string)(null)), table8, "Then ");
#line hidden
#line 57
  testRunner.Given("RestService \"createuser\" with config in \"ServiceDetailsJSONString\" Json file", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line hidden
                TechTalk.SpecFlow.Table table9 = new TechTalk.SpecFlow.Table(new string[] {
                            "Veriable",
                            "Value"});
                table9.AddRow(new string[] {
                            "ContentType",
                            "application/json"});
                table9.AddRow(new string[] {
                            "MethodType",
                            "POST"});
#line 58
   testRunner.Then("I call \"POST\" service \"createuser\" with modified parameter with updated body \"cre" +
                        "ateuserupdatedbody1\" as \"True\"", ((string)(null)), table9, "Then ");
#line hidden
#line 62
 testRunner.Given("verify response should return \"OK\" as statuscode", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line hidden
                TechTalk.SpecFlow.Table table10 = new TechTalk.SpecFlow.Table(new string[] {
                            "nodePath",
                            "value"});
                table10.AddRow(new string[] {
                            "name",
                            "Leanne Graham"});
                table10.AddRow(new string[] {
                            "job",
                            "leader"});
#line 63
 testRunner.Then("verify following response values", ((string)(null)), table10, "Then ");
#line hidden
#line 68
    testRunner.Given("RestService \"getemployees\" with config in \"ServiceDetailsJSONString\" Json file", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line hidden
                TechTalk.SpecFlow.Table table11 = new TechTalk.SpecFlow.Table(new string[] {
                            "Veriable",
                            "Value"});
                table11.AddRow(new string[] {
                            "Connectionvalues",
                            "Accept"});
                table11.AddRow(new string[] {
                            "Urlsuffix",
                            "/users/1"});
#line 69
 testRunner.Then("I call \"GET\" service \"getemployees\" with modified parameter with updated body \"\" " +
                        "as \"False\"", ((string)(null)), table11, "Then ");
#line hidden
#line 73
 testRunner.Given("verify response should return \"OK\" as statuscode", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line hidden
                TechTalk.SpecFlow.Table table12 = new TechTalk.SpecFlow.Table(new string[] {
                            "nodePath",
                            "value"});
                table12.AddRow(new string[] {
                            "address.street",
                            "Kulas Light"});
                table12.AddRow(new string[] {
                            "address.geo.lng",
                            "81.1496"});
                table12.AddRow(new string[] {
                            "name",
                            "Leanne Graham"});
                table12.AddRow(new string[] {
                            "website",
                            "hildegard.org"});
#line 74
 testRunner.Then("verify following response values", ((string)(null)), table12, "Then ");
#line hidden
#line 81
   testRunner.Given("RestService \"createuser\" with config in \"ServiceDetailsJSONString\" Json file", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line hidden
                TechTalk.SpecFlow.Table table13 = new TechTalk.SpecFlow.Table(new string[] {
                            "Veriable",
                            "Value"});
                table13.AddRow(new string[] {
                            "ContentType",
                            "application/json"});
                table13.AddRow(new string[] {
                            "MethodType",
                            "POST"});
#line 82
     testRunner.Then("I call \"POST\" service \"createuser\" with modified parameter with updated body \"\" a" +
                        "s \"False\"", ((string)(null)), table13, "Then ");
#line hidden
#line 87
 testRunner.Given("verify response should return \"OK\" as statuscode", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line hidden
                TechTalk.SpecFlow.Table table14 = new TechTalk.SpecFlow.Table(new string[] {
                            "nodePath",
                            "value"});
                table14.AddRow(new string[] {
                            "name",
                            "morpheus"});
                table14.AddRow(new string[] {
                            "job",
                            "leader"});
#line 88
 testRunner.Then("verify following response values", ((string)(null)), table14, "Then ");
#line hidden
            }
            this.ScenarioCleanup();
        }
    }
}
#pragma warning restore
#endregion
