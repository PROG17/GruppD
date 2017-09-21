using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SudokuProblem2
{
    class Sudoku
    {
        private int[,] sudokuNumbers = new int[9, 9];

        int numbersPlaced = 0;
        int interations = 0;

        // Konstruktor, skriv in alla givna siffror i arrayen
        public Sudoku(string sudokuProblem)
        {
            sudokuNumbers = new int[9, 9];
            for (int row = 0; row < 9; row++)
            {
                for (int col = 0; col < 9; col++)
                {
                    sudokuNumbers[row, col] = sudokuProblem[row * 9 + col];
                }
            }
        }

        public Sudoku(int[,] sudokuProblem)
        {
            sudokuNumbers = (int[,])sudokuProblem.Clone();
        }

        internal void PrintBoard() //utseendet från sudoku1
        {
            for (int row = 0; row < 9; row++)
            {
                if (row % 3 == 0)
                {
                    for (int i = 0; i < 25; i++)
                    {
                        Console.Write("-");
                    }
                    Console.WriteLine();
                }

                for (int column = 0; column < 9; column++)
                {
                    if (column % 3 == 0)
                    {
                        Console.Write("| ");
                    }
                    Console.Write(sudokuNumbers[row, column] + " ");
                }

                Console.Write("|");
                Console.WriteLine();
            }
            Console.WriteLine("-------------------------");
        }


        internal bool Solve()
        {
            bool anyNumberWritten;

            do
            {
                anyNumberWritten = false;
                for (int row = 0; row < 9; row++)
                {
                    for (int column = 0; column < 9; column++)
                    {
                        if (sudokuNumbers[row, column] == 0)   // Om cellen är tom
                        {
                            List<int> possibleValues = CalculatePossibleNumbers(row, column);

                            if (possibleValues.Count == 1)    // Om exakt en siffra är möjlig i  en cell 
                            {
                                // Skriv in den enda möjliga siffran i cellen
                                sudokuNumbers[row, column] = possibleValues[0];
                                anyNumberWritten = true;
                            }
                        }
                    }
                }

            } while (anyNumberWritten); // Fortsätt i loopen om minst en siffra blev inskriven          

            return CheckSudokuSolved();
        }

        // Denna metod kontrollerar om en array bestående av 9 heltal 
        // innehåller siffrorna 1- 9 exakt en gång
        private bool CheckNineIntegers(int[] nineIntegers)
        {
            for (int i = 1; i < 10; i++)
            {
                if (!(nineIntegers.Contains(i)))
                {
                    return false;
                }
            }
            return true;
        }

        // Denna metod kontrollerar om Sudokut är löst
        private bool CheckSudokuSolved()
        {
            for (int row = 0; row < 9; row++)
            {
                int[] numbers = new int[9];
                for (int col = 0; col < 9; col++)
                {
                    numbers[col] = sudokuNumbers[row, col];
                }
                if (!CheckNineIntegers(numbers))
                {
                    return false;
                }
            }

            for (int col = 0; col < 9; col++)
            {
                int[] numbers = new int[9];
                for (int row = 0; row < 9; row++)
                {
                    numbers[row] = sudokuNumbers[row, col];
                }
                if (!CheckNineIntegers(numbers))
                {
                    return false;
                }
            }

            for (int boxRow = 0; boxRow < 3; boxRow++)
            {
                for (int colRow = 0; colRow < 3; colRow++)
                {
                    int[] numbers = new int[9];
                    for (int index = 0; index < 9; index++)
                    {
                        int row = boxRow * 3 + index / 3;
                        int col = colRow * 3 + index % 3;
                        numbers[index] = sudokuNumbers[row, col];
                    }
                    if (!CheckNineIntegers(numbers))
                    {
                        return false;
                    }
                }
            }
            return true;
        }
    }
}