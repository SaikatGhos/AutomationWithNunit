using AventStack.ExtentReports;
using AventStack.ExtentReports.Reporter;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpenMRS
{
    class ExtentMangaer
    {
        private static ExtentReports extent;

        public static ExtentReports getInstance()
        {
            if (extent == null)
            {
                string reportPath = @"C:\Users\SAIKAT\source\repos\TestProject1\OpenMRS\Report_OMRS.html";
                ExtentHtmlReporter htmlReporter = new ExtentHtmlReporter(reportPath);
                extent = new ExtentReports();
                extent.AttachReporter(htmlReporter);
                extent.AddSystemInfo("OS","Windows");
                


            }

            return extent;
        }
    }
}
