using System;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

namespace CSharpMaster
{
    public class SerializationExample
    {
        readonly static string fileName = "SerializationStream.dat";

        public static void Write(Player player)
        {
            // 1. 스트림 선언하고 파일 스트림을 메모리에 할당
            using (Stream writeStream = new FileStream(fileName, FileMode.Create))
            {
                // 2. 객체를 직렬화 또는 역직렬화하여 데이터를 저장하거나 불러올 때 사용
                BinaryFormatter binaryFormatter = new BinaryFormatter();

                // 3. Serialize() : 직렬화 된 player 클래스의 맴버 변수들을 파일에 저장
                binaryFormatter.Serialize(writeStream, player);
                writeStream.Close();
            }
        }

        public static bool Read(out Player readData)
        {
            readData = null;
            if (File.Exists(fileName))
            {
                using (Stream ReadStream = new FileStream(fileName, FileMode.Open))
                {
                    // 2. 객체를 직렬화 또는 역직렬화하여 데이터를 저장하거나 불러올 때 사용
                    BinaryFormatter binaryFormatter = new BinaryFormatter();

                    readData = binaryFormatter.Deserialize(ReadStream) as Player;
                    ReadStream.Close();
                }
            }
            return false;
        }
    }

    // 직렬화를 하기 위한 클래스, 구조체 앞에 Serializable Attribute 정의
    [Serializable]
    public class Player
    {
        public string nickName;
        public bool active;

        // 직렬화 대상에서 제외하고 싶은 맴버 변수
        [NonSerialized]
        public string name;
        [NonSerialized]
        public int age;
        [NonSerialized]
        public string phone;

        public Player(string name, string nickName, int age, string phone, bool active)
        {
            this.name = name;
            this.age = age;
            this.phone = phone;
            this.active = active;
            this.nickName = nickName;
        }

        public void PrintInfo()
        {
            Console.WriteLine($"[{nickName}] {active}");
        }

    }
}
