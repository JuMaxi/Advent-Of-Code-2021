using System;
using System.IO;

namespace Day01_Part02
{
    class Program
    {
        static void Main(string[] args)
        {
            //int[] Depths = new int[10]
            //{
            //    199,
            //    200,
            //    208,
            //    210,
            //    200,
            //    207,
            //    240,
            //    269,
            //    260,
            //    263
            //};

            //int Result = 0;
            //int Sum1 = Depths[0] + Depths[1] + Depths[2];
            
            //for(int PositionArray = 2; PositionArray <= Depths.Length-1; PositionArray++)
            //{
            //    int Sum2 = Depths[PositionArray];
            //    Sum2 = Sum2 + Depths[PositionArray - 1];
            //    Sum2 = Sum2 + Depths[PositionArray - 2];

            //    if (Sum2 > Sum1)
            //    {
            //        Result = Result + 1;
            //    }

            //    Sum1 = Sum2;
            //}
            //Console.WriteLine("Number times increase depths is: " + Result);


            string[] ReadText = File.ReadAllLines("C:/Codigos/input_day1.txt");
            int[] TextToInt = new int[ReadText.Length];

            for(int PositionArrayConvert = 0; PositionArrayConvert <= ReadText.Length-1; PositionArrayConvert++)
            {
                TextToInt[PositionArrayConvert] = Convert.ToInt32(ReadText[PositionArrayConvert]);
            }

            int Result = 0;
            int Sum1 = TextToInt[0] + TextToInt[1] + TextToInt[2];

            for (int PositionArraySum = 2; PositionArraySum <= TextToInt.Length-1; PositionArraySum++)
            {
                int Sum2 = TextToInt[PositionArraySum];
                Sum2 = Sum2 + TextToInt[PositionArraySum - 1];
                Sum2 = Sum2 + TextToInt[PositionArraySum - 2];

                if(Sum2 > Sum1)
                {
                    Result = Result + 1;
                }
                Sum1 = Sum2;
            }
            Console.WriteLine("Number times sum increase is: " + Result);



        }
    }
}
