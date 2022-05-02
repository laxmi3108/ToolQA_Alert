using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Interactions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace alertsWindowsTesting
{
    public class Program
    {
        static void Main(string[] args)
        {
            IWebDriver Driver = null;

            BrowserWindows browserWindows = new BrowserWindows();

            browserWindows.NewTab(Driver);

            browserWindows.NewWindow(Driver);

            browserWindows.NewWindowMessage(Driver);
            Thread.Sleep(2000);

            Alert alert = new Alert();

            alert.SimpleAlert(Driver);

            alert.TimeAlert(Driver);

            alert.ConfirmAlert(Driver);

            alert.PromtAlert(Driver);

            Frames frames = new Frames();

            frames.Frame(Driver);

            frames.NestedFrame(Driver);

            Modal_Dialogs modal_Dialogs = new Modal_Dialogs();
            
            modal_Dialogs.SmallModal(Driver);

            modal_Dialogs.LargeModal(Driver);
        }
    }
}
