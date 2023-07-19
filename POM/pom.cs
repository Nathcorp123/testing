using finalspecflow.Hooks;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace finalspecflow.POM
{
    class pom
    {
        public void clickLogin()
        {
            string login = "//a[normalize-space()='Login']";
            Hooks1.driver.FindElement(By.XPath(login)).Click();
        }
        public void enterEmail(string emailid, string password)  //| emailid | password |
        {
            string enteremailid = "//input[@placeholder='youremail@example.com']";
            Hooks1.driver.FindElement(By.XPath(enteremailid)).SendKeys(emailid);
            Thread.Sleep(5000);
            string passwordd = "//input[@placeholder='Password']";
            Hooks1.driver.FindElement(By.XPath(passwordd)).SendKeys(password);
           Thread.Sleep(5000);
            
        }

        public void login()
        {
            string login = "//input[@name='btn-submit']";
            Hooks1.driver.FindElement(By.XPath(login)).Click();
            Thread.Sleep(5000);
        }




    }
}
