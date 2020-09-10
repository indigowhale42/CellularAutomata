using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CellAu
{
    public partial class FormCell : Form
    {
        public int CellsNumberDialodResult { get; set; }
        public int CellSizeDialodResult { get; set; }
        public bool GridDialodResult { get; set; }

        public FormCell(int cellSize, int cellsNumber, bool Grid)
        {
            InitializeComponent();

            labelError.Text = "    ";
            textBoxCellsNumber.Text = cellsNumber.ToString();

            labelError2.Text = "    ";
            textBoxCellSize.Text = cellSize.ToString();

            if (!Grid)
            {
                checkBox1.Checked = false;
                checkBox1.CheckState = CheckState.Unchecked;
                GridDialodResult = false;
            }
            else
            {
                checkBox1.Checked = true;
                checkBox1.CheckState = CheckState.Checked;
                GridDialodResult = true;
            }

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void buttonChangeCell_Click(object sender, EventArgs e)
        {
            try
            {
                int result = Convert.ToInt32(textBoxCellsNumber.Text);
                if (result < 10 || result > 500)
                    throw new ArgumentOutOfRangeException();
                CellsNumberDialodResult = result;

                result = Convert.ToInt32(textBoxCellSize.Text);
                if (result < 1 || result > 30)
                    throw new Exception();
                CellSizeDialodResult = result;
            }
            catch (Exception ex)
            {
                if (ex as ArgumentOutOfRangeException != null)
                    labelError.Text = "Неправильный ввод. " + textBoxCellsNumber.Text;
                else 
                    labelError2.Text = "Неправильный ввод. " + textBoxCellSize.Text;

                DialogResult = DialogResult.None;
            }
        }

        private void buttonCancelCell_Click(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            GridDialodResult = !GridDialodResult;
        }
    }
}
