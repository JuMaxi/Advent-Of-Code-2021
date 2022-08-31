using System;
using System.IO;

namespace Day02_Part02
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] ReadText = File.ReadAllLines("C:/Codigos/input_day2.txt");
            int Forward = 0;
            int Depth = 0;
            int aim = 0;

            for (int PositionArray = 0; PositionArray <= ReadText.Length - 1; PositionArray++)
            {
                string[] BreakText = ReadText[PositionArray].Split(" ");
                string Direction = BreakText[0];
                string Measurement = BreakText[1];
                int MeasurementInt = Convert.ToInt32(Measurement);

                if (Direction == "forward")
                {
                    Forward = Forward + MeasurementInt;
                    Depth = Depth + (aim * MeasurementInt);
                }
                else
                {
                    if (Direction == "down")
                    {
                        aim = aim + MeasurementInt;
                    }
                    else
                    {
                        aim = aim - MeasurementInt;
                    }
                }
            }
            Console.WriteLine("Forward is: " + Forward);
            Console.WriteLine("Depth is: " + Depth);
            Console.WriteLine("Multiply Final Forward X Final Depth is: " + (Forward * Depth));
        }
    }
}
