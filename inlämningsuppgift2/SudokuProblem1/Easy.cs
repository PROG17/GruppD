using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SudokuProblem1
{
    public partial class Easy : Form
    {

        public Easy()
        {
            //Färger så att det ser snyggt ut
            InitializeComponent();
            this.BackColor = System.Drawing.Color.White;
            button2.ForeColor = Color.Indigo;
            button2.BackColor = Color.AliceBlue;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //This function is gonna solve the soduko
            string lists = "";

            var textBoxes = new List<TextBox>();
            for (int i = 1; i <= 81; i++)
            {
                textBoxes.Add((TextBox)Controls.Find("box" + Convert.ToString(i), true)[0]);
            }

            // Add values to list
            foreach (TextBox textBox in textBoxes)
            {
                if (textBox != null)
                    if (textBox.Text == "")
                    {
                        lists += "0";//om den är tom, fast här ska talen skrivas ut istället
                    }
                    else
                    {
                        lists += textBox.Text;
                    }
            }


            // Solve
            var solver = new LooksAfterTheSudokuValue(lists);
            solver.Solve();

            // Fill new values
            for (int i = 0; i < textBoxes.Count; i++)
            {
                var textBox = textBoxes[i];
                textBox.Text = solver.testingToMakeSure[i / 9, i % 9].ToString();
            }
        }
    }

    //int num = string.IsNullOrWhiteSpace(textboxtext) ? 0 : int.Parse(textboxtext);
    //   ListsAndBoxes itt = new ListsAndBoxes(row1, row2, row3, row4, row5, row6, row7, row8, row9);

    // fel-------   LooksAfterTheSudokuValue Value = new LooksAfterTheSudokuValue(lists.ToString());

    //Need to get lists out of this Button2 so I can use it later


    //Also I want to save the input from the user while he/she is is clicking on the button after he/she inplented the code he/she have
}

public class LooksAfterTheSudokuValue //So I can solve the sudoku later
{
    public int[,] testingToMakeSure;

    public LooksAfterTheSudokuValue(string sudokuProblem) //List<string> SudokuProblem
    {

        testingToMakeSure = new int[9, 9];
        for (int i = 0; i < 81; i++)
        {
            int row = i / 9;
            int column = i % 9;
            if ((row < 9) && (column < 9))
            {
                this.testingToMakeSure[row, column] = int.Parse(sudokuProblem.Substring(i, 1));
            }
        }
    }

    // This method is trying to solve the sudoku
    // and returns a bool if it worked
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
                    if (testingToMakeSure[row, column] == 0)   // Om cellen är tom
                    {
                        List<int> possibleValues = CalculatePossibleNumbers(row, column);

                        if (possibleValues.Count == 1)    // Om exakt en siffra är möjlig i  en cell 
                        {
                            // Skriv in den enda möjliga siffran i cellen
                            testingToMakeSure[row, column] = possibleValues[0];
                            anyNumberWritten = true;
                        }
                    }
                }
            }

        } while (anyNumberWritten); // Fortsätt i loopen om minst en siffra blev inskriven          

        return CheckSudokuSolved();
    }

    // Denna metod returnerar en lista på dom siffror som är logiskt möjliga i en viss cell
    public List<int> CalculatePossibleNumbers(int row, int col)
    {
        List<int> rowNumbers = GetNumbersInRow(row);
        List<int> colNumbers = GetNumbersInColumn(col);
        List<int> boxNumbers = GetNumbersInBox(row, col);

        List<int> possibleNumbers = new List<int>();

        for (int i = 1; i < 10; i++)
        {
            // Om denna siffra varken finns i cellens rad,cellens kolumn eller cellens ruta
            if (!(rowNumbers.Contains(i) || colNumbers.Contains(i) || boxNumbers.Contains(i)))
            {
                possibleNumbers.Add(i);
            }
        }

        return possibleNumbers;
    }

    // Denna metod kontrollerar om en array bestående av 9 heltal 
    // innehåller siffrorna 1- 9 exakt en gång
    public bool CheckNineIntegers(int[] nineIntegers)
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
    public bool CheckSudokuSolved()
    {
        for (int row = 0; row < 9; row++)
        {
            int[] numbers = new int[9];
            for (int col = 0; col < 9; col++)
            {
                numbers[col] = testingToMakeSure[row, col];
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
                numbers[row] = testingToMakeSure[row, col];
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
                    numbers[index] = testingToMakeSure[row, col];
                }
                if (!CheckNineIntegers(numbers))
                {
                    return false;
                }
            }
        }
        return true;
    }

    // Denna metod returnerar en lista på dom siffror som är inskrivna i en viss rad
    public List<int> GetNumbersInRow(int row)
    {
        List<int> numbersInRow = new List<int>();
        for (int col = 0; col < 9; col++)
        {
            int number = testingToMakeSure[row, col];
            if (number > 0)
            {
                numbersInRow.Add(number);
            }
        }

        return numbersInRow;
    }

    // Denna metod returnerar en lista på dom siffror som är inskrivna i en viss kolumn
    public List<int> GetNumbersInColumn(int col)
    {
        List<int> numbersInCol = new List<int>();
        for (int row = 0; row < 9; row++)
        {
            int number = testingToMakeSure[row, col];
            if (number > 0)
            {
                numbersInCol.Add(number);
            }
        }

        return numbersInCol;
    }

    // Denna metod returnerar en lista på dom siffror som är inskrivna i samma ruta
    public List<int> GetNumbersInBox(int row, int col)
    {
        List<int> numbersInBox = new List<int>();

        int startRow = row / 3;
        int startCol = col / 3;

        for (int boxRow = startRow * 3; boxRow < (startRow + 1) * 3; boxRow++)
        {
            for (int boxCol = startCol * 3; boxCol < (startCol + 1) * 3; boxCol++)
            {
                int number = testingToMakeSure[boxRow, boxCol];
                if (number > 0)
                {
                    numbersInBox.Add(number);
                }
            }
        }
        return numbersInBox;
    }
}

