using System;
using AutopiterParser.Selenium.Services;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AutopiterParser.Tests
{
    [TestClass]
    public class SeleniumTests
    {
        private readonly DataService _service;
        public SeleniumTests()
        {
            _service = new DataService();
        }
        [TestMethod]
        public void GetUrlTest()
        {
            _service.SetPage("https://www.yandex.ru/");
        }

        [TestMethod]
        public void SingUpTest()
        {
            _service.SetPage("http://www.autopiter.ru/");
            _service.SingUp();
        }
        
        [TestMethod]
        public void FindArticleTest()
        {            
            _service.SetPage("http://www.autopiter.ru/");
            _service.SingUp();
            _service.FindArticle("AAAA");
        }
    }
}
