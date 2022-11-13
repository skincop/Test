using EpamTest.Pages;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;

namespace EpamTest
{
    public class Tests
    {
        PastebinHomePage page = new PastebinHomePage();
        [SetUp]
        public void Setup()
        {
            page.openPage();
        }

        [Test]
        public void Test1()
        {
            page.writeTextToArea("Hello from WebDriver");
            page.writeTitle("helloweb");
            page.selectOptionsByXPath("//li[text()='10 Minutes']");
            Assert.Pass();

        }
    }
}