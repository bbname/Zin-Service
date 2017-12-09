using System;
using System.IO;
using Zin_Service.BusinessLogic.CustomExceptions;

namespace Zin_Service.BusinessLogic.Logger.ReaderLog
{
    public class ReadLog : IReadLog
    {
        public bool IsFileLogExists()
        {
            return File.Exists(GetPathToLogFile());
        }

        public bool IsFileLogOpen()
        {
            if (IsFileLogExists())
            {
                FileStream stream = null;

                try
                {
                    var file = new FileInfo(GetPathToLogFile());
                    stream = file.Open(FileMode.Open, FileAccess.Read, FileShare.None);
                }
                catch (IOException)
                {
                    return true;
                }
                finally
                {
                    if (stream != null)
                    {
                        stream.Close();
                    }
                }

                return false;
            }
            else
            {
                throw new LogFileNotExistsException("Unable to check if is log file open, beacuse it doesn't exist.");
            }
        }

        private static string GetPathToLogFile()
        {
            try
            {
                var pathFolderLogger = Directory.GetParent(Directory.GetCurrentDirectory()).Parent.FullName;
                var pathProjectBusinessLogic = Directory.GetParent(pathFolderLogger).Parent.FullName;
                var pathSolution = Directory.GetParent(pathProjectBusinessLogic).Parent.FullName;
                var fullPathFileLog = pathSolution + "\\" + "Zin-Service.Service" + "\\Logs\\Log.txt";
                return fullPathFileLog;
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
        }
    }
}