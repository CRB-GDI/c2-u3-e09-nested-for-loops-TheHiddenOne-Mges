﻿namespace exercise9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int rowWidth;
            int rowAmount;
            // gathers the values for varriables above
            Console.WriteLine("How Long do you want the Row Width?");
            rowWidth = int.Parse(Console.ReadLine());
            Console.WriteLine("How Many Rows do you want?");
            rowAmount = int.Parse(Console.ReadLine());
            // generates the asked for block
            for (int j = 0; j < rowWidth; j++)
            {
                for (int i = 0; i < rowAmount; i++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            
            }

            // Produces an Incremental Line of Rows
            int wantedRowsAmount;
            int startingRow = 0;
            // prompts for a amount of rows
            Console.WriteLine("how many Rows do you want");
            wantedRowsAmount = int.Parse(Console.ReadLine());

            for (int t = 0; t < wantedRowsAmount; t++)
            {

                for (int y = startingRow + wantedRowsAmount; y >=  wantedRowsAmount; y--)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
                startingRow++;
            }

            
            





        }

    }
}