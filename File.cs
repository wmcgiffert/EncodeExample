using System;
using System.IO;


namespace EncodeFile
{
    public class File
    {
        public string[] GetFile(ref int count)
        {
            StreamReader inFile = new StreamReader("input.txt");
            string[] file =new string[50];
            string message = inFile.ReadLine();

            while (message != null)
            {
                file[count] = (message + " ");
                count++;
                message = inFile.ReadLine();                
            }

            inFile.Close();

            return file;
        }
    }
}