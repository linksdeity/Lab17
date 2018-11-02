using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GrandCircusLab17
{
    public class PrintPrimeNumber
    {

        public int UserInput { get; set; }


        public int Output()
        {
            int counter = 1;
            int numIncrement = 2;
            int primeAnswer = 2;
            bool primeChecker = true;

            while (counter < UserInput)
            {
                primeChecker = true;

                numIncrement++;

                for (int i = 2; i < numIncrement; i++)
                {
                    if(numIncrement % i == 0)
                    {
                        primeChecker = false;
                    }
                }

                if(primeChecker == true)
                {
                    primeAnswer = numIncrement;
                    counter++;
                }

            }

            return primeAnswer;
        }




    }
}
