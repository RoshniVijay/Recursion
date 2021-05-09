
using System;
using Data;
using System.Collections;
using Visualizer;
namespace Algorithms
{

public class BubbleSort
{
    public ArrayList InputArray;
    public ArrayList OutputArray;

     public void performSort()
     {       
         InputArray = Data.ArrayData.GetData();
     OutputArray = new ArrayList(InputArray);
    int size = OutputArray.Count;
    
         for(int step = 0 ; step < size;step++)
           for(int i = 0 ; i < size - step - 1;i++)
         {
if ((int)OutputArray[i] > (int)OutputArray[i+1])
{
    int temp = (int)OutputArray[i];
    OutputArray[i] =  OutputArray[i+1];
    OutputArray[i+1] = temp;
} 
ConsoleDisplay.Display("Iteration", OutputArray);
         }


     }
    
}
}