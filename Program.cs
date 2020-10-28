using System;

namespace EncodeFile
{
    class Program
    {
        static void Main(string[] args)
        {
            File inFile = new File();
            int count = 0;
            string[] file = inFile.GetFile(ref count);
            for(int i = 0; i < count; i++)
            {
                string message = "word";
                Console.WriteLine(message[0]);
                Console.WriteLine(file[i]);
            }
        }
    }
}
