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
        static string[] FilterArray(string[] ReadText, int Size, int PositionChar, char MostCommonBit)
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

        static string BitEnd(string[] ReadText, int PositionChar, char Character)
        {
            string Result = "";
            if (ReadText.Length == 2)
            {
                for (int PositionArrayEnd = 0; PositionArrayEnd <= ReadText.Length - 1; PositionArrayEnd++)
                {
                    string verificacao = ReadText[PositionArrayEnd];
                    char EndChar = verificacao[PositionChar];

                    if (EndChar == Character)
                    {
                        Result = verificacao;
                    }
                }
            }
            return Result;
        }





    static void Main(string[] args)
    {
        string[] ReadText1 = File.ReadAllLines("C:/Teste/teste.txt");
        int Bit1 = 0;
        int Bit0 = 0;
        int Oxygen = 0;
        int CO2 = 0;
        int PositionChar = 0;
        string BitEnd1 = " ";


        while (ReadText1.Length >= 3)
        {
            // Descobrir quantidade de bits predominantes na coluna ATUAL
            Bit1 = CalculateAmountBit1(ReadText1, PositionChar);
            Bit0 = ReadText1.Length - Bit1;


            int Size = Bit1;
            char MostCommonBit = '1';

            if (Bit0 > Bit1)
            {
                Size = Bit0;
                MostCommonBit = '0';
            }

            ReadText1 = FilterArray(ReadText1, Size, PositionChar, MostCommonBit);

            PositionChar = PositionChar + 1;
            Bit0 = 0;
            Bit1 = 0;

                // int BitEnd = BitEnd(array, positionChar..., '1')

            BitEnd1 = BitEnd(ReadText1, PositionChar, '1') ; 
        }


        string[] ReadText2 = File.ReadAllLines("C:/Teste/teste.txt");
        int PositionChar2 = 0;
        string BitEnd2 = " ";


        while (ReadText2.Length >= 3)
        {
            // Descobrir quantidade de bits predominantes na coluna ATUAL
            Bit1 = CalculateAmountBit1(ReadText2, PositionChar2);
            Bit0 = ReadText2.Length - Bit1;


            int Size2 = Bit0;
            char LessCommonBit = '0';

            if (Bit0 > Bit1)
            {
                Size2 = Bit1;
                LessCommonBit = '1';
            }

            ReadText2 = FilterArray(ReadText2, Size2, PositionChar2, LessCommonBit);


            PositionChar2 = PositionChar2 + 1;
            Bit0 = 0;
            Bit1 = 0;

                BitEnd2 = BitEnd(ReadText2, PositionChar2, '0');
        }


        Console.WriteLine("Oxygen is: " + BitEnd1); ;
        Console.WriteLine("CO2 is: " + BitEnd2);

    }
}
}

