using System.IO;

namespace CSharpMaster.StreamReview
{
    public class FileStreamWithBinaryStream
    {
        private static readonly string file = "FileStreamWithBinaryStream.dat";

        public static void Write(string writeData)
        {
            if (!File.Exists(file))
            {
                using (var stream = new FileStream(file, FileMode.Create))
                {
                    using(var binaryStream = new BinaryWriter(stream))
                    {
                        binaryStream.Write(writeData);
                        binaryStream.Close();
                    }
                    stream.Close();
                }
            }
            else
            {
                using(var stream = new FileStream(file, FileMode.Append))
                {
                    using(var binaryWriter = new BinaryWriter(stream))
                    {
                        binaryWriter.Write(writeData);
                        binaryWriter.Close();
                    }
                    stream.Close();
                }
            }
         
        }
        public static void Read()
        {
            using(var stream = new FileStream(file, FileMode.Open))
            {
                using(var binaryReader = new BinaryReader(stream))
                {
                    while (binaryReader.BaseStream.Position < binaryReader.BaseStream.Length)
                    {
                        var temp = binaryReader.ReadString();
                    }
                    binaryReader.Close();
                }
                stream.Close();
            }
        }
    }
}
