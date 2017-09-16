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
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Denna knapp ska se om man löst rätt genom att använda equals
            //Ska också markera felen som användaren matat in, helst med rött och grönt
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //Denna knapp ska ta bort det ifyllda värdet i sudokut som användaren matat in
        }


    }
}
