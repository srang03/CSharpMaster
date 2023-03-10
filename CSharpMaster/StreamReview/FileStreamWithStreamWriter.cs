using System.IO;
using System.Security.Cryptography;

namespace CSharpMaster.StreamReview
{
    public class FileStreamWithStreamWriter
    {
        private static readonly string file = "FileStreamWithStreamWriter.dat";

        public static void Write(string writeText)
        {
            if (!File.Exists(file))
            {
                using (var stream = new FileStream(file, FileMode.Create))
                {
                    using (var sw = new StreamWriter(stream))
                    {
                        sw.WriteLine(writeText);
                        sw.Close();
                    }
                    stream.Close();
                }
            }
            else
            {
                using (var stream = new FileStream(file, FileMode.Append))
                {
                    using (var sw = new StreamWriter(stream))
                    {
                        sw.WriteLine(writeText);
                        sw.Close();
                    }
                    stream.Close();
                }
            }
        }

        public static bool Read()
        {
            if (File.Exists(file))
            {
                using(var stream = new FileStream(file, FileMode.Open))
                {
                    using(var sr = new StreamReader(stream))
                    {
                        while (!sr.EndOfStream)
                        {
                            var temp = sr.ReadLine();
                        }
                        sr.Close();
                    }
                    stream.Close();
                }
                return true;
            }
            return false;
        }
    }
}
