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
    class Alert : Selenium_Base
    {
        public void SimpleAlert(IWebDriver Driver)
        {
            open("https://demoqa.com/alertsWindows");
            wait(500);

            scrollPage(0, 500);
            wait(500);

            click(FindXPath("//*[text()='Alerts']"));
            wait(2000);

            click(FindXPath("//button[@id='alertButton']"));
            wait(2000);

            switchToAlert();
            wait(2000);
            acceptAlert();
            wait(2000);
        }

        public void TimeAlert(IWebDriver Driver)
        {
            click(FindXPath("//button[@id='timerAlertButton']"));
            wait(6000);

            switchToAlert();
            wait(2000);
            acceptAlert();
            wait(2000);
            
        }

        public void ConfirmAlert(IWebDriver Driver)
        {
            click(FindXPath("//button[@id='confirmButton']"));
            wait(2000);

            switchToAlert();
            wait(2000);
            rejectAlert();
            wait(2000);
            
        }

        public void PromtAlert(IWebDriver Driver)
        {
            click(FindXPath("//button[@id='promtButton']"));
            wait(2000);

            switchToAlert();
            wait(2000);
            sendKeysToAlert("PromtButton Successfully Done");
            wait(2000);
            acceptAlert();
            wait(2000);

            close();
        }
    }
}
