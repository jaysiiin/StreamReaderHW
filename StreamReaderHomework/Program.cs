using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;


namespace StreamReaderHomework
{
    class Program
    {
        static void Main(string[] args)
        {
            //StreamReader reader = new StreamReader("..\\..\\..\\Shakespeare.txt");
            //string line = reader.ReadLine();
            //Console.WriteLine(line);
            //Console.WriteLine();

            //using (reader)
            //{
            //    while (line != null)
            //    {
                    
            //        Console.WriteLine(line);
            //        line = reader.ReadLine();
                    
            //    }
                
            //}

            StreamReader readerTwo = new StreamReader("..\\..\\..\\Shakespeare.txt");
            string line = readerTwo.ReadLine();

            using (readerTwo)
            {

                string upper = line.Replace("a", "A")
                                    .Replace("e", "E")
                                    .Replace("i", "I")
                                    .Replace("o", "O")
                                    .Replace("u", "U");


                Console.WriteLine(upper);

            }
        }



      
    }
}
