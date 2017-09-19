using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SudokuProblem1
{
    class Program
    {
        [STAThread]
        static void Main(string[] args)
        {
            //Man kan välja att göra ett val 1,2,3 där;
            // 1 är inlämning 1, 2 inlämning 2 och 3dje är inlämning 3

            Console.WriteLine("Hej välj vilket spel du vill köra:");
            Console.WriteLine("1) Sudoku lösare - Programmet löser sudoku åt dig\n2) Här väljer du svårighetsgrad och får ut sudoku du ska lösa\n" +
               "3) -----");

            while (true)
            {
                int whatGame = int.Parse(Console.ReadLine());

                if (whatGame == 1)
                {
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
                        game.PrintBoard(); //För att skriva ut snyggt även om det inte gick att lösa
                    }
                    Console.WriteLine();
                }

                if (whatGame == 2)
                {
                    Application.EnableVisualStyles();
                    Application.SetCompatibleTextRenderingDefault(false);
                    Application.Run(new SudokuProblem2());
                }

                if (whatGame == 3)
                {
                    //Kod för val nummer 3, uppgift tre's genväg ska kodas hit senare

                }
                
                else
                {
                    Console.WriteLine("Fel input");
                }
            }
        }
    }
}
