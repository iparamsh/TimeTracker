using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace TimeTracker
{
    public class FileOperations
    {
        public double getWage(string filePath)
        {
            return System.Convert.ToDouble(File.ReadAllText(filePath));
        }
        public void createFileIfNotCreated(string filePath)
        {
            if (!File.Exists(filePath))
            {
                var myFile = File.CreateText(filePath);
                myFile.Close();
            }
        }

        public void writeToFileAndDelete(string filePath, string text)
        {
            File.WriteAllText(filePath, text);
        }
        public string checkMoneyPerHour(string filePath)
        {
            return File.ReadAllText(filePath);
        }
        public void addLogToFile(string filePath, string log)
        {
            List<string> logs = File.ReadAllLines(filePath).ToList();
            logs.Add(log);
            File.WriteAllLines(filePath, logs);
        }
        public void deleteFile(string filePath)
        {
            File.WriteAllText(filePath, "");
        }
        public string[] getAllLogs(string filePath)
        {
          return File.ReadAllLines(filePath);
        }
    }
}
