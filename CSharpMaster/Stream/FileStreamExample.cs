using System;
using System.IO;

namespace CSharpMaster
{
    public class FileStreamExample
    {
        readonly static string fileName = "FileStream.dat";
        // 파일 쓰기
        public static bool WriteToFile(int writeData)
        {
            // 1. 파일 스트림 생성
       
                using (Stream writeStream = new FileStream(fileName, FileMode.Create))
                {
                    // 2. c# 데이터를 byte[] 형태로 변환
                    byte[] writeBytes = BitConverter.GetBytes(writeData);

                    // 3. byte[] 데이터를 파일 스트림을 통해 파일에 기록
                    // 첫 번째 파라미터 buffer는 byte[] 배열로 스트림에 Write할 데이터 정보를 담고 있습니다.
                    // 두 번째 파라미터 offset은 스트림으로 전달할 byte[] 배열의 시작점을 의미합니다.
                    // 세 번째 파라미터 count는 전달할 byte[] 배열의 길이를 설정합니다.
                    writeStream.Write(writeBytes, 0, writeBytes.Length);

                    // 4. 파일 스트림 닫기
                    writeStream.Close();
                }
                return true;
           
        }

        // 파일 읽기
        public static bool ReadFromFile(out int readData)
        {
            byte[] readBytes = new byte[1024];
            readData = default(int);
            // 1. 파일 스트림 생성
            if (File.Exists(fileName))
            {
                using (Stream readStream = new FileStream("FileStream.dat", FileMode.Open))
                {
                    // 2. 파일에서 읽어서 메모리 저장
                    readStream.Read(readBytes, 0, readBytes.Length);

                    // 3. 읽어온 데이터를 int형으로 변환
                    readData = BitConverter.ToInt32(readBytes, 0);
                    Console.WriteLine($"{readData}");

                    // 4. 파일 스트림 닫기
                    readStream.Close();
                }
                return true;
            }
            return false;
        }
    }
}
