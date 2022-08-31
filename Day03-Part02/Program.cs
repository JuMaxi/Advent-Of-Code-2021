using System;
using System.IO;

namespace Day03_Part02
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] ReadText = File.ReadAllLines("C:/Teste/teste.txt");
            int Bit1 = 0;
            int Bit0 = 0;
           // int Oxygen = 0;
            //int CO2 = 0;


            for (int PositionArray = 0; PositionArray <= ReadText.Length - 1; PositionArray++)
            {
                string PositionInitial = ReadText[PositionArray];


                    char ValueChar = PositionInitial[0];

                    if (ValueChar == '1')
                    {
                        Bit1 = Bit1+ 1;
                    }

                    Bit0 = ReadText.Length - Bit1;
                
            }


            // Bit1 = 7,   Bit0 = 5
            int qualquer = 0;
            if (Bit1 > Bit0)
            {
                string [] teste1 = new string [Bit1];
                
                string [] teste2 = new string [Bit0];

                for (int PositionArray = 0; PositionArray <= ReadText.Length-1; PositionArray++)
                {
                    string PositionInitial = ReadText[PositionArray];
                    char ValueChar = PositionInitial[0];

                    if (ValueChar == '1')
                    {
                        teste1[qualquer] = PositionInitial;
                        qualquer = qualquer + 1;
                    }

                }

            }
                   
                       


            //int PowerConsumption = GamaRate * EpsilonRate;
            //Console.WriteLine("Gama Rate is: " + GamaRate);
            //Console.WriteLine("Epsilon Rate is: " + EpsilonRate);
            //Console.WriteLine("Power Consumption is: " + PowerConsumption);
        }
    }
}
