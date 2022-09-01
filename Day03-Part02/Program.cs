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
            int Oxygen = 0;
            int CO2 = 0;
            int PositionChar = 0;


            while (ReadText.Length >= 3)
            {
                // Descobrir quantidade de bits predominantes na coluna ATUAL
                for (int PositionArray = 0; PositionArray <= ReadText.Length - 1; PositionArray++)
                {
                    string PositionInitial = ReadText[PositionArray];

                    char ValueChar = PositionInitial[PositionChar];

                    if (ValueChar == '1')
                    {
                        Bit1 = Bit1 + 1;
                    }
                    else
                    {
                        Bit0 = Bit0 + 1;
                    }
                }


                string[] NewReadText = new string[0];

                if (Bit1 > (ReadText.Length / 2))
                {
                    NewReadText = new string[Bit1];
                }
                else
                {
                    if (Bit0 > (ReadText.Length / 2))
                    {
                        NewReadText = new string[Bit0];
                    }
                }



                int NewPositionArray = 0;


                for (int PositionArray = 0; PositionArray <= ReadText.Length - 1; PositionArray++)
                {
                    string PositionInitial = ReadText[PositionArray];
                    char ValueChar = PositionInitial[PositionChar];

                    if (Bit1 > (ReadText.Length / 2) && ValueChar == '1')
                    {
                        NewReadText[NewPositionArray] = PositionInitial;
                        NewPositionArray = NewPositionArray + 1;
                    }
                    else
                    {
                        if (Bit0 > (ReadText.Length / 2) && ValueChar == '0')
                        {
                            NewReadText[NewPositionArray] = PositionInitial;
                            NewPositionArray = NewPositionArray + 1;
                        }
                    }
                }

                PositionChar = PositionChar + 1;
                ReadText = NewReadText;
                Bit0 = 0;
                Bit1 = 0;
                string teste = " ";

                if (ReadText.Length == 2)
                    for (int PositionArrayEnd = 0; PositionArrayEnd <= ReadText.Length - 1; PositionArrayEnd++)
                    {
                        string verificacao = ReadText[PositionArrayEnd];
                        char EndChar = verificacao[PositionChar];

                        if (EndChar == '1')
                        {
                            teste = verificacao;
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

