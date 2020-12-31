using System;

namespace Codility_Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            var rotation = new CyclicRotation();
           var salida =  rotation.RotateArray(new int[] { 3, 8, 9, 7, 6 },3);
        }
    }
}
