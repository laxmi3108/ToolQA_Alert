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
    class Frames : Selenium_Base
    {
        public void Frame(IWebDriver Driver)
        {
            open("https://demoqa.com/alertsWindows");
            wait(500);

            scrollPage(0, 500);
            wait(500);

            click(FindXPath("//span[text()='Frames']"));
            wait(2000);

            switchToFrame(0);
            wait(2000);

            switchToDefault();
            wait(2000);

            scrollPage(0, 400);
            wait(500);

            switchToanotherFrame("//iframe[@id='frame2']");
            wait(2000);

            scrollPage(0, 300);
            wait(2000);

            scrollPage(200, 0);
            wait(2000);

            scrollPage(0, -300);
            wait(2000);

            scrollPage(-200, 0);
            wait(2000);

            switchToDefault();
            wait(2000);
            
        }

        public void NestedFrame(IWebDriver Driver)
        {
            scrollPage(0, 200);
            wait(2000);

            click(FindXPath("//span[text()='Nested Frames']"));
            wait(2000);

            scrollPage(0, 200);
            wait(2000);


            switchToanotherFrame("//iframe[@id='frame1']"); 
            wait(2000);

            //Switch to Child Frames
            switchToanotherFrame("//iframe[@srcdoc='<p>Child Iframe</p>']");
            wait(2000);

            //Switch to Parent Frames
            switchToParentFrame();
            wait(2000);

            switchToDefault();
            wait(2000);

            Console.WriteLine("Successfull");
            wait(2000);

            close();

        }

    }
}
