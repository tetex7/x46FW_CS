using System;
using x46_FW.quadFX.MM;
using x46_FW.quadFX;
using x46FW_API;
using System.Runtime.InteropServices.ComTypes;

namespace x46_tester_CLT
{
    class Program
    {
        static void Main(string[] args)
        {
            var ff = TISM.PUS("TYPEATTR", ConsoleKey.F1);
            Console.WriteLine("Hello World!");
            System.Console.WriteLine("Press any key to exit.");
            System.Console.ReadKey();
        }
    }
}
