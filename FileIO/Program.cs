
using System.IO;
using System.IO;

namespace FileIO
{
    public class Program
    {
        static void Main(string[] args)
        {
            try
            {
                string path = @"C:\Users\akshata\source\fieio\MyDirectory\MyAnotherDirectory\NewFile.txt";
                using (FileStream fs = new FileStream(path, FileMode.Open, FileAccess.Read))
                {
                    using (StreamReader sr = new StreamReader(fs))
                    {
                        string line = sr.ReadLine();
                        Console.WriteLine(line);
                    }

                }
            }
            catch(Exception e)
            {
                Console.WriteLine("Error Message :"+e.Message);
            }
            

            






        }
    }
}