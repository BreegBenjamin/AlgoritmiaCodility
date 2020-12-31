using System;
using System.Collections.Generic;
using System.Text;

namespace Codility_Iterations
{
    public class BinaryGap
    {
        //Find longest sequence of zeros in binary representation of an integer.
        public int GetBinary(int numnber) 
        {
            string binaryForm = Convert.ToString(numnber, 2);
            int contadorResult = 0;
            int contadorTemp = 0;
            foreach (var item in binaryForm)
            {
                if (item == '0')
                    contadorTemp++;
                else 
                {
                    if (contadorTemp > contadorResult) contadorResult = contadorTemp;
                    contadorTemp = 0;
                }
            }
            return contadorResult;
        }
    }
}
