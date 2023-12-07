using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game_of_Life
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using System.Windows.Forms;

    namespace Game_of_Life
    {
        internal class FileWriter
        {
            public static void SaveToFile(bool[,] field, int cols, int rows)
            {
                SaveFileDialog sv = new SaveFileDialog();

                sv.Filter = "Field Files (*.ff)|*.ff";

                if (sv.ShowDialog() == DialogResult.OK)
                {
                    FileStream fs;
                    try
                    {
                        fs = new FileStream(sv.FileName, FileMode.CreateNew, FileAccess.Write, FileShare.Write);

                        for (int i = 0; i < cols; i++)
                        {
                            for (int j = 0; j < rows; j++)
                            {
                                fs.WriteByte((field[i, j]) ? (byte)1 : (byte)0);
                            }
                        }
                    }
                    catch (IOException)
                    {
                        return;
                    }
                    fs.Close();
                }
            }
        }
    }
}
