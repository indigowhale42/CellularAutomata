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
    public partial class Form1 : Form
    {
        Bitmap bitmap;
        Bitmap bitmapInput;

        Graphics graphics;
        Graphics graphicsInput;

        Pen bluePen;
        SolidBrush whiteBrush;
        SolidBrush blackBrush;

        int cellSize = 10;
        int cellsNumber = 50;

        bool[] Cells;
        bool[] CellsInput;
        bool cellsInputFilled = false;

        int ruleNumber = 87;
        Rule rule;

        bool Grid = true;

        int steps = 0;

        public Form1()
        {
            InitializeComponent();

            labelRuleNo.Text = "Def: 87. For change press button";

            bluePen = new Pen(Color.AliceBlue);
            whiteBrush = new SolidBrush(Color.White);
            blackBrush = new SolidBrush(Color.Black);

            ResizeInit();
            
            CellsInput = new bool[cellsNumber];
            Cells = new bool[cellsNumber];
            rule = new Rule(ruleNumber);
        }

        void ResizeInit()
        {
            bitmap = new Bitmap(Grid ? (cellSize + 1) * cellsNumber : (cellSize) * cellsNumber, Grid ? (cellSize + 1) * 500 : (cellSize) * 500);
            bitmapInput = new Bitmap(Grid ? (cellSize + 1) * cellsNumber : (cellSize) * cellsNumber, cellSize);

            graphics = Graphics.FromImage(bitmap);
            graphicsInput = Graphics.FromImage(bitmapInput);

            DrawGrid();

            if (cellsInputFilled)
                DrawRow(0, CellsInput, graphicsInput);

            
            if (steps > 0)
            {
                for (int i = 0; i < steps; i++)
                {
                    Cells = rule.StepEvolve(Cells, cellsNumber);
                    DrawRow(i, Cells, graphics);
                }
            }
                
            sheet.SizeMode = PictureBoxSizeMode.AutoSize;
            sheet.Image = bitmap;
            sheetInput.SizeMode = PictureBoxSizeMode.AutoSize;
            sheetInput.Image = bitmapInput;
        }

        
       

        private void ButtonRuleNo_Click(object sender, EventArgs e)
        {
            using (FormRuleDialog formRuleDialog = new FormRuleDialog(ruleNumber))
            {
                if (formRuleDialog.ShowDialog() == DialogResult.OK)
                {
                    ruleNumber = formRuleDialog.RuleNumberDialodResult;
                    labelRuleNo.Text = "Changed:" + ruleNumber.ToString() +" For change press button";
                    rule = new Rule(ruleNumber);
                }
            }
        }

        private void buttonCell_Click(object sender, EventArgs e)
        {
            using (FormCell formCell = new FormCell(cellSize, cellsNumber, Grid))
            {
                if (formCell.ShowDialog() == DialogResult.OK)
                {
                    cellsNumber = formCell.CellsNumberDialodResult;
                    cellSize = formCell.CellSizeDialodResult;
                    Cells = new bool[cellsNumber];
                    CellsInput = new bool[cellsNumber];

                    labelCell.Text = "Curr:" + cellsNumber.ToString() + Environment.NewLine + 
                        "Size:" + cellSize.ToString() + " x " + cellSize.ToString();

                    Grid = formCell.GridDialodResult;
                }
            }
            ResizeInit();
        }

        private void buttonInput_Click(object sender, EventArgs e)
        {
            graphics.Clear(Color.White);
            DrawGrid();
            
            steps = 1;

            CellsInput.CopyTo(Cells, 0);

            DrawRow(0, Cells, graphics);
            sheet.Image = bitmap;
        }

        

        private void buttonFillRand_Click(object sender, EventArgs e)
        {
            CellsInput = new bool[cellsNumber];
            Random rand = new Random();
            for (int i = 0; i < cellsNumber; i++)
            {
                if ((rand.Next(0, cellsNumber * 2) % 2) == 0)
                    CellsInput[i] = true;
            }
            cellsInputFilled = true;
            steps = 0;
            ResizeInit();
        }

        // Ручной ввод клеточек в верхний picturebox
        private void sheetInput_MouseDown(object sender, MouseEventArgs e)
        {
            int i = (int)((double)e.X / (double)(cellSize + 1));

            if (i >= 0 && i < cellsNumber)
            {
                CellsInput[i] = !CellsInput[i];//Grid!!!
                if (CellsInput[i])
                    graphicsInput.FillRectangle(blackBrush, i * (cellSize + 1) + 1, 0, cellSize, cellSize);
                else
                    graphicsInput.FillRectangle(whiteBrush, i * (cellSize + 1) +1, 0, cellSize, cellSize);
                sheetInput.Image = bitmapInput;

                cellsInputFilled = true;
            }                    
        }


        // кнопка Evolve
        private void button1_Click(object sender, EventArgs e)
        {
            for (int i = 1; i < 1000; i++, steps++)
            {
                Cells = rule.StepEvolve(Cells, cellsNumber);
                DrawRow(i, Cells, graphics);
            }
            sheet.Image = bitmap;         
        }







        private void flowLayoutPanel1_Paint_1(object sender, PaintEventArgs e)
        {

        }

        

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }


        private void DrawGrid()
        {
            if (Grid)
            {
                for (int i = 0; i < bitmap.Height; i += cellSize + 1)
                    graphics.DrawLine(bluePen, 0, i, bitmap.Width, i);
                for (int j = 0; j < bitmap.Width; j += cellSize + 1)
                {
                    graphics.DrawLine(bluePen, j, 0, j, bitmap.Height);
                    graphicsInput.DrawLine(bluePen, j, 0, j, bitmapInput.Height);
                }
            }
        }

        private void DrawRow(int row, bool[] DrawingCells, Graphics field)
        {
            for (int j = 0; j < cellsNumber; j++)
            {
                if (DrawingCells[j])
                {
                    if (Grid)
                        field.FillRectangle(blackBrush, j * (cellSize + 1) + 1, row * (cellSize + 1) + 1, cellSize, cellSize);
                    else
                        field.FillRectangle(blackBrush, j * cellSize, row * cellSize, cellSize, cellSize);

                }

            }
        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            graphics.Clear(Color.White);
            graphicsInput.Clear(Color.White);
            bool cellsInputFilled = false;
            ResizeInit();
        }
    }
}
