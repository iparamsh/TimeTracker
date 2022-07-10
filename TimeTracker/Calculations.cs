using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TimeTracker
{
    public class Calculations
    {
        FileOperations fileOperations;
        private double hours = 0;
        private double breakTime = 0;
        public string moneyPerHour;
        public string timeTrack;

        public Calculations(FileOperations fileOperations, string timeTrack, string moneyPerHour)
        {
            this.fileOperations = fileOperations;
            this.timeTrack = timeTrack;
            this.moneyPerHour = moneyPerHour;
        }

        public double getTotalHours(string filePath)
        {
            string [] logs = fileOperations.getAllLogs(filePath);
            for (int ctr = 0; ctr < logs.Length; ctr++)
            {
                hours += getWorkedHours(logs[ctr].Substring(logs[ctr].IndexOf(" "), (logs[ctr].IndexOf("|") - logs[ctr].IndexOf(" "))));
                breakTime = (Int32.Parse(logs[ctr].Substring(logs[ctr].IndexOf("|") + 1)) / 60.0d);
            }
            hours -= breakTime;
            return hours;
        }

        private double getWorkedHours(string time)
        {
            string startTime = time.Substring(0, time.IndexOf("-"));
            string endTime = time.Substring(time.IndexOf("-") + 1);

            startTime = convertHoursToSiSystem(startTime);
            endTime = convertHoursToSiSystem(endTime);

            DateTime dt1 = DateTime.Parse(startTime);
            DateTime dt2 = DateTime.Parse(endTime);

            return (dt2 - dt1).TotalHours;
        }

        private string convertHoursToSiSystem(string time)
        {
            if (time.Contains("pm"))
            {
                int hr = Int32.Parse(time.Substring(0, time.IndexOf(":")));
                hr += 12;
                return hr.ToString() + time.Substring(time.IndexOf(":"));
            }
            return time.Substring(0, time.IndexOf("a"));
        }

        public double calculatePaycheck()
        {
            return this.hours * fileOperations.getWage(moneyPerHour);
        }
    }
}
