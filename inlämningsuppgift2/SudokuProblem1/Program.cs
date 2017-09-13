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
            Sudoku game = new Sudoku("003020600900305001001806400" +
            "008102900700000008006708200" +
            "002609500800203009005010300");
            bool result = game.Solve();

            if (result)
            {
                game.PrintBoard();
            }
            else
            {
                Console.WriteLine("Det misslyckades att lösa Sudokut");
            }
            Console.WriteLine();    

            Sudoku game2 = new Sudoku("619030040270061008000047621486302079000014580031009060005720806320106057160400030");
            game2.Solve();
            game2.PrintBoard();
        }
    }
}
