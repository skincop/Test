using EpamTest.Pages;
using Newtonsoft.Json.Bson;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;
using System.Collections;

namespace EpamTests
{
    internal class Program
    {
        static void Main(string[] args)
        {
            test1();
            //test2();
            //test3();
            //test4();
        }

        static void test1()
        {
            PastebinHomePage page = new PastebinHomePage();
            page.openPage();
            page.writeTextToArea("Hello from WebDriver");
            page.writeTitle("helloweb");
            page.selectOptionsByXPath("//li[text()='10 Minutes']");
            page.createPaste();
        }
        static void test2()
        {

            PastebinHomePage page = new PastebinHomePage();
            page.openPage();
            page.writeTextToArea("git config --global user.name  \"New Sheriff in Town\"\r\ngit reset $(git commit-tree HEAD^{tree} -m \"Legacy code\")\r\ngit push origin master --force");
            page.writeTitle("how to gain dominance among developer");
            page.selectOptionsByXPath("//li[text()='10 Minutes']");
            page.selectHighlightsByXPath("//li[text()='Bash']");
            page.createPaste();
        }
        static void test3()
        {
            WebDriver driver = new ChromeDriver();
            driver.Navigate().GoToUrl("https://cloud.google.com/");
            driver.FindElement((By.XPath("//div[@class='devsite-search-container']"))).Click();
            IWebElement Search = driver.FindElement(By.XPath("//input[@class='devsite-search-field devsite-search-query']"));
            Search.Click();
            Search.SendKeys("Google Cloud Pricing Calculator");
            Search.SendKeys(Keys.Enter);
            Thread.Sleep(10000);
            driver.FindElement(By.XPath("//b[text()='Google Cloud Pricing Calculator']/parent::a")).Click();
            Thread.Sleep(10000);
            driver.Navigate().GoToUrl("https://cloud.google.com/products/calculator");
            IWebElement element = driver.FindElement(By.XPath("//iframe[contains(@name,'goog_')]"));
            driver.SwitchTo().Frame(element);
            driver.SwitchTo().Frame("myFrame");
            IWebElement numberOfInstancesField = driver.FindElement(By.XPath("//md-input-container/child::input[@ng-model='listingCtrl.computeServer.quantity']"));
            numberOfInstancesField.SendKeys("4");
            Thread.Sleep(2000);
            IWebElement Series = driver.FindElement(By.XPath("//*[@id=\"select_value_label_85\"]"));
            Series.Click();
            Thread.Sleep(2000);
            driver.FindElement(By.XPath("//md-option[@id='select_option_201']")).Click();
            Thread.Sleep(2000);
            IWebElement Machine_Family = driver.FindElement(By.XPath("//*[@id=\"select_value_label_86\"]"));
            Machine_Family.Click();
            Thread.Sleep(2000);
            driver.FindElement(By.XPath("//md-option[@value='CP-COMPUTEENGINE-VMIMAGE-N1-STANDARD-8']")).Click();

            Thread.Sleep(2000);
            driver.FindElement(By.XPath("//md-checkbox[@aria-label='Add GPUs']")).Click();
            Thread.Sleep(2000);
            driver.FindElement(By.XPath("//md-select[@placeholder='GPU type']")).Click();
            driver.FindElement(By.XPath("//md-option[@id='select_option_474']")).Click();

            Thread.Sleep(2000);
            driver.FindElement(By.XPath("//md-select[@placeholder='Number of GPUs']")).Click();
            driver.FindElement(By.XPath("//md-option[@id='select_option_477']")).Click();
            Thread.Sleep(2000);
            driver.FindElement(By.XPath("//md-select[@placeholder='Local SSD']")).Click();
            driver.FindElement(By.XPath("//md-option[@id='select_option_450']")).Click();

            /*     driver.FindElement(By.XPath("//md-select[@placeholder='Datacenter location']")).click();
                 driver.FindElement(By.XPath("//md-option[@id='select_option_229']")).click();
         */

            driver.FindElement(By.XPath("//md-select[@placeholder='Committed usage']")).Click();
            driver.FindElement(By.XPath("//md-option[@id='select_option_128']")).Click();

            driver.FindElement(By.XPath("//button[@aria-label='Add to Estimate']")).Click();
        }
        static void test4()
        {
            WebDriver driver = new ChromeDriver();

            driver.Navigate().GoToUrl("https://yopmail.com/en");
            driver.FindElement(By.XPath("//a[@href='email-generator']")).Click();
            Thread.Sleep(2000);
            driver.FindElement(By.XPath("//button[@id='cprnd']")).Click();
            Thread.Sleep(2000);

            ((IJavaScriptExecutor)driver).ExecuteScript("window.open()");
            IList<string> tabs = driver.WindowHandles;
            driver.SwitchTo().Window(tabs[1]);
            /* driver.get("https://cloud.google.com/");
             driver.FindElement((By.XPath("//div[@class='devsite-search-container']"))).Click();
             IWebElement Search = driver.FindElement(By.XPath("//input[@class='devsite-search-field devsite-search-query']"));
             Search.Click();
             Search.SendKeys("Google Cloud Pricing Calculator");
             Search.SendKeys(Keys.ENTER);
             Thread.Sleep(10000);
             driver.FindElement(By.XPath("//b[text()='Google Cloud Pricing Calculator']/parent::a")).Click();
             Thread.Sleep(10000);*/
            driver.Navigate().GoToUrl("https://cloud.google.com/products/calculator");
            IWebElement element = driver.FindElement(By.XPath("//iframe[contains(@name,'goog_')]"));
            driver.SwitchTo().Frame(element);
            driver.SwitchTo().Frame("myFrame");
            IWebElement numberOfInstancesField = driver.FindElement(By.XPath("//md-input-container/child::input[@ng-model='listingCtrl.computeServer.quantity']"));
            numberOfInstancesField.SendKeys("4");
            Thread.Sleep(2000);
            IWebElement Series = driver.FindElement(By.XPath("//*[@id=\"select_value_label_85\"]"));
            Series.Click();
            Thread.Sleep(2000);
            driver.FindElement(By.XPath("//md-option[@id='select_option_201']")).Click();
            Thread.Sleep(2000);
            IWebElement Machine_Family = driver.FindElement(By.XPath("//*[@id=\"select_value_label_86\"]"));
            Machine_Family.Click();
            Thread.Sleep(2000);
            driver.FindElement(By.XPath("//md-option[@value='CP-COMPUTEENGINE-VMIMAGE-N1-STANDARD-8']")).Click();

            Thread.Sleep(2000);
            driver.FindElement(By.XPath("//md-checkbox[@aria-label='Add GPUs']")).Click();
            Thread.Sleep(2000);
            driver.FindElement(By.XPath("//md-select[@placeholder='GPU type']")).Click();
            driver.FindElement(By.XPath("//md-option[@id='select_option_474']")).Click();

            Thread.Sleep(2000);
            driver.FindElement(By.XPath("//md-select[@placeholder='Number of GPUs']")).Click();
            driver.FindElement(By.XPath("//md-option[@id='select_option_477']")).Click();
            Thread.Sleep(2000);
            driver.FindElement(By.XPath("//md-select[@placeholder='Local SSD']")).Click();
            driver.FindElement(By.XPath("//md-option[@id='select_option_450']")).Click();

            /*   driver.FindElement(By.XPath("//md-select[@placeholder='Datacenter location']")).Click();
                 driver.FindElement(By.XPath("//md-option[@id='select_option_229']")).Click();
         */

            driver.FindElement(By.XPath("//md-select[@placeholder='Committed usage']")).Click();
            driver.FindElement(By.XPath("//md-option[@id='select_option_128']")).Click();

            driver.FindElement(By.XPath("//button[@aria-label='Add to Estimate']")).Click();
            driver.FindElement(By.XPath("//button[@aria-label='Email']")).Click();

            driver.FindElement(By.XPath("//input[@type='email']"))
                    .SendKeys(Keys.Control + "v");
            Thread.Sleep(2000);
            driver.FindElement(By.XPath("//button[@aria-label='Send Email']")).Click();
            driver.SwitchTo().Window(tabs[0]);
            driver.FindElement(By.XPath("/html/body/div/div[2]/main/div/div[2]/div/div/div[2]/button[2]/span")).Click();

        }
    }
}