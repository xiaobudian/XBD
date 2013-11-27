using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace DataMining
{
    public class ExtractData
    {
        private string baseDataPth = AppDomain.CurrentDomain.BaseDirectory;
        private string originalDataPath = null;
        private string processedDataPath = null;

        private string[] originalDataFiles = null;
        private string[] processedDataFiles = null;

        public ExtractData()
        {
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
        }

        public void ExtractData()
        {
            string fileName = null;
            string orginalData = null;
            foreach (string orginalDataPath in originalDataFiles)
            {
                fileName = orginalDataPath.Substring(orginalDataPath.LastIndexOf('\\') + 2);
                if (processedDataFiles.Where(w => w.Contains(fileName)).Count() < 1)
                {
                    orginalData = File.ReadAllText(orginalDataPath, Encoding.UTF8);
                }
                Console.WriteLine(fileName);
            }
        }
    }
}
