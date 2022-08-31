using System;
using System.IO;

namespace Day03
{
    class Program
    {
        static void Main(string[] args)
        {
            //string[] ReadText = File.ReadAllLines("C:/Teste/teste.txt");
            //int[] Bit1 = new int[ReadText[0].Length];
            //int[] Bit0 = new int[ReadText[0].Length];
            //int GamaRate = 0;
            //int EpsilonRate = 0;


            //for (int PositionArray = 0; PositionArray <= ReadText.Length - 1; PositionArray++)
            //{
            //    string PositionInitial = ReadText[PositionArray];


            //    for (int PositionArrayChar = 0; PositionArrayChar <= Bit1.Length - 1; PositionArrayChar++)
            //    {
            //        char ValueChar = PositionInitial[PositionArrayChar];

            //        if (ValueChar == '1')
            //        {
            //            Bit1[PositionArrayChar] = Bit1[PositionArrayChar] + 1;
            //        }

            //        Bit0[PositionArrayChar] = ReadText.Length - Bit1[PositionArrayChar];
            //    }
            //}

            //for (int PositionArrayChar = 0; PositionArrayChar <= Bit1.Length - 1; PositionArrayChar++)
            //{

            //    double Pow = (Bit1.Length - 1) - (PositionArrayChar);
            //    Pow = Math.Pow(2, Pow);
            //    int PowInt = Convert.ToInt32(Pow);

            //    if (Bit1[PositionArrayChar] > Bit0[PositionArrayChar])
            //    {
            //        GamaRate = GamaRate + PowInt;
            //    }

            //    else
            //    {
            //        EpsilonRate = EpsilonRate + PowInt;
            //    }

            //}

            //int PowerConsumption = GamaRate * EpsilonRate;
            //Console.WriteLine("Gama Rate is: " + GamaRate);
            //Console.WriteLine("Epsilon Rate is: " + EpsilonRate);
            //Console.WriteLine("Power Consumption is: " + PowerConsumption);


            string[] ReadText = File.ReadAllLines("C:/Codigos/input_day3.txt");
            int[] Bit1 = new int[ReadText[0].Length];
            int[] Bit0 = new int[ReadText[0].Length];
            int GamaRate = 0;
            int EpsilonRate = 0;

            for (int PositionArray = 0; PositionArray <= ReadText.Length - 1; PositionArray++)
            {
                string PositionInitial = ReadText[PositionArray];


                for (int PositionArrayChar = 0; PositionArrayChar <= Bit1.Length - 1; PositionArrayChar++)
                {
                    char ValueChar = PositionInitial[PositionArrayChar];

                    if (ValueChar == '1')
                    {
                        Bit1[PositionArrayChar] = Bit1[PositionArrayChar] + 1;
                    }

                    Bit0[PositionArrayChar] = ReadText.Length - Bit1[PositionArrayChar];
                }
            }

            for (int PositionArrayChar = 0; PositionArrayChar <= Bit1.Length - 1; PositionArrayChar++)
            {

                double Pow = (Bit1.Length - 1) - (PositionArrayChar);
                Pow = Math.Pow(2, Pow);
                int PowInt = Convert.ToInt32(Pow);

                if (Bit1[PositionArrayChar] > Bit0[PositionArrayChar])
                {
                    GamaRate = GamaRate + PowInt;
                }

                else
                {
                    EpsilonRate = EpsilonRate + PowInt;
                }

            }

            int PowerConsumption = GamaRate * EpsilonRate;
            Console.WriteLine("Gama Rate is: " + GamaRate);
            Console.WriteLine("Epsilon Rate is: " + EpsilonRate);
            Console.WriteLine("Powe Consumption is: " + PowerConsumption);



        }

    }
}










































