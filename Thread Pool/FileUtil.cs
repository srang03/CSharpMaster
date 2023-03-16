using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Thread_Pool
{
    public class FileUtil
    {
        public delegate void FileProgressDelegate(string currentUnits, string TotalUnits, int Percentage);
        public static void Copy(string sourceFile, string destFile, FileProgressDelegate fileProgress)
        {
            using(FileStream sourceStream = new FileStream(sourceFile, FileMode.Open))
            {
                using(FileStream desStream = new FileStream(destFile, FileMode.Create))
                {
                    long fileSize = sourceStream.Length;
                    int bufferSize = 4096;
                    byte[] buffer = new byte[bufferSize];

                    int read;
                    decimal totalRead = 0;

                    while ((read = sourceStream.Read(buffer, 0, bufferSize)) > 0)
                    {
                        desStream.Write(buffer, 0, read);
                        totalRead += read;

                        if(fileProgress != null)
                        {
                            fileProgress.Invoke(totalRead.ToString(), fileSize.ToString(), (int)((totalRead / fileSize) * 100));
                        }
                    }

                    desStream.Close();
                }
                sourceStream.Close();
            }
        }
    }
}
