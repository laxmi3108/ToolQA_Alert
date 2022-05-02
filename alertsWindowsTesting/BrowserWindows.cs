using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using DemoQASite;

namespace alertsWindowsTesting
{
    class BrowserWindows : Selenium_Base
    {
      
        public void NewTab(IWebDriver Driver)
        {
            open("https://demoqa.com/alertsWindows");
            wait(500);

            scrollPage(0, 500);
            wait(500);

            click(FindXPath("//*[text()='Browser Windows']"));
            wait(2000);

            click(FindID("tabButton"));
            wait(2000);

            switchToWindow(1);
            close();
            wait(2000);
            switchToWindow(0);
            wait(2000);

        }

        public void NewWindow(IWebDriver Driver)
        {
            click(FindID("windowButton"));
            wait(2000);

            switchToWindow(1);
            close();
            wait(2000);
            switchToWindow(0);
            wait(2000);
        }

        public void NewWindowMessage(IWebDriver Driver)
        {
            click(FindID("messageWindowButton"));
            wait(2000);

            switchToWindow(1);
            close();
            wait(2000);
            switchToWindow(0);
            wait(2000);

            close();
            wait(2000);
        }
    }
}
