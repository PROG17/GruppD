using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SudokuProblem2
{
    class Sudoku
    {
        private int[,,] sudokuNumbers = new int[9, 9, 10];

        int numbersPlaced = 0;
        int interations = 0;

        // Konstruktor, skriv in alla givna siffror i arrayen
        public Sudoku(string sudokuProblem)
        {
            sudokuNumbers = new int[9, 9, 10];
            for (int i = 0; i < sudokuProblem.Length; i++)
            {
                int row = i / 9;
                int column = i % 9;
                int cell = i % 3;
                if ((row < 9) && (column < 9))
                {
                    this.sudokuNumbers[row, column, cell] = int.Parse(sudokuProblem.Substring(i, 1));
                }
            }
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
                    Console.Write(sudokuNumbers[row, column, 0] + " ");
                }

                Console.Write("|");
                Console.WriteLine();
            }
        }

        public bool Solve()
        {
            while (IsComplete() == false)
            {
                interations++;
                numbersPlaced = 0;

                PossibleNumbers();

                Console.WriteLine("Antal omgångar: " + interations + "placerades totalt: " + numbersPlaced + " nummer");
                PrintBoard();
                Console.WriteLine();
                LastCheck(); //För att kolla en sista gång
            }

            return IsComplete();
        }

        public bool IsComplete()
        {
            bool anyNumberWritten;
            do
            {
                anyNumberWritten = false;
                for (int row = 0; row < 9; row++)
                {
                    for (int column = 0; column < 9; column++)
                    {
                        for (int cell = 1; cell < 10; cell++)
                        {
                            if (sudokuNumbers[row, column, cell] == 0)   // if the cell is empty
                            {
                                CheckNums(row, column, cell);

                                if (sudokuNumbers[row, column, cell] == 1)
                                {
                                    anyNumberWritten = true;
                                }
                            }
                        }
                    }
                }
            }

            while (anyNumberWritten);
            return true;
            //return CheckNums();
        }

        public void PossibleNumbers()
        {
            for (int row = 0; row < 9; row++)
            {
                for (int col = 0; col < 9; col++)
                {
                    if (sudokuNumbers[row, col, 0] == 0)
                    {
                        for (int q = 1; q < 10; q++)
                        {
                            if (CheckNums(row, col, q))
                                sudokuNumbers[row, col, q] = q;
                        }
                    }
                }
            }
            PlaceNumbers();
        }

        public bool CheckNums(int row, int col, int cell)
        {
            bool possible = true;

            //Kollar 3x3

            if (row < 3)
            {
                if (col < 3)
                {
                    for (int i = 0; i < 3; i++)
                    {
                        for (int q = 0; q < 3; q++)
                        {
                            if (sudokuNumbers[i, q, 0] == cell)
                                possible = false;
                        }
                    }
                }
            }

            else if (col < 6)
            {
                for (int i = 3; i < 6; i++)
                {
                    for (int q = 3; q < 6; q++)
                    {
                        if (sudokuNumbers[i, q, 3] == cell)
                            possible = false;
                    }
                }
            }

            else if (col < 9)
            {
                for (int i = 6; i < 9; i++)
                {
                    for (int q = 6; q < 9; q++)
                    {
                        if (sudokuNumbers[i, q, 6] == cell)
                            possible = false;
                    }
                }
            }

            for (int i = 0; i < 9; i++)
            {
                if (sudokuNumbers[row, i, 0] == cell)
                    possible = false;
            }

            for (int i = 0; i < 9; i++)
            {
                if (sudokuNumbers[i, col, 0] == cell)
                    possible = false;
            }
            return possible;
        }

        public void PlaceNumbers()
        {
            for (int row = 0; row < 9; row++)
            {
                for (int col = 0; col < 9; col++)
                {
                    if (sudokuNumbers[row, col, 0] == 0)
                    {
                        int counter = 0;
                        int place = 0;

                        for (int i = 1; i < 10; i++)
                        {
                            if (sudokuNumbers[row, col, i] == i)
                            {
                                counter++;
                                place = i;
                            }
                        }

                        if (counter == 1)
                        {
                            sudokuNumbers[row, col, 0] = place;
                            RemovePossible(row, col, place);
                            numbersPlaced++;
                        }

                        for (int j = 1; j < 10; j++)
                        {
                            PlacePossibles(row, col, j);
                        }
                    }
                }
            }
        }

        public void PlacePossibles(int row, int col, int cell) //Solving the soduku
        {
            int counter = 0;
            int rowPlace = 0;
            int colPlace = 0;

            if (counter == 1)
            {
                sudokuNumbers[rowPlace, colPlace, 0] = cell;
                RemovePossible(rowPlace, colPlace, cell);
                numbersPlaced++;
            }

            counter = 0;

            if (sudokuNumbers[row, col, cell] == cell)
            {
                for (int i = 0; i < 9; i++)
                {
                    if (sudokuNumbers[row, i, cell] == cell)
                    {
                        counter++;
                    }
                }

                if (counter == 1)
                {
                    sudokuNumbers[row, col, 0] = cell;
                    RemovePossible(row, col, cell);
                    numbersPlaced++;
                }

                counter = 0;

                for (int i = 0; i < 9; i++)
                {

                    if (sudokuNumbers[i, col, cell] == cell)
                    {
                        counter++;
                    }
                }

                if (counter == 1)
                {
                    sudokuNumbers[row, col, 0] = cell;
                    RemovePossible(row, col, cell);
                    numbersPlaced++;
                }
            }
        }

        public void RemovePossible(int row, int col, int cell) //Om det finns en siffra i en cell som det finns två av, så blir den ena 0
        {
            for (int i = 0; i < 9; i++)
            {
                if (sudokuNumbers[row, i, cell] == cell)
                    sudokuNumbers[row, i, cell] = 0;
            }

            for (int i = 0; i < 9; i++)
            {
                if (sudokuNumbers[i, col, cell] == cell)
                {
                    sudokuNumbers[i, col, cell] = 0;
                }
            }

            for (int q = 1; q < 10; q++)
            {
                sudokuNumbers[row, col, q] = 0;
            }
        }

        public void LastCheck() //Om det fortfarande finns 0 i sudokut.
        {
            bool isComplete = true;

            for (int row = 0; row < 9; row++)
            {
                for (int col = 0; col < 9; col++)
                {
                    RemovePossible(row, col, sudokuNumbers[row, col, 0] = 0);

                    if (sudokuNumbers[row, col, 0] == 0)
                    {
                        isComplete = false;
                    }
                }
            }
        }

    }
}
