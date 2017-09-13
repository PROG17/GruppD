using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SudokuProblem1
{
    class Sudoku
    {
        private int[,] sudokuCells;

        public Sudoku(string sudokuProblem)
        {
            sudokuCells = new int[9, 9];
            for (int i = 0; i < sudokuProblem.Length; i++)
            {
                int row = i / 9;
                int column = i % 9;
                this.sudokuCells[row, column] = int.Parse(sudokuProblem.Substring(i, 1));
            }
        }

        internal bool Solve()   // TODO Implement this method
        {
            return true;
        }

        internal void PrintBoard()
        {
            for (int row = 0; row < 9; row++)
            {
                if (row%3 == 0)
                {
                    for (int i = 0; i < 25; i++)
                    {
                        Console.Write("-");
                    }
                    Console.WriteLine();
                }

                for (int column = 0; column < 9; column++)
                {
                    if (column%3 == 0)
                    {
                        Console.Write("| ");
                    }
                    Console.Write(sudokuCells[row, column] + " ");   
                }
                Console.Write("|");
                Console.WriteLine();
            }
            for (int i = 0; i < 25; i++)
            {
                Console.Write("-");
            }
            Console.WriteLine();
        }
    }
}
