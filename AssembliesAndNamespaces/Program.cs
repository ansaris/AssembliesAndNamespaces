using System;
using System.Collections.Generic; //Not being used, which is why it is grayed out.
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

namespace AssembliesAndNamespaces
{
    class Program
    {
        static void Main(string[] args)
        {
            System.Console.WriteLine("Hello world!"); // System is not needed since namespace System is already used.
            Console.ReadLine();

            // bing search: site:microsoft.com write to a text file c#, get his from msdn.microsoft.com
            // Example #2: Write one string to a text file.
            string text = "A class is the most powerful data type in C#. Like a structure, " +
                           "a class defines the data and behavior of the data type. ";
            // WriteAllText creates a file, writes the specified string to the file,
            // and then closes the file.    You do NOT need to call Flush() or Close().
            System.IO.File.WriteAllText(@"C:\Users\Public\TestFolder\WriteText.txt", text);
        }
    }
}
