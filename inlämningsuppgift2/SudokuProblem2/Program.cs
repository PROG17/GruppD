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
            Console.WriteLine("Skriv in ditt svårlösta sudoku: ");
            Console.WriteLine("037060000205000800006908000000600024001503600650009000000302700009000402000050360");
            string input = Console.ReadLine();

            //==Ska jämföra input med Solve();
            //==skrivs ut med PrintBoards()

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
        }

    }
}

