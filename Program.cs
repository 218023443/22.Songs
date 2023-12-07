using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _22.Songs
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Songs holiday = new Songs("Holiday", "Green day",5);
            Songs kashmir = new Songs("kashmir", "Green day", 3);
            Songs kashmir2 = new Songs("kashmir", "Green day", 3);

            Console.WriteLine("You have "+Songs.songCount+" list of songs.");
            Console.ReadLine(); 

        }
    }
}
