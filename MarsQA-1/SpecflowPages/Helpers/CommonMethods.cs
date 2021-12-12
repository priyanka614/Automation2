﻿using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RelevantCodes.ExtentReports;


namespace MarsQA_1.Helpers
{
    public class CommonMethods
    {
        //Screenshots
        #region screenshots
        public class SaveScreenShotClass
        {
            
            public static string SaveScreenshot(IWebDriver driver, string ScreenShotFileName) // Definition
            {
                var folderLocation = (ConstantHelpers.ScreenshotPath);

                if (!System.IO.Directory.Exists(folderLocation))
                {
                    System.IO.Directory.CreateDirectory(folderLocation);
                }

                var screenShot = ((ITakesScreenshot)driver).GetScreenshot();
                var fileName = new StringBuilder(folderLocation);

                fileName.Append(ScreenShotFileName);
                fileName.Append(DateTime.Now.ToString("_dd-mm-yyyy_mss"));
                //fileName.Append(DateTime.Now.ToString("dd-mm-yyyym_ss"));
                fileName.Append(".jpeg");
                screenShot.SaveAsFile(fileName.ToString(), ScreenshotImageFormat.Jpeg);
                return fileName.ToString();
            }
        }
        #endregion


        //ExtentReports
        #region reports
        public static ExtentTest test;
        public static ExtentReports extent;
        internal static object Extent;

        public static void ExtentReports()
        {
            extent = new ExtentReports(ConstantHelpers.ReportsPath, true, DisplayOrder.NewestFirst);
            extent.LoadConfig(ConstantHelpers.ReportXMLPath);
        }
    }
    #endregion

}


