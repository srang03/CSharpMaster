using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AwaitAsync
{
    public delegate void FileProgressDelegate (string currentUnit, string totalUnit, int percentage);
    public class FileUtil
    {
        public static void FileCopy(string sourceFile, string targetFile, FileProgressDelegate fileProgress)
        {
            if(File.Exists(sourceFile))
            {
                using (var sourceStream = new FileStream(sourceFile, FileMode.Open))
                {
                    using (var targetStream = new FileStream(targetFile, FileMode.Create))
                    {
                        long fileSize = sourceStream.Length;
                        int bufferSize = 10000;
                        byte[] data = new byte[bufferSize];

                        int read;
                        decimal totalRead = 0;

                        while((read = sourceStream.Read(data, 0, bufferSize)) > 0)
                        {
                            overwriteToZero(data);
                            targetStream.Write(data, 0, read);
                            totalRead += read;

                            if (fileProgress != null) fileProgress.Invoke(totalRead.ToString(), fileSize.ToString(), (int)((totalRead / fileSize) * 100));
                        }
                        targetStream.Close();
                    }
                    sourceStream.Close();
                }

            }
        }
        private static void overwriteToZero(byte[] data)
        {
            for(int i = 0; i<data.Length; i++)
            {
                data[i] = 0;
            }
        }
    }
}
