using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Timers;
using System.Configuration;

namespace GetAQIData
{
    public class ExtractData
    {
        private int seconds = 100;
        private Timer timer = null;
        private string baseDataPth = AppDomain.CurrentDomain.BaseDirectory;
        private string originalDataPath = null;
        private string processedDataPath = null;

        private string[] originalDataFiles = null;
        private string[] processedDataFiles = null;

        public ExtractData()
        {
            seconds = int.Parse(ConfigurationSettings.AppSettings["internal"]);
            originalDataPath = baseDataPth + @"..\..\..\Data\OriginalData\";
            processedDataPath = baseDataPth + @"..\..\..\Data\ProcessedData\";
            if (!Directory.Exists(originalDataPath))
            {
                Directory.CreateDirectory(originalDataPath);
            }
            if (!Directory.Exists(processedDataPath))
            {
                Directory.CreateDirectory(processedDataPath);
            }

            originalDataFiles = Directory.GetFiles(originalDataPath);
            processedDataFiles = Directory.GetFiles(processedDataPath);
            timer = new Timer();
            timer.Interval = 10;
            timer.Enabled = true;
            timer.Elapsed += new ElapsedEventHandler(timer_Elapsed);

        }

        void timer_Elapsed(object sender, ElapsedEventArgs e)
        {
            timer.Interval = seconds * 1000;
            Extract();
        }

        private void Extract()
        {
            string fileName = null;
            string orginalData = null;
            foreach (string orginalDataPath in originalDataFiles)
            {
                fileName = orginalDataPath.Substring(orginalDataPath.LastIndexOf('\\') + 2);
                if (processedDataFiles.Where(w => w.Contains(fileName)).Count() < 1)
                {
                    Console.WriteLine("Extract" + fileName);
                    orginalData = File.ReadAllText(orginalDataPath, Encoding.UTF8);
                }
            }
        }

        public void Start()
        {
            timer.Start();
        }
    }
}
