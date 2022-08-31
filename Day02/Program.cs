using System;
using System.IO;

namespace Day02
{
    class Program
    {
        static void Main(string[] args)
        {
            //int Forward = 0;
            //int Depth = 0;
            //string[] ReadText = File.ReadAllLines("C:/Teste/teste.txt");

            //for (int PositionArray = 0; PositionArray <= ReadText.Length - 1; PositionArray++)
            //{
            //    string[] BreakText = ReadText[PositionArray].Split(" ");
            //    string Direction = BreakText[0];
            //    string Measurement = BreakText[1];
            //    int MeasurementInt = Convert.ToInt32(Measurement);

            //    if (Direction == "forward")
            //    {
            //        Forward = Forward + MeasurementInt;
            //    }
            //    else
            //    {
            //        if (Direction == "down")
            //        {
            //            Depth = Depth + MeasurementInt;
            //        }
            //        else
            //        {
            //            Depth = Depth - MeasurementInt;
            //        }
            //    }
            //}
            //Console.WriteLine("Forward is: " + Forward);
            //Console.WriteLine("Depth is: " + Depth);
            //Console.WriteLine("Multiply Final Forward X Final Depth is: " + (Forward * Depth));


            string[] ReadText = File.ReadAllLines("C:/Codigos/input_day2.txt");
            int Forward = 0;
            int Depth = 0;

            for (int PositionArray = 0; PositionArray <= ReadText.Length - 1; PositionArray++)
            {
                string[] BreakText = ReadText[PositionArray].Split(" ");
                string Direction = BreakText[0];
                string Measurement = BreakText[1];
                int MeasurementInt = Convert.ToInt32(Measurement);

                if (Direction == "forward")
                {
                    Forward = Forward + MeasurementInt;
                }
                else
                {
                    if (Direction == "down")
                    {
                        Depth = Depth + MeasurementInt;
                    }
                    else
                    {
                        Depth = Depth - MeasurementInt;
                    }
                }
            }
            Console.WriteLine("Forward is: " + Forward);
            Console.WriteLine("Depth is: " + Depth);
            Console.WriteLine("Multiply Final Forward X Final Depth is: " + (Forward * Depth));



        }
    }
}
