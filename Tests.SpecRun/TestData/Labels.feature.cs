﻿// ------------------------------------------------------------------------------
//  <auto-generated>
//      This code was generated by SpecFlow (http://www.specflow.org/).
//      SpecFlow Version:2.2.0.0
//      SpecFlow Generator Version:2.2.0.0
// 
//      Changes to this file may cause incorrect behavior and will be lost if
//      the code is regenerated.
//  </auto-generated>
// ------------------------------------------------------------------------------
#region Designer generated code
#pragma warning disable
namespace Tests.SpecRun.TestData
{
    using TechTalk.SpecFlow;
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("TechTalk.SpecFlow", "2.2.0.0")]
    [System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [TechTalk.SpecRun.FeatureAttribute("Labels", new string[] {
            "labels",
            "core",
            "epic:v1.2",
            "owner:Vasya"}, SourceFile="TestData\\Labels.feature", SourceLine=1)]
    public partial class LabelsFeature
    {
        
        private TechTalk.SpecFlow.ITestRunner testRunner;
        
#line 1 "Labels.feature"
#line hidden
        
        [TechTalk.SpecRun.FeatureInitialize()]
        public virtual void FeatureSetup()
        {
            testRunner = TechTalk.SpecFlow.TestRunnerManager.GetTestRunner();
            TechTalk.SpecFlow.FeatureInfo featureInfo = new TechTalk.SpecFlow.FeatureInfo(new System.Globalization.CultureInfo("en-US"), "Labels", null, ProgrammingLanguage.CSharp, new string[] {
                        "labels",
                        "core",
                        "epic:v1.2",
                        "owner:Vasya"});
            testRunner.OnFeatureStart(featureInfo);
        }
        
        [TechTalk.SpecRun.FeatureCleanup()]
        public virtual void FeatureTearDown()
        {
            testRunner.OnFeatureEnd();
            testRunner = null;
        }
        
        public virtual void TestInitialize()
        {
        }
        
        [TechTalk.SpecRun.ScenarioCleanup()]
        public virtual void ScenarioTearDown()
        {
            testRunner.OnScenarioEnd();
        }
        
        public virtual void ScenarioSetup(TechTalk.SpecFlow.ScenarioInfo scenarioInfo)
        {
            testRunner.OnScenarioStart(scenarioInfo);
        }
        
        public virtual void ScenarioCleanup()
        {
            testRunner.CollectScenarioErrors();
        }
        
        [TechTalk.SpecRun.ScenarioAttribute("[v1.2 accounting] [ui.core] Selenium test 1", new string[] {
                "ui",
                "story:accounting",
                "123",
                "tms:234",
                "package:com.company.accounting",
                "class:main",
                "method:getLedger",
                "tag1"}, SourceLine=4)]
        public virtual void V1_2AccountingUi_CoreSeleniumTest1()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("[v1.2 accounting] [ui.core] Selenium test 1", new string[] {
                        "ui",
                        "story:accounting",
                        "123",
                        "tms:234",
                        "package:com.company.accounting",
                        "class:main",
                        "method:getLedger",
                        "tag1"});
#line 5
this.ScenarioSetup(scenarioInfo);
#line hidden
            this.ScenarioCleanup();
        }
        
        [TechTalk.SpecRun.ScenarioAttribute("[v1.2] [api.core] Api test 1", new string[] {
                "api",
                "blocker",
                "567",
                "999999"}, SourceLine=7)]
        public virtual void V1_2Api_CoreApiTest1()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("[v1.2] [api.core] Api test 1", new string[] {
                        "api",
                        "blocker",
                        "567",
                        "999999"});
#line 8
this.ScenarioSetup(scenarioInfo);
#line hidden
            this.ScenarioCleanup();
        }
        
        [TechTalk.SpecRun.ScenarioAttribute("[v1.2] [api.core.create] Api test 2", new string[] {
                "api",
                "create",
                "link:http://example.org"}, SourceLine=10)]
        public virtual void V1_2Api_Core_CreateApiTest2()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("[v1.2] [api.core.create] Api test 2", new string[] {
                        "api",
                        "create",
                        "link:http://example.org"});
#line 11
this.ScenarioSetup(scenarioInfo);
#line hidden
            this.ScenarioCleanup();
        }
        
        [TechTalk.SpecRun.ScenarioAttribute("[v1.2] [api.core.update] Api test 3", new string[] {
                "api",
                "update"}, SourceLine=13)]
        public virtual void V1_2Api_Core_UpdateApiTest3()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("[v1.2] [api.core.update] Api test 3", new string[] {
                        "api",
                        "update"});
#line 14
this.ScenarioSetup(scenarioInfo);
#line hidden
            this.ScenarioCleanup();
        }
        
        [TechTalk.SpecRun.ScenarioAttribute("[v1.2 accounting] [core.update] Update test", new string[] {
                "update",
                "story:accounting"}, SourceLine=16)]
        public virtual void V1_2AccountingCore_UpdateUpdateTest()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("[v1.2 accounting] [core.update] Update test", new string[] {
                        "update",
                        "story:accounting"});
#line 17
this.ScenarioSetup(scenarioInfo);
#line hidden
            this.ScenarioCleanup();
        }
        
        [TechTalk.SpecRun.ScenarioAttribute("[v1.2 / v.2.0 security] [core.update] [com.company.security.main.getACL] Get ACL " +
            "test", new string[] {
                "epic:v.2.0",
                "story:security",
                "package:com.company.security",
                "class:main",
                "method:getACL"}, SourceLine=19)]
        public virtual void V1_2V_2_0SecurityCore_UpdateCom_Company_Security_Main_GetACLGetACLTest()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("[v1.2 / v.2.0 security] [core.update] [com.company.security.main.getACL] Get ACL " +
                    "test", new string[] {
                        "epic:v.2.0",
                        "story:security",
                        "package:com.company.security",
                        "class:main",
                        "method:getACL"});
#line 20
this.ScenarioSetup(scenarioInfo);
#line hidden
            this.ScenarioCleanup();
        }
        
        [TechTalk.SpecRun.TestRunCleanup()]
        public virtual void TestRunCleanup()
        {
            TechTalk.SpecFlow.TestRunnerManager.GetTestRunner().OnTestRunEnd();
        }
    }
}
#pragma warning restore
#endregion
