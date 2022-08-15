using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HandlingExceptions
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                string content = File.ReadAllText(@"C:\git\adiaz-backend-tutorial\example.txt");
                Console.WriteLine(content);
            }
            catch (FileNotFoundException ex)
            {
                Console.WriteLine("Hey there. There was a problem!");
                Console.WriteLine("Make sure you type the file name correctly: exampl.txt");
            }
            catch (DirectoryNotFoundException ex)
            {
                Console.WriteLine("Hey there. There was a problem!");
                Console.WriteLine(@"Make sure the directory 'C:\git\adiaz-backend-tutorial\' exist");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Hey there. There was a problem!");
                Console.WriteLine(ex.Message);
            }
            finally
            {
                Console.WriteLine("Closing application now...");
            }
            Console.ReadLine();
            ;        }
    }
}
