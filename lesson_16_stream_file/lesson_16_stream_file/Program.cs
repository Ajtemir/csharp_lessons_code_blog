using System;
using System.IO;
using System.IO.Compression;
using System.Text;

namespace lesson_16_stream_file
{
    class Program
    {
        static void Main(string[] args)
        {
            // hdd ssd
            // участок памяти - файл
            // + метаданные для правильного чтения
            // ram
            
            // stream нерпрерывный поток
            // запись и чтение
            // данные хранятся в двоичном формате
            // UTF-8 best
            // ascii second
            // dispose уничтожение
            
            // open 
            // read 
            // write
            // close
            
            // absolute path or closed path

            using (var sw = new StreamWriter("test.txt", append:true, Encoding.ASCII))
            {
                sw.Write("Hello, World");
                sw.WriteLine("Hello, User");
                // sw.WriteLine("аивпт");
            }

            using (var sr = new StreamReader("test.txt", Encoding.UTF8))
            {
                var text = sr.ReadToEnd();
                Console.WriteLine(text);
                while (!sr.EndOfStream)
                {
                    Console.WriteLine(sr.ReadLine() + "конец");
                }
            }
        }
    }
}