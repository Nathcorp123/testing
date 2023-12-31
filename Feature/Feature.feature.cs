﻿// ------------------------------------------------------------------------------
//  <auto-generated>
//      This code was generated by SpecFlow (http://www.specflow.org/).
//      SpecFlow Version:2.4.0.0
//      SpecFlow Generator Version:2.4.0.0
// 
//      Changes to this file may cause incorrect behavior and will be lost if
//      the code is regenerated.
//  </auto-generated>
// ------------------------------------------------------------------------------
#region Designer generated code
#pragma warning disable
namespace finalspecflow.Feature
{
    using TechTalk.SpecFlow;
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("TechTalk.SpecFlow", "2.4.0.0")]
    [System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [NUnit.Framework.TestFixtureAttribute()]
    [NUnit.Framework.DescriptionAttribute("To test login functionality for OrangeHRm application")]
    public partial class ToTestLoginFunctionalityForOrangeHRmApplicationFeature
    {
        
        private TechTalk.SpecFlow.ITestRunner testRunner;
        
#line 1 "Feature.feature"
#line hidden
        
        [NUnit.Framework.OneTimeSetUpAttribute()]
        public virtual void FeatureSetup()
        {
            testRunner = TechTalk.SpecFlow.TestRunnerManager.GetTestRunner();
            TechTalk.SpecFlow.FeatureInfo featureInfo = new TechTalk.SpecFlow.FeatureInfo(new System.Globalization.CultureInfo("en-US"), "To test login functionality for OrangeHRm application", "\tTo test login functionalitis ", ProgrammingLanguage.CSharp, ((string[])(null)));
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
        public virtual void ScenarioTearDown()
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
        [NUnit.Framework.DescriptionAttribute("To make login in orange HRM application and go to home page")]
        [NUnit.Framework.CategoryAttribute("Launch")]
        [NUnit.Framework.CategoryAttribute("MHC")]
        [NUnit.Framework.CategoryAttribute("website")]
        [NUnit.Framework.CategoryAttribute("and")]
        [NUnit.Framework.CategoryAttribute("make")]
        [NUnit.Framework.CategoryAttribute("login")]
        [NUnit.Framework.CategoryAttribute("into")]
        [NUnit.Framework.CategoryAttribute("application")]
        [NUnit.Framework.CategoryAttribute("with")]
        [NUnit.Framework.CategoryAttribute("users")]
        [NUnit.Framework.CategoryAttribute("account")]
        [NUnit.Framework.TestCaseAttribute("manishverma66@gmail.com", "nathcorp!1", new string[] {
                "source:MHC.xlsx:Sheet1"}, Category="source:MHC.xlsx:Sheet1")]
        public virtual void ToMakeLoginInOrangeHRMApplicationAndGoToHomePage(string emailid, string password, string[] exampleTags)
        {
            string[] @__tags = new string[] {
                    "Launch",
                    "MHC",
                    "website",
                    "and",
                    "make",
                    "login",
                    "into",
                    "application",
                    "with",
                    "users",
                    "account"};
            if ((exampleTags != null))
            {
                @__tags = System.Linq.Enumerable.ToArray(System.Linq.Enumerable.Concat(@__tags, exampleTags));
            }
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("To make login in orange HRM application and go to home page", null, @__tags);
#line 5
this.ScenarioInitialize(scenarioInfo);
            this.ScenarioStart();
#line 6
 testRunner.Given("Launch the browser and open the url", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 7
 testRunner.And(string.Format("Enter the valid userid {0} and password{1}", emailid, password), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 8
 testRunner.When("Click on login button", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 9
 testRunner.Then("User should be sucessfully redirected to home page of application", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
    }
}
#pragma warning restore
#endregion
