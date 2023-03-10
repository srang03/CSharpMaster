using System.IO;

namespace CSharpMaster
{
    public class TextFileStreamWriterExample
    {
        readonly static string fileName = "StreamWriter.dat";

        public static void WriteToTextFile(string writeData)
        {
            using (Stream stream = new FileStream(fileName, FileMode.Create))
            {
                using (StreamWriter sw = new StreamWriter(stream))
                {
                    sw.WriteLine(writeData);
       

                    sw.Close();
                }
                stream.Close();
            }
        }

        public static bool ReadFromTextFile(out string[] readData)
        {
            readData = new string[2];
            if (File.Exists(fileName))
            {
                using (Stream stream = new FileStream(fileName, FileMode.Open))
                {
                    using (StreamReader sr = new StreamReader(stream))
                    {
                        int i = 0;
                        while (!sr.EndOfStream)
                        {
                            readData[i] = sr.ReadLine();
                            i += 1;
                        }
                        sr.Close();
                    }
                    stream.Close ();
                }
                return true;
            }
            return false;
        }
    }
}
