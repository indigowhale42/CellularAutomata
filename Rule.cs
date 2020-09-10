using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CellAu
{
    class Rule
    {
        bool x0 = false, x1 = false, x2 = false, x3 = false, x4 = false, x5 = false, x6 = false, x7 = false;
            
        public Rule (int number = 87)
        {
            if (number < 0 || number > 255)
                throw new ArgumentOutOfRangeException("Номер правила от 0 до 255");

            if (number % 2 == 1)
                x0 = true;

            if (((number >> 1) & 1) == 1)
                x1 = true;

            if (((number >> 2) & 1) == 1)
                x2 = true;

            if (((number >> 3) & 1) == 1)
                x3 = true;

            if (((number >> 4) & 1) == 1)
                x4 = true;

            if (((number >> 5) & 1) == 1)
                x5 = true;

            if (((number >> 6) & 1) == 1)
                x6 = true;

            if (((number >> 7) & 1) == 1)
                x7 = true;
        }

        private bool CellEvolving (bool a, bool b, bool c)
        {
            if (a == false && b == false && c == false)
                return x0;

            if (a == false && b == false && c == true)
                return x1;

            if (a == false && b == true && c == false)
                return x2;

            if (a == false && b == true && c == true)
                return x3;

            if (a == true && b == false && c == false)
                return x4;

            if (a == true && b == false && c == true)
                return x5;

            if (a == true && b == true && c == false)
                return x6;

            if (a == true && b == true && c == true)
                return x7;

            throw new Exception("Кодер лошок!");
        }

        public bool[] StepEvolve(bool[] Cells, int cellsNumber)
        {
            bool[] NextCells = new bool[cellsNumber];
            NextCells[0] = CellEvolving(false, Cells[0], Cells[1]);
            for (int i = 1; i < cellsNumber - 1; i++)
            {
                NextCells[i] = CellEvolving(Cells[i - 1], Cells[i], Cells[i + 1]);
            }
            NextCells[cellsNumber - 1] = CellEvolving(Cells[cellsNumber - 2], Cells[cellsNumber - 1], false);
            return NextCells;
        }
    }
}
