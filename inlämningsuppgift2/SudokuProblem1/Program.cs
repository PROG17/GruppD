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
                Console.WriteLine("Det gick inte att lösa Sudokut");
            }
            Console.WriteLine();    
            
            Sudoku game2 = new Sudoku("619030040270061008000047621486302079000014580031009060005720806320106057160400030");
            game2.Solve();
            game2.PrintBoard(); 
            
            
            Sudoku game3 = new Sudoku("186403000034080000700050408" +
            "609042013010060070250730609" +
            "805010002000070380000208561");
            game3.PrintBoard();
            Console.WriteLine();
                        
            bool result3 = game3.Solve();

            if (result3)
            {
                Console.WriteLine("Det gick bra att lösa Sudokut !");
                game3.PrintBoard();
            }
            else
            {              
                Console.WriteLine("Det gick inte att lösa Sudokut !!");
                game3.PrintBoard();
            }
            Console.WriteLine();    
            
            Sudoku game4 = new Sudoku("100040785040000019000001004" +
            "004003800005402600008900500" +
            "400300000520000030397020006");
            game4.PrintBoard();
            Console.WriteLine();
                        
            bool result4 = game4.Solve();

            if (result4)
            {
                Console.WriteLine("Det gick bra att lösa Sudokut !");
                game4.PrintBoard();
            }
            else
            {              
                Console.WriteLine("Det gick inte att lösa Sudokut !!");
                game4.PrintBoard();
            }
            Console.WriteLine();       
                       
            Console.ReadKey(true);
        }
    }
}
