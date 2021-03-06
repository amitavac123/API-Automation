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
namespace ClassLibrary3.Feature.SystemTesting
{
    using TechTalk.SpecFlow;
    using System;
    using System.Linq;
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("TechTalk.SpecFlow", "3.3.0.0")]
    [System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [NUnit.Framework.TestFixtureAttribute()]
    [NUnit.Framework.DescriptionAttribute("SystemTesting")]
    public partial class SystemTestingFeature
    {
        
        private TechTalk.SpecFlow.ITestRunner testRunner;
        
        private string[] _featureTags = ((string[])(null));
        
#line 1 "SystemTesting.feature"
#line hidden
        
        [NUnit.Framework.OneTimeSetUpAttribute()]
        public virtual void FeatureSetup()
        {
            testRunner = TechTalk.SpecFlow.TestRunnerManager.GetTestRunner();
            TechTalk.SpecFlow.FeatureInfo featureInfo = new TechTalk.SpecFlow.FeatureInfo(new System.Globalization.CultureInfo("en-US"), "SystemTesting", null, ProgrammingLanguage.CSharp, ((string[])(null)));
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
                TechTalk.SpecFlow.Table table15 = new TechTalk.SpecFlow.Table(new string[] {
                            "Veriable",
                            "Value"});
                table15.AddRow(new string[] {
                            "Connectionvalues",
                            "Accept"});
                table15.AddRow(new string[] {
                            "Urlsuffix",
                            "/users/1"});
#line 6
 testRunner.Then("I call \"GET\" service \"getemployees\" with modified parameter with updated body \"\" " +
                        "as \"False\"", ((string)(null)), table15, "Then ");
#line hidden
#line 10
 testRunner.Given("verify response should return \"OK\" as statuscode", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line hidden
                TechTalk.SpecFlow.Table table16 = new TechTalk.SpecFlow.Table(new string[] {
                            "nodePath",
                            "value"});
                table16.AddRow(new string[] {
                            "address.street",
                            "Kulas Light"});
                table16.AddRow(new string[] {
                            "address.geo.lng",
                            "81.1496"});
                table16.AddRow(new string[] {
                            "name",
                            "Leanne Graham"});
                table16.AddRow(new string[] {
                            "website",
                            "hildegard.org"});
#line 11
 testRunner.Then("verify following response values", ((string)(null)), table16, "Then ");
#line hidden
#line 17
 testRunner.Given("I have \"WELLSFARGO\" client database details", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
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
#line 21
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
#line 22
  testRunner.Given("RestService \"createuser\" with config in \"ServiceDetailsJSONString\" Json file", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line hidden
                TechTalk.SpecFlow.Table table17 = new TechTalk.SpecFlow.Table(new string[] {
                            "Veriable",
                            "Value"});
                table17.AddRow(new string[] {
                            "ContentType",
                            "application/json"});
                table17.AddRow(new string[] {
                            "MethodType",
                            "POST"});
#line 23
     testRunner.Then("I call \"POST\" service \"createuser\" with modified parameter with updated body \"cre" +
                        "ateuserupdatedbody1\" as \"True\"", ((string)(null)), table17, "Then ");
#line hidden
#line 28
 testRunner.Given("verify response should return \"OK\" as statuscode", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line hidden
                TechTalk.SpecFlow.Table table18 = new TechTalk.SpecFlow.Table(new string[] {
                            "nodePath",
                            "value"});
                table18.AddRow(new string[] {
                            "name",
                            "Leanne Graham"});
                table18.AddRow(new string[] {
                            "job",
                            "leader"});
#line 29
 testRunner.Then("verify following response values", ((string)(null)), table18, "Then ");
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
#line 36
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
#line 37
     testRunner.Given("RestService \"getemployees\" with config in \"ServiceDetailsJSONString\" Json file", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line hidden
                TechTalk.SpecFlow.Table table19 = new TechTalk.SpecFlow.Table(new string[] {
                            "Veriable",
                            "Value"});
                table19.AddRow(new string[] {
                            "Connectionvalues",
                            "Accept"});
                table19.AddRow(new string[] {
                            "Urlsuffix",
                            "/users/1"});
#line 38
 testRunner.Then("I call \"GET\" service \"getemployees\" with modified parameter with updated body \"\" " +
                        "as \"False\"", ((string)(null)), table19, "Then ");
#line hidden
#line 42
 testRunner.Given("verify response should return \"OK\" as statuscode", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line hidden
                TechTalk.SpecFlow.Table table20 = new TechTalk.SpecFlow.Table(new string[] {
                            "nodePath",
                            "value"});
                table20.AddRow(new string[] {
                            "address.street",
                            "Kulas Light"});
                table20.AddRow(new string[] {
                            "address.geo.lng",
                            "81.1496"});
                table20.AddRow(new string[] {
                            "name",
                            "Leanne Graham"});
                table20.AddRow(new string[] {
                            "website",
                            "hildegard.org"});
#line 43
 testRunner.Then("verify following response values", ((string)(null)), table20, "Then ");
#line hidden
#line 50
  testRunner.Given("RestService \"createuser\" with config in \"ServiceDetailsJSONString\" Json file", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line hidden
                TechTalk.SpecFlow.Table table21 = new TechTalk.SpecFlow.Table(new string[] {
                            "Veriable",
                            "Value"});
                table21.AddRow(new string[] {
                            "ContentType",
                            "application/json"});
                table21.AddRow(new string[] {
                            "MethodType",
                            "POST"});
#line 51
   testRunner.Then("I call \"POST\" service \"createuser\" with modified parameter with updated body \"cre" +
                        "ateuserupdatedbody1\" as \"True\"", ((string)(null)), table21, "Then ");
#line hidden
#line 55
 testRunner.Given("verify response should return \"OK\" as statuscode", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line hidden
                TechTalk.SpecFlow.Table table22 = new TechTalk.SpecFlow.Table(new string[] {
                            "nodePath",
                            "value"});
                table22.AddRow(new string[] {
                            "name",
                            "Leanne Graham"});
                table22.AddRow(new string[] {
                            "job",
                            "leader"});
#line 56
 testRunner.Then("verify following response values", ((string)(null)), table22, "Then ");
#line hidden
#line 61
    testRunner.Given("RestService \"getemployees\" with config in \"ServiceDetailsJSONString\" Json file", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line hidden
                TechTalk.SpecFlow.Table table23 = new TechTalk.SpecFlow.Table(new string[] {
                            "Veriable",
                            "Value"});
                table23.AddRow(new string[] {
                            "Connectionvalues",
                            "Accept"});
                table23.AddRow(new string[] {
                            "Urlsuffix",
                            "/users/1"});
#line 62
 testRunner.Then("I call \"GET\" service \"getemployees\" with modified parameter with updated body \"\" " +
                        "as \"False\"", ((string)(null)), table23, "Then ");
#line hidden
#line 66
 testRunner.Given("verify response should return \"OK\" as statuscode", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line hidden
                TechTalk.SpecFlow.Table table24 = new TechTalk.SpecFlow.Table(new string[] {
                            "nodePath",
                            "value"});
                table24.AddRow(new string[] {
                            "address.street",
                            "Kulas Light"});
                table24.AddRow(new string[] {
                            "address.geo.lng",
                            "81.1496"});
                table24.AddRow(new string[] {
                            "name",
                            "Leanne Graham"});
                table24.AddRow(new string[] {
                            "website",
                            "hildegard.org"});
#line 67
 testRunner.Then("verify following response values", ((string)(null)), table24, "Then ");
#line hidden
#line 74
   testRunner.Given("RestService \"createuser\" with config in \"ServiceDetailsJSONString\" Json file", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line hidden
                TechTalk.SpecFlow.Table table25 = new TechTalk.SpecFlow.Table(new string[] {
                            "Veriable",
                            "Value"});
                table25.AddRow(new string[] {
                            "ContentType",
                            "application/json"});
                table25.AddRow(new string[] {
                            "MethodType",
                            "POST"});
#line 75
     testRunner.Then("I call \"POST\" service \"createuser\" with modified parameter with updated body \"\" a" +
                        "s \"False\"", ((string)(null)), table25, "Then ");
#line hidden
#line 80
 testRunner.Given("verify response should return \"OK\" as statuscode", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line hidden
                TechTalk.SpecFlow.Table table26 = new TechTalk.SpecFlow.Table(new string[] {
                            "nodePath",
                            "value"});
                table26.AddRow(new string[] {
                            "name",
                            "morpheus"});
                table26.AddRow(new string[] {
                            "job",
                            "leader"});
#line 81
 testRunner.Then("verify following response values", ((string)(null)), table26, "Then ");
#line hidden
            }
            this.ScenarioCleanup();
        }
    }
}
#pragma warning restore
#endregion
