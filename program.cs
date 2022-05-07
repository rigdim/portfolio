using System.IO;
using System.Threading;
using System.Text;
using System;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.DarkGreen;

            string text = "";

            using (var fstream = new FileStream("text.txt", FileMode.Open))
            {
                byte[] buffer = new byte[fstream.Length];
                fstream.Read(buffer, 0, buffer.Length);
                text = Encoding.Default.GetString(buffer);
            }

            foreach (char ch in text)
            {
                    Console.Write(ch);

                    bool space = ch == ' ';

                    if (space)
                        Thread.Sleep(60);
                    else
                        Thread.Sleep(40);
            }

            Console.ReadKey();
        }
    }
}
