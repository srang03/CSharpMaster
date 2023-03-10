using CSharpMaster.StreamReview;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CSharpMaster
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_write_Click(object sender, EventArgs e)
        {
            FileStreamExample.WriteToFile(33);
            FileStreamExample.ReadFromFile(out int res);
            Console.WriteLine(res);
        }

        private void btn_binaryStream_Click(object sender, EventArgs e)
        {
            BinaryStreamExample.WriteStream(55);
            BinaryStreamExample.ReadStream(out int res);
            Console.WriteLine(res);
        }

        private void btn_streamWritera_Click(object sender, EventArgs e)
        {
            TextFileStreamWriterExample.WriteToTextFile("안녕하세요");
            TextFileStreamWriterExample.ReadFromTextFile(out string[] res);
            foreach(string s in res) 
            {
                Console.WriteLine(s);
            }
        }

        private void btn_serialize_Click(object sender, EventArgs e)
        {
            SerializationExample.Write(new Player("성우", "하이", 23, "01012345678", true));
            SerializationExample.Read(out Player res);

            Console.WriteLine(res);
        }

        private void btn_onlyFileStream_Click(object sender, EventArgs e)
        {
            FileStreamWithBinaryBitConverter.Write(1);
            FileStreamWithBinaryBitConverter.Write(2);
            FileStreamWithBinaryBitConverter.Write(3);
            FileStreamWithBinaryBitConverter.Write(4);
            FileStreamWithBinaryBitConverter.Write(5);
            FileStreamWithBinaryBitConverter.Read();
        }

        private void btn_binaryStreamReview_Click(object sender, EventArgs e)
        {
            FileStreamWithBinaryStream.Write("Hello");
            FileStreamWithBinaryStream.Write("How");
            FileStreamWithBinaryStream.Write("Are");
            FileStreamWithBinaryStream.Write("You");
            FileStreamWithBinaryStream.Read();
        }

        private void btn_streamWriter_Click(object sender, EventArgs e)
        {
            FileStreamWithStreamWriter.Write("ABC");
            FileStreamWithStreamWriter.Write("DEF");
            FileStreamWithStreamWriter.Write("HIJ");
            FileStreamWithStreamWriter.Read();
        }
    }
}
