using System;
using System.IO;

namespace Day01
{
    class Program
    {
        static void Main(string[] args)
        {
            // To take the Text
            string[] ReadText = File.ReadAllLines("C:/Codigos/input_day1.txt");
            // End to take the Text

            int[] MeasurementInt = new int[ReadText.Length];

            // Convert String Array to Int Array
            for (int PositionArrayText = 0; PositionArrayText <= ReadText.Length - 1; PositionArrayText++)
            {

                MeasurementInt[PositionArrayText] = Convert.ToInt32(ReadText[PositionArrayText]);

            }
            // End Convert String Array to Int Array

            int Result = 0;

            // Number times the deepths measurement increases
            for (int PositionArray = 1; PositionArray <= MeasurementInt.Length - 1; PositionArray++)
            {
                int Measurement1 = MeasurementInt[PositionArray];

                int Measurement2 = MeasurementInt[PositionArray - 1];

                if (Measurement2 < Measurement1)
                {
                    Result = Result + 1;
                }
            }
            // End Number times the deepths measurement increases

            // Show number increases measurement deepths
            Console.WriteLine("Number times increases depths is : " + Result);
            // End Show number increases measurement deepths
        }
    }
}


