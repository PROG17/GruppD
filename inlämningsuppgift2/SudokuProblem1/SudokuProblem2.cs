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
    public partial class SudokuProblem2 : Form
    {
        public SudokuProblem2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Kod för lätt sudoku + nytt formfönster
            Easy easy = new Easy();
            easy.Show();


        }

        private void button2_Click(object sender, EventArgs e)
        {
            //Kod för medium sudoku + nytt formfönster


        }

        private void button3_Click(object sender, EventArgs e)
        {
            //Kod för svårt sudoku + nytt formfönster


        }
    }
}
