using System;
using Algorithms;
using Data;
using Visualizer;

namespace Sorting
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Bubble Sorting .. ");
            BubbleSort bubbleSort = new BubbleSort();
            bubbleSort.performSort();
            ConsoleDisplay.Display("Bubble Sort", bubbleSort.OutputArray);



        }
    }

}