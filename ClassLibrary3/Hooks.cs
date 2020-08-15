using AventStack.ExtentReports;
using AventStack.ExtentReports.Configuration;
using AventStack.ExtentReports.Gherkin.Model;
using AventStack.ExtentReports.Reporter;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using TechTalk.SpecFlow;

namespace ClassLibrary3
{
    [Binding]
    public sealed class Hooks
    {
        private static ScenarioContext _scenarioContext;
        //private static FeatureContext _featureContext;
        private static ExtentReports _extentReports;
        private static ExtentHtmlReporter _extentHtmlReporter;
        private static ExtentTest _feature;
        private static ExtentTest _scenario;

        public static string environment = ConfigurationSettings.AppSettings["environment"];
        public static string default_browser = ConfigurationSettings.AppSettings["default_browser"];
       

        [BeforeTestRun]
        public static void BeforeTestRun()
        {
           // _extentHtmlReporter = new ExtentHtmlReporter(@"C:\\Newfolder\\aaa.html");
            _extentReports = new ExtentReports();
            _extentReports.AttachReporter(_extentHtmlReporter);
        }


        [BeforeFeature]
        public static void BEFOREFEATURESTART(FeatureContext featureContext)
        {
            if (null != featureContext)
            {
                _feature = _extentReports.CreateTest<AventStack.ExtentReports.Gherkin.Model.Feature>(featureContext.FeatureInfo.Title);
            }
        }

        [BeforeScenario]

        public static void BEFOREFEATURESTART(ScenarioContext scenarioContext)
        {

            if (null != scenarioContext)
            {
                _scenarioContext = scenarioContext;
                _scenario = _feature.CreateNode<Scenario>("Scenario: <b>"+scenarioContext.ScenarioInfo.Title +"</b>");

            }
        }


        [AfterStep]

        public static void AfterEachStep()
        {
           
            ScenarioBlock scenarioBlock = _scenarioContext.CurrentScenarioBlock;
            
            switch (scenarioBlock)


            {
                case ScenarioBlock.Given:
                    if (_scenarioContext.TestError != null)
            {
                 _scenario.CreateNode<Given>( _scenarioContext.StepContext.StepInfo.Text).Fail(_scenarioContext.TestError.Message + " < BR>" +
                  _scenarioContext.TestError.StackTrace);

            }
            else

            {
               _scenario.CreateNode<Given>(_scenarioContext.StepContext.StepInfo.Text).Pass("");
                
            }
            break;
                case ScenarioBlock.When:
                    if (_scenarioContext.TestError != null)
            {
                _scenario.CreateNode<When>(_scenarioContext.StepContext.StepInfo.Text).Fail(_scenarioContext.TestError.Message + "<BR>" +
                  _scenarioContext.TestError.StackTrace);

            }
            else
            {
                _scenario.CreateNode<And>( _scenarioContext.StepContext.StepInfo.Text).Pass(_scenarioContext.StepContext.StepInfo.Table.ToString().Replace("\r\n", "<BR>") + "<BR>" + ClassLibrary3.Steps.APISteps.ServiceDetailsForReport);

                
             }
             break;
                case ScenarioBlock.Then:
                    if (_scenarioContext.TestError != null)
            {
                _scenario.CreateNode<Then>(_scenarioContext.StepContext.StepInfo.Text).Fail(_scenarioContext.TestError.Message + "<BR>" +
                 _scenarioContext.TestError.StackTrace);
            }
            else
            {
                       _scenario.CreateNode<And>( _scenarioContext.StepContext.StepInfo.Text).Pass(_scenarioContext.StepContext.StepInfo.Table.ToString().Replace("\r\n", "<BR>") + "<BR>" + ClassLibrary3.Steps.APISteps.ServiceDetailsForReport);
                      

                    }
            break;
            default:
                    if (_scenarioContext.TestError != null)
            {
                _scenario.CreateNode<And>(_scenarioContext.StepContext.StepInfo.Text).Fail(_scenarioContext.TestError.Message + "<BR>" +
                  _scenarioContext.TestError.StackTrace);

            }
            else
            {
                       _scenario.CreateNode<And>( _scenarioContext.StepContext.StepInfo.Text).Pass(_scenarioContext.StepContext.StepInfo.Table.ToString().Replace("\r\n", "<BR>") + "<BR>" + ClassLibrary3.Steps.APISteps.ServiceDetailsForReport);

                      
              }
              break;



        }

    }

        [AfterTestRun]
        public static void AFTERTESTRUN()
        {
            _extentReports.Flush();
        }
    }
}
