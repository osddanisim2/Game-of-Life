using System;
using System.Drawing.Text;

namespace GameOfLife
{
    public partial class Form1 : Form
    {
        private Graphics graphics;
        private int resolution;
        GameEngine gameEngine;
        public Form1()
        {
            InitializeComponent();
        }

        private void StartGame()
        {
            if (timer1.Enabled)
                return;

            int a = 0;
            if (radioButton1.Checked)
            {
                a = 1;
            }
            else if (radioButton2.Checked)
            {
                a = 2;
            }
            else if (radioButton3.Checked)
            {
                a = 3;
            }
            else if (radioButton4.Checked)
            {
                a = 4;
            }

            NUDResolution.Enabled = false;
            NUDDensity.Enabled = false;
            resolution = (int)NUDResolution.Value;

            gameEngine = new GameEngine
            (
                rows: pictureBox1.Height / resolution,
                cols: pictureBox1.Width / resolution,
                density: (int)NUDDensity.Minimum + (int)NUDDensity.Maximum - (int)NUDDensity.Value,
                generationType: a
            );

            Text = $"Покоління {gameEngine.CurrentGeneration}";

            pictureBox1.Image = new Bitmap(pictureBox1.Width, pictureBox1.Height);
            graphics = Graphics.FromImage(pictureBox1.Image);
            DrawNextGeneration();
        }
        private void StopGame()
        {
            NUDResolution.Enabled = true;
            NUDDensity.Enabled = true;
            if (!timer1.Enabled)
                return;

            timer1.Stop();
        }

        private void DrawNextGeneration()
        {
            graphics.Clear(Color.Black);
            var field = gameEngine.GetCurrentGeneration();

            for (int x = 0; x < field.GetLength(0); x++)
                for (int y = 0; y < field.GetLength(1); y++)
                    if (field[x, y])
                    {
                        Random random = new Random();
                        int randomRed = random.Next(256);
                        int randomBlue = random.Next(256);
                        Color randomColor = Color.FromArgb(randomRed, 200, randomBlue);

                        graphics.FillRectangle(new SolidBrush(randomColor), x * resolution, y * resolution, resolution - 1, resolution - 1);
                    }
            pictureBox1.Refresh();
            Text = $"Покоління {gameEngine.CurrentGeneration}";
            gameEngine.NextGeneration();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            DrawNextGeneration();
        }

        private void BStart_Click(object sender, EventArgs e)
        {
            StartGame();
        }

        private void BStop_Click(object sender, EventArgs e)
        {
            StopGame();
        }

        private void pictureBox1_MouseMove(object sender, MouseEventArgs e)
        {
            if (!timer1.Enabled)
                return;

            if (e.Button == MouseButtons.Left)
            {
                var x = e.Location.X / resolution;
                var y = e.Location.Y / resolution;
                gameEngine.AddCell(x, y);
                pictureBox1.Refresh();
            }
            if (e.Button == MouseButtons.Right)
            {
                var x = e.Location.X / resolution;
                var y = e.Location.Y / resolution;
                gameEngine.RemoveCell(x, y);
            }

        }

        private void buttonStop_Click(object sender, EventArgs e)
        {
            if (timer1.Enabled)
                return;
            NUDResolution.Enabled = false;
            NUDDensity.Enabled = false;
            int speed = Convert.ToInt32(Speed.Value);
            timer1.Interval = speed;
            timer1.Start();
        }

        private void NextGeneration_Click(object sender, EventArgs e)
        {
            DrawNextGeneration();
        }

        private void buttonClearTable_Click(object sender, EventArgs e)
        {
            if (!timer1.Enabled)
            {
                graphics.Clear(Color.White);
                gameEngine.ClearTable();
                pictureBox1.Refresh();
            }
        }

        private void записатиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FileWriter.SaveToFile(gameEngine.GetCurrentGeneration(), gameEngine.cols, gameEngine.rows);
        }

        private void прочитатиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Field Files (*.ff)|*.ff|All Files (*.*)|*.*";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string filePath = openFileDialog.FileName;

                // Передайте шлях до вибраного файлу до методу ReadInfo
                gameEngine.ReadInfo(filePath);

                // Оновіть інтерфейс або виконайте інші дії, які вам необхідні після читання з файлу
                // Наприклад, можливо, ви хочете перемалювати поле на формі
                DrawNextGeneration();
            }
        }
    }
}