using MarsQA_1.Helpers;
using NUnit.Framework;
using OpenQA.Selenium;
using RelevantCodes.ExtentReports;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using TechTalk.SpecFlow;
using static MarsQA_1.Helpers.CommonMethods;

namespace MarsQA_1.SpecflowTests
{
    [Binding]
    class AddLanguage
    {
        [Given(@"user clicked on the Language tab under Profile page")]
        public void GivenuserClickedOnTheLanguageTabUnderProfilePage()
        {
            //Wait
            Thread.Sleep(1500);

            // Click on Profile tab
            Driver.driver.FindElement(By.XPath("//a[text()='Profile']")).Click();


        }

        [When(@"user add a new language")]
        public void WhenIAddANewLanguage()
        {

            //adding english language

            //Click on Add New button
            Driver.driver.FindElement(By.XPath("//div[text()='Add New']")).Click();
            //Add Language
            Driver.driver.FindElement(By.XPath("//input[@placeholder='Add Language']")).SendKeys("English");
            //Click on Language Level
            Driver.driver.FindElement(By.XPath("//select[@class='ui dropdown']")).Click();
            Thread.Sleep(2000);
            //Choose the language level
            Driver.driver.FindElement(By.XPath("//select[@class='ui dropdown']//following::option[4]")).Click();
            //Click on Add button
            Driver.driver.FindElement(By.XPath("//input[@value='Add']")).Click();
            Thread.Sleep(5000);

            //adding Telugu language

            Driver.driver.FindElement(By.XPath("//div[text()='Add New']")).Click();
            //Add Language
            Driver.driver.FindElement(By.XPath("//input[@placeholder='Add Language']")).SendKeys("Telugu");
            //Click on Language Level
            Driver.driver.FindElement(By.XPath("//select[@class='ui dropdown']")).Click();
            Thread.Sleep(2000);
            //Choose the language level
            Driver.driver.FindElement(By.XPath("//select[@class='ui dropdown']//following::option[3]")).Click();
            //Click on Add button
            Driver.driver.FindElement(By.XPath("//input[@value='Add']")).Click();
            Thread.Sleep(5000);


            //adding Hindi language

            Driver.driver.FindElement(By.XPath("//div[text()='Add New']")).Click();
            //Add Language
            Driver.driver.FindElement(By.XPath("//input[@placeholder='Add Language']")).SendKeys("Hindi");
            //Click on Language Level
            Driver.driver.FindElement(By.XPath("//select[@class='ui dropdown']")).Click();
            Thread.Sleep(2000);
            //Choose the language level
            Driver.driver.FindElement(By.XPath("//select[@class='ui dropdown']//following::option[3]")).Click();
            //Click on Add button
            Driver.driver.FindElement(By.XPath("//input[@value='Add']")).Click();
            Thread.Sleep(5000);
        }

        [Then(@"that language should be displayed on my listings")]
        public void ThenThatLanguageShouldBeDisplayedOnMyListings()
        {


            Assert.IsTrue(Driver.driver.FindElement(By.XPath("//td[text()='English']")).Displayed);
            Assert.AreEqual("English", Driver.driver.FindElement(By.XPath("//td[text()='English']")).Text);
            try
            {
                //Start the Reports
                CommonMethods.ExtentReports();
                Thread.Sleep(1000);
                CommonMethods.test = CommonMethods.extent.StartTest("Add a Language");

                Thread.Sleep(1000);
                string ExpectedValue = "English";
                string ActualValue = Driver.driver.FindElement(By.XPath("//td[text()='English']")).Text;
                Thread.Sleep(500);
                if (ExpectedValue == ActualValue)
                {
                    CommonMethods.test.Log(LogStatus.Pass, "Test Passed, Added a Language Successfully");
                    SaveScreenShotClass.SaveScreenshot(Driver.driver, "LanguageAdded");
                }

                else
                    CommonMethods.test.Log(LogStatus.Fail, "Test Failed");

            }
            catch (Exception e)
            {
                CommonMethods.test.Log(LogStatus.Fail, "Test Failed", e.Message);
            }

        }

    }
}
   
