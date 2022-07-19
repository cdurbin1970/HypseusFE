using System;
using System.IO;
using System.Reflection;
using System.Runtime.InteropServices;

namespace LogEntry {
    public static class ClLogEntry {
        /// <summary>Write a log entry to logs/ directory. Creates dir if it does not exist. Log is named yyyy_mm_dd_log.log</summary>
        /// <param name="message">Message to be logged</param>
        public static void WriteLogEntry(string message) {
            try {
                var dir = RuntimeInformation.IsOSPlatform(OSPlatform.Linux) ? Directory.GetCurrentDirectory() + "/logs/" : Directory.GetCurrentDirectory() + "\\logs\\";
                if (!Directory.Exists(dir)) {
                    Directory.CreateDirectory(dir);
                }
                var file = new StreamWriter(dir + DateTime.Now.ToString("yyyy_MM_dd") + "_log.log", true);
                file.WriteLine(DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss ") + Assembly.GetEntryAssembly()?.GetName().Name + " " + message);
                file.Close();
            }
            catch (Exception) {
                // ignored
            }
        }
    }
}
