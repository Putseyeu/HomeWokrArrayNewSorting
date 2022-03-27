using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWokrArrayNewSorting
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numberElement = 30;
            int minNumber = 0;
            int maxNumber = 101;
            int tempNumber;          
            int[] mainArray = new int[numberElement];
            Random random = new Random();

            for (int i = 0; i < numberElement; i++)
            {
                mainArray[i] = random.Next(minNumber, maxNumber);
            }

            for (int i = 0; i < mainArray.Length; i++)
            {
                Console.Write($"{mainArray[i]}  ");
            }
            Console.WriteLine();

            for (int i = 0; i < mainArray.Length - 1; i++)
            {
                for (int j = i + 1; j < mainArray.Length; j++)
                {
                    if (mainArray[i] > mainArray[j])
                    {
                        tempNumber = mainArray[i];
                        mainArray[i] = mainArray[j];
                        mainArray[j] = tempNumber;
                    }
                }
            }

            for (int i = 0; i < mainArray.Length; i++)
            {
                Console.Write($"{mainArray[i]}  ");
            }
            Console.WriteLine();
        }
    }
}
