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
    class Modal_Dialogs : Selenium_Base
    {
        public void SmallModal(IWebDriver Driver)
        {
            open("https://demoqa.com/alertsWindows");
            wait(500);

            scrollPage(0, 500);
            wait(500);

            click(FindXPath("//span[text()='Modal Dialogs']"));
            wait(2000);

            click(FindXPath("//button[@id='showSmallModal']"));
            wait(2000);

            switchToActive();
            wait(2000);

            click(FindXPath("//button[@id='closeSmallModal']"));
            wait(2000);
        }

        public void LargeModal(IWebDriver Driver)
        {
            click(FindXPath("//button[@id='showLargeModal']"));
            wait(2000);

            switchToActive();
            wait(2000);

            click(FindXPath("//button[@id='closeLargeModal']"));
            wait(2000);

            close();

        }
    }
}
