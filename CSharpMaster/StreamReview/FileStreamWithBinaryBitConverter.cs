using System;
using System.IO;

namespace CSharpMaster.StreamReview
{
    public class FileStreamWithBinaryBitConverter
    {
        private static readonly string file = "FileStreamWithBinaryBitConverter.dat";

        public static void Write(int writeData)
        {
            if (!File.Exists(file))
            {
                using (var stream = new FileStream(file, FileMode.Create))
                {
                    byte[] writeBytes = BitConverter.GetBytes(writeData);

                    stream.Write(writeBytes, 0, writeBytes.Length);
                    stream.Close();
                }
            }
            else
            {
                using (var stream = new FileStream(file, FileMode.Append))
                {
                    byte[] writeBytes = BitConverter.GetBytes(writeData);

                    stream.Write(writeBytes, 0, writeBytes.Length);
                    stream.Close();
                }
            }
        }

        public static bool Read()
        {
            byte[] readBytes;

            if (File.Exists(file))
            {
                using (var stream = new FileStream(file, FileMode.Open))
                {
                    readBytes = new byte[stream.Length];
                    var res = stream.Read(readBytes, 0, readBytes.Length);
                    // var readData = BitConverter.ToInt32(res, 0);
                    for (int i = 0; i < readBytes.Length; i += sizeof(int))
                    {
                        var readData = BitConverter.ToInt32(readBytes, i);
                    }
                }
                return true;
            }
            return false;
        }
    }
}
