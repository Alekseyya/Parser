using AutopiterParser.Selenium.Services.Base;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Interactions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace AutopiterParser.Selenium.Services
{
    public class DataService : IDataService
    {
        private readonly IWebDriver _browser;
        private const string _login = 
        private const string _pass =

        public DataService()
        {
            _browser = new ChromeDriver();            
        }
        public void SetPage(string url)
        {
            _browser.Navigate().GoToUrl(url);            
        }

        public void SingUp()
        {
            try
            {
                _browser.FindElement(By.CssSelector("input#UserName")).SendKeys(_login);
                _browser.FindElement(By.CssSelector("input#Password")).SendKeys(_pass);
                _browser.FindElement(By.CssSelector("input#LoginButton")).Click();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void FindArticle(string article)
        {
            try
            {
                _browser.FindElement(By.CssSelector("input#SearchNumber")).SendKeys(article);
                Thread.Sleep(1000);
                _browser.FindElement(By.CssSelector(".search-line-group > input#btnSearchCatalog")).Click();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
