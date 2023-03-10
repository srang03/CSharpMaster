using System.IO;

namespace CSharpMaster
{
    public class BinaryStreamExample
    {
        readonly static string FileName = "BinaryFileStream.dat";

        public static void WriteStream(int writeData)
        {

            using (Stream writeStream = new FileStream(FileName, FileMode.Create))
            {
                using (BinaryWriter binaryWriter = new BinaryWriter(writeStream))
                {
                    binaryWriter.Write(writeData);


                    binaryWriter.Close();
                }
                writeStream.Close();

            }

        }

        public static bool ReadStream(out int readData)
        {
            readData = default(int);
            if (File.Exists(FileName))
            {
                using (Stream readStream = new FileStream(FileName, FileMode.Open))
                {
                    using (BinaryReader binaryReader = new BinaryReader(readStream))
                    {
                        readData = binaryReader.ReadInt32();
                        
                        binaryReader.Close();
                    }
                    readStream.Close();
                }
                return true;
            }
            return false;
        }
    }
}
