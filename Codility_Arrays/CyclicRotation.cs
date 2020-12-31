using System;
using System.Linq;

namespace Codility_Arrays
{
    public class CyclicRotation
    {
        public int[] RotateArray(int[] array1, int numberStep) 
        {
            //Rotate an array to the right by a given number of steps.
            int[] arrayResult = new int[array1.Length];
            while (numberStep > 0)
            {
                array1.ToList().ForEach((x)=> 
                {
                    int index = Array.IndexOf(array1, x);
                    if (index == array1.Length - 1)
                        arrayResult[0] = array1[array1.Length - 1];
                    else
                        arrayResult[index+1] = x;
                });
                numberStep--;
                array1 = arrayResult;
                if (numberStep != 0)
                    arrayResult = new int[array1.Length];
            }
            return arrayResult;
        }
    }
}
