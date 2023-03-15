using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;

namespace CSharpMaster.StreamReview
{
    public class FileStreamWithSerialization
    {
        readonly static string fileName = "FilewStreamWithSerialization.dat";
        
        public static void Write(Person p)
        {
            using (var stream = new FileStream(fileName, FileMode.Create))
            {
                BinaryFormatter bf = new BinaryFormatter();

                bf.Serialize(stream, p);
                stream.Close();
            }
        }

        [Serializable]
        public class Person
        {
            [NonSerialized]
            public int id;
            public string name;
            public string description;

            public int Id { get { return id; } }

            public Person(int iId, string strName, string strDescription)
            {
                this.id = iId;
                this.name = strName;
                this.description = strDescription;
            }
        }
    }
}
