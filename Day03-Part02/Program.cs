using System;
using System.IO;

namespace Day03_Part02
{
    class Program
    {
        static int CalculateAmountBit1(string[] array, int position)
        {
            int amountBit1 = 0;
            for (int PositionArray = 0; PositionArray <= array.Length - 1; PositionArray++)
            {
                string PositionInitial = array[PositionArray];
                char ValueChar = PositionInitial[position];

                amountBit1 = amountBit1 + (Convert.ToInt32(ValueChar) - 48);
            }

            return amountBit1;
        }
        static string [] FilterArray(string [] ReadText, int Size, int PositionChar, char MostCommonBit)
        {

            int NewPositionArray = 0;
            string[] NewReadText = new string[Size];

            for (int PositionArray = 0; PositionArray <= ReadText.Length - 1; PositionArray++)
            {
                string PositionInitial = ReadText[PositionArray];
                char ValueChar = PositionInitial[PositionChar];

                if (ValueChar == MostCommonBit)
                {
                    NewReadText[NewPositionArray] = PositionInitial;
                    NewPositionArray = NewPositionArray + 1;
                }
            }

            return NewReadText;
        }
        static void Main(string[] args)
        {
            string[] ReadText = File.ReadAllLines("C:/Teste/teste.txt");
            int Bit1 = 0;
            int Bit0 = 0;
            int Oxygen = 0;
            int CO2 = 0;
            int PositionChar = 0;
            string teste = " ";


            while (ReadText.Length >= 3)
            {
                // Descobrir quantidade de bits predominantes na coluna ATUAL
                Bit1 = CalculateAmountBit1(ReadText, PositionChar);
                Bit0 = ReadText.Length - Bit1;


                int Size = Bit1;
                char MostCommonBit = '1';

                if (Bit0 > Bit1)
                {
                    Size = Bit0;
                    MostCommonBit = '0';
                }

                // ReadText = FilterArray(ReadText, Bit1/Bit0

                ReadText = FilterArray(ReadText, Size, PositionChar, MostCommonBit);

                PositionChar = PositionChar + 1;
                Bit0 = 0;
                Bit1 = 0;

                if (ReadText.Length == 2)
                {
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
            }


            string[] ReadText2 = File.ReadAllLines("C:/Teste/teste.txt");
            int PositionChar2 = 0;
            string teste2 = " ";


            while (ReadText2.Length >= 3)
            {
                // Descobrir quantidade de bits predominantes na coluna ATUAL
                Bit1 = CalculateAmountBit1(ReadText2, PositionChar2);
                Bit0 = ReadText2.Length - Bit1;


                string[] NewReadText = new string[Bit0];
                char LessCommonBit = '0';

                if (Bit0 > Bit1)
                {
                    NewReadText = new string[Bit1];
                    LessCommonBit = '1';
                }


                int NewPositionArray = 0;

                for (int PositionArray = 0; PositionArray <= ReadText2.Length - 1; PositionArray++)
                {
                    string PositionInitial = ReadText2[PositionArray];
                    char ValueChar = PositionInitial[PositionChar2];

                    if (ValueChar == LessCommonBit)
                    {
                        NewReadText[NewPositionArray] = PositionInitial;
                        NewPositionArray = NewPositionArray + 1;
                    }
                }

                PositionChar2 = PositionChar2 + 1;
                ReadText2 = NewReadText;
                Bit0 = 0;
                Bit1 = 0;

                if (ReadText2.Length == 2)
                {
                    for (int PositionArrayEnd = 0; PositionArrayEnd <= ReadText2.Length - 1; PositionArrayEnd++)
                    {
                        string verificacao = ReadText2[PositionArrayEnd];
                        char EndChar = verificacao[PositionChar2];

                        if (EndChar == '0')
                        {
                            teste2 = verificacao;
                        }
                    }
                }
            }







            //int PowerConsumption = GamaRate * EpsilonRate;
            Console.WriteLine("Oxygen is: " + teste); ;
            Console.WriteLine("CO2 is: " + teste2);
            //Console.WriteLine("Power Consumption is: " + PowerConsumption);
        }
    }
}

