using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace SOLIDPrinciple.Repository.SystemManager
{
    public static class Helper
    {
        public static void Text(string data)
        {
            string path = HttpContext.Current.Server.MapPath($"~/Error/{BdTime().ToString("MMM-yyyy")}/");
            if (!Directory.Exists(path))
            {
                Directory.CreateDirectory(path);
            }
            RemoveDirectory(HttpContext.Current.Server.MapPath("~/Error/"));
            path += $"{BdTime():dd}-Error.txt";
            StreamWriter sw;
            if (!File.Exists(path))
            {
                // Create a file to write to.
                sw = File.CreateText(path);
                sw.WriteLine(BdTime().ToString("hh-mm-ss-tt") + " Error :{ " + data + " }");
                sw.Close();
            }
            else
            {
                //append text when file is exists
                sw = File.AppendText(path);
                sw.WriteLine(Environment.NewLine + BdTime().ToString("hh-mm-ss-tt") + " Error :{ " + data + " }");
                sw.Close();
            }
        }

        public static void RemoveDirectory(string path)
        {
            foreach (string file in Directory.GetDirectories(path))
            {
                if ((new FileInfo(file)).LastAccessTime < DateTime.Now.AddDays(-30))
                    Directory.Delete(file, true);
            }
        }

        public static void RemoveFile(string path)
        {
            File.Delete(path);
        }


        public static DateTime BdTime()
        {
            return TimeZoneInfo
                .ConvertTimeFromUtc(
                    DateTime.UtcNow, TimeZoneInfo.FindSystemTimeZoneById("Bangladesh Standard Time")
                    );
        }

        public static DateTime? BdTime(DateTime? dateTime)
        {
            return dateTime.HasValue ? TimeZoneInfo
                .ConvertTime(dateTime ?? DateTime.UtcNow, TimeZoneInfo
                .FindSystemTimeZoneById("Bangladesh Standard Time")) : default(DateTime?);
        }
    }
}
