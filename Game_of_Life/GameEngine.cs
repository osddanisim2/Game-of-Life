using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;
using System.Windows.Forms;
using System.Runtime.Serialization.Formatters.Binary;
using System.Security.Cryptography;
using System.IO;

namespace Game_of_Life
{
    public class GameEngine
    {
        public int CurrentGeneration { get; private set; }
        private bool[,] field;
        public int rows;
        public int cols;
        public int a;

        public GameEngine(int rows, int cols, int density, int generationType)
        {
            this.rows = rows;
            this.cols = cols;
            field = new bool[cols, rows];
            ApplyGeneration(generationType, density);
        }
        private void ApplyGeneration(int generationType, int density)
        {
            switch (generationType)
            {
                case 1:
                    Random random = new Random();
                    for (int x = 0; x < cols; x++)
                    {
                        for (int y = 0; y < rows; y++)
                        {
                            field[x, y] = random.Next(density) == 0;
                        }
                    }
                    break;
                case 2:
                    field[1, 0] = true;
                    field[2, 1] = true;
                    field[0, 2] = true;
                    field[1, 2] = true;
                    field[2, 2] = true;
                    break;
                case 3:
                    field[1, 5] = true;
                    field[1, 6] = true;
                    field[2, 5] = true;
                    field[2, 6] = true;
                    field[11, 5] = true;
                    field[11, 6] = true;
                    field[11, 7] = true;
                    field[12, 4] = true;
                    field[12, 8] = true;
                    field[13, 3] = true;
                    field[13, 9] = true;
                    field[14, 3] = true;
                    field[14, 9] = true;
                    field[15, 6] = true;
                    field[16, 4] = true;
                    field[16, 8] = true;
                    field[17, 5] = true;
                    field[17, 6] = true;
                    field[17, 7] = true;
                    field[18, 6] = true;
                    field[21, 3] = true;
                    field[21, 4] = true;
                    field[21, 5] = true;
                    field[22, 3] = true;
                    field[22, 4] = true;
                    field[22, 5] = true;
                    field[23, 2] = true;
                    field[23, 6] = true;
                    field[25, 1] = true;
                    field[25, 2] = true;
                    field[25, 6] = true;
                    field[25, 7] = true;
                    field[35, 3] = true;
                    field[35, 4] = true;
                    field[36, 3] = true;
                    field[36, 4] = true;
                    break;
                case 4:
                    field[1, 5] = true;
                    field[1, 6] = true;
                    field[2, 5] = true;
                    field[2, 6] = true;
                    field[11, 5] = true;
                    field[11, 6] = true;
                    field[11, 7] = true;
                    field[12, 4] = true;
                    field[12, 8] = true;
                    field[13, 3] = true;
                    field[13, 9] = true;
                    field[14, 3] = true;
                    field[14, 9] = true;
                    field[15, 6] = true;
                    field[16, 4] = true;
                    field[16, 8] = true;
                    field[17, 5] = true;
                    field[17, 6] = true;
                    field[17, 7] = true;
                    field[18, 6] = true;
                    field[21, 3] = true;
                    field[21, 4] = true;
                    field[21, 5] = true;
                    field[22, 3] = true;
                    field[22, 4] = true;
                    field[22, 5] = true;
                    field[23, 2] = true;
                    field[23, 6] = true;
                    field[25, 1] = true;
                    field[25, 2] = true;
                    field[25, 6] = true;
                    field[25, 7] = true;
                    field[35, 3] = true;
                    field[35, 4] = true;
                    field[36, 3] = true;
                    field[36, 4] = true;
                    field[3, 3] = true;
                    field[3, 4] = true;
                    field[3, 5] = true;
                    field[4, 2] = true;
                    field[4, 6] = true;
                    field[5, 1] = true;
                    field[5, 7] = true;
                    field[6, 1] = true;
                    field[6, 7] = true;
                    field[7, 4] = true;
                    field[8, 2] = true;
                    field[8, 6] = true;
                    field[9, 3] = true;
                    field[9, 4] = true;
                    field[9, 5] = true;
                    field[11, 9] = true;
                    field[12, 9] = true;
                    break;
            }
        }

        public void NextGeneration()
        {
            var newField = new bool[cols, rows];

            for (int x = 0; x < cols; x++)
                for (int y = 0; y < rows; y++)
                {
                    var NeighboursCount = CountNeighbours(x, y);
                    var haslife = field[x, y];

                    if (!haslife && NeighboursCount == 3)
                        newField[x, y] = true;
                    else if (haslife && (NeighboursCount < 2 || NeighboursCount > 3))
                        newField[x, y] = false;
                    else
                        newField[x, y] = field[x, y];
                }

            field = newField;
            CurrentGeneration++;
        }

        public bool[,] GetCurrentGeneration()
        {
            var result = new bool[cols, rows];
            for (int x = 0; x < cols; x++)
                for (int y = 0; y < rows; y++)
                    result[x, y] = field[x, y];
            return result;
        }

        private int CountNeighbours(int x, int y)
        {
            int count = 0;

            for (int i = -1; i < 2; i++)
                for (int j = -1; j < 2; j++)
                {
                    int col = (x + i + cols) % cols;
                    int row = (y + j + rows) % rows;
                    bool isSelfChecking = col == x && row == y;
                    var haslife = field[col, row];

                    if (haslife && !isSelfChecking)
                        count++;
                }

            return count;
        }
        private bool ValidateCellPosition(int x, int y)
        {
            return x >= 0 && y >= 0 && x < cols && y < rows;
        }
        private void UpdatedCell(int x, int y, bool state)
        {
            if (ValidateCellPosition(x, y))
                field[x, y] = state;
        }
        public void AddCell(int x, int y)
        {
            UpdatedCell(x, y, state: true);
        }
        public void RemoveCell(int x, int y)
        {
            UpdatedCell(x, y, state: false);
        }
        public void ClearTable()
        {
            // Очищення всього поля
            for (int x = 0; x < cols; x++)
            {
                for (int y = 0; y < rows; y++)
                {
                    UpdatedCell(x, y, state: false);
                }
            }
            CurrentGeneration = 0;
        }
        public void ReadInfo(string FilePath)
        {
            try
            {
                using (FileStream fs = new FileStream(FilePath, FileMode.Open, FileAccess.Read, FileShare.Read))
                {
                    for (int i = 0; i < cols; i++)
                    {
                        for (int j = 0; j < rows; j++)
                        {
                            int byteValue = fs.ReadByte();
                            if (byteValue == 0 || byteValue == 1)
                            {
                                field[i, j] = (byteValue == 1);
                            }
                            else
                            {
                                // Обробка помилок або виведення повідомлення про неправильний біт
                                MessageBox.Show("Error: Invalid bit value in the file.");
                                return;
                            }
                        }
                    }
                }
            }
            catch (System.IO.IOException)
            {
                MessageBox.Show("Error reading!");
            }
        }
    }
}