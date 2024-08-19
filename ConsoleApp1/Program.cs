using System;


namespace LAB_1
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.OutputEncoding = System.Text.Encoding.UTF8;
            ConsoleMenu consoleMenu = new ConsoleMenu();
            consoleMenu.showMenu();
        }
    }
}
