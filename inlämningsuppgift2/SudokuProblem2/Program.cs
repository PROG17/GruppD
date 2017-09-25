using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SudokuProblem2
{
    class Program
    {
        static void Main(string[] args)
        {
            //inte klart

            Console.WriteLine("Skriv in ditt svårare sudoku problem: ");
            Console.WriteLine("Varje tom cell ska skrivas som 0");
            string input = Console.ReadLine();

            Sudoku game = new Sudoku(input);

            bool result = game.Solve();
            if (result)
            {
                Console.WriteLine("Det gick att lösa:");
                game.PrintBoard();
            }

            else
            {
                Console.WriteLine("Tyvärr. Det gick inte att lösa sudokut: ");
                game.PrintBoard(); //För att skriva ut snyggt även om det inte gick att lösa
            }
            Console.WriteLine();

            Console.ReadLine();

        }
    }
}
