using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SudokuProblem1
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Nu när vi vet att sudokut fungerar så ska användaren 
            kunna skriva in sitt sudokuproblem och 
            förhoppningsvis få det löst!*/

            Console.WriteLine("Hej och välkommen till Sudoku! Skriv in ditt sudoku problem: ");
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
                game.PrintBoard(); //För att skriva ut snyggt de siffror som gick att lösa
            }

            Console.WriteLine();
            Console.ReadKey(true);
        }
    }
}
