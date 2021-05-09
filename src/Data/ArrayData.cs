
using System;
using System.Collections;
namespace Data
{

    public static class ArrayData
    {
        static ArrayList InputArray = new ArrayList {10, 20, 60, 30, 90, 40};
    

        public static ArrayList GetData()
       {

             ArrayList inputNewArray = new ArrayList (InputArray);
             return inputNewArray;


       }

    }

}