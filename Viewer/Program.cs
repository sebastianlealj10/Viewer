using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Chrome;

namespace Viewer
{
    class Program
    {
        static void Main(string[] args)
        {

            IWebDriver webDriver = new ChromeDriver();
            webDriver.Navigate().GoToUrl("https://uat-2.heretik.io/Relativity");
            webDriver.FindElement(By.Name("username")).SendKeys("robot@robot.com");
            webDriver.FindElement(By.Id("continue")).Click();
            webDriver.FindElement(By.Name("password")).SendKeys("Nserio.1");
            webDriver.FindElement(By.Id("_login")).Click();
            Thread.Sleep(10000);
            //webDriver.FindElement(By.CssSelector("div.fluid-item-list-cell-content > 	a[href*='Page'].fluid-item-list-cell-link")).Click();
            webDriver.Navigate().GoToUrl("https://uat-2.heretik.io/Relativity/External.aspx?AppID=1056078&ArtifactID=1003663&ArtifactTypeID=10&navigateListPage=True&DirectTo=%25applicationpath%25%2fCustomPages%2f2ff16b11-a4ca-4f02-8bbb-1f07f23fe713%2findex.html%3f%25appid%25%26%25artifacttypeid%25%26%25systemid%25&SelectedTab=1034251#/");
            Thread.Sleep(3000);
            webDriver.FindElement(By.XPath("fluid-item-list-cell-link")).Click();
            Thread.Sleep(3000);
            webDriver.Close();
        }
    }
}
