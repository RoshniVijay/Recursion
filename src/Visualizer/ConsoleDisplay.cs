
using System;
using System.Collections;

namespace Visualizer
{

    public static class ConsoleDisplay
    {

public static void Display(string heading, ArrayList output)
{
     Console.WriteLine("Displaying " + heading);
     foreach(int obj in output)
     {
     Console.Write(obj + " ");

     }
}

    }
}
