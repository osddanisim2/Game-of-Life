namespace GameOfLife
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            splitContainer1 = new SplitContainer();
            label4 = new Label();
            radioButton4 = new RadioButton();
            radioButton3 = new RadioButton();
            radioButton2 = new RadioButton();
            radioButton1 = new RadioButton();
            buttonClearTable = new Button();
            buttonNextGeneration = new Button();
            label3 = new Label();
            Speed = new NumericUpDown();
            buttonStop = new Button();
            BStop = new Button();
            BStart = new Button();
            NUDDensity = new NumericUpDown();
            label2 = new Label();
            NUDResolution = new NumericUpDown();
            label1 = new Label();
            menuStrip1 = new MenuStrip();
            файлиToolStripMenuItem = new ToolStripMenuItem();
            записатиToolStripMenuItem = new ToolStripMenuItem();
            прочитатиToolStripMenuItem = new ToolStripMenuItem();
            pictureBox1 = new PictureBox();
            timer1 = new System.Windows.Forms.Timer(components);
            ((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
            splitContainer1.Panel1.SuspendLayout();
            splitContainer1.Panel2.SuspendLayout();
            splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)Speed).BeginInit();
            ((System.ComponentModel.ISupportInitialize)NUDDensity).BeginInit();
            ((System.ComponentModel.ISupportInitialize)NUDResolution).BeginInit();
            menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // splitContainer1
            // 
            splitContainer1.BorderStyle = BorderStyle.Fixed3D;
            splitContainer1.Dock = DockStyle.Fill;
            splitContainer1.FixedPanel = FixedPanel.Panel1;
            splitContainer1.IsSplitterFixed = true;
            splitContainer1.Location = new Point(0, 0);
            splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            splitContainer1.Panel1.Controls.Add(label4);
            splitContainer1.Panel1.Controls.Add(radioButton4);
            splitContainer1.Panel1.Controls.Add(radioButton3);
            splitContainer1.Panel1.Controls.Add(radioButton2);
            splitContainer1.Panel1.Controls.Add(radioButton1);
            splitContainer1.Panel1.Controls.Add(buttonClearTable);
            splitContainer1.Panel1.Controls.Add(buttonNextGeneration);
            splitContainer1.Panel1.Controls.Add(label3);
            splitContainer1.Panel1.Controls.Add(Speed);
            splitContainer1.Panel1.Controls.Add(buttonStop);
            splitContainer1.Panel1.Controls.Add(BStop);
            splitContainer1.Panel1.Controls.Add(BStart);
            splitContainer1.Panel1.Controls.Add(NUDDensity);
            splitContainer1.Panel1.Controls.Add(label2);
            splitContainer1.Panel1.Controls.Add(NUDResolution);
            splitContainer1.Panel1.Controls.Add(label1);
            splitContainer1.Panel1.Controls.Add(menuStrip1);
            // 
            // splitContainer1.Panel2
            // 
            splitContainer1.Panel2.Controls.Add(pictureBox1);
            splitContainer1.Size = new Size(1263, 723);
            splitContainer1.SplitterDistance = 172;
            splitContainer1.TabIndex = 0;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(20, 195);
            label4.Name = "label4";
            label4.Size = new Size(81, 15);
            label4.TabIndex = 15;
            label4.Text = "Тип Генерації";
            // 
            // radioButton4
            // 
            radioButton4.AutoSize = true;
            radioButton4.Location = new Point(21, 297);
            radioButton4.Name = "radioButton4";
            radioButton4.Size = new Size(117, 19);
            radioButton4.TabIndex = 14;
            radioButton4.Text = "Безкінечний ріст";
            radioButton4.UseVisualStyleBackColor = true;
            // 
            // radioButton3
            // 
            radioButton3.AutoSize = true;
            radioButton3.Location = new Point(21, 272);
            radioButton3.Name = "radioButton3";
            radioButton3.Size = new Size(156, 19);
            radioButton3.TabIndex = 13;
            radioButton3.Text = "Євангельський пістолет";
            radioButton3.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            radioButton2.AutoSize = true;
            radioButton2.Location = new Point(21, 247);
            radioButton2.Name = "radioButton2";
            radioButton2.Size = new Size(70, 19);
            radioButton2.TabIndex = 12;
            radioButton2.Text = "Глайдер";
            radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton1
            // 
            radioButton1.AutoSize = true;
            radioButton1.Checked = true;
            radioButton1.Location = new Point(21, 222);
            radioButton1.Name = "radioButton1";
            radioButton1.Size = new Size(123, 19);
            radioButton1.TabIndex = 11;
            radioButton1.TabStop = true;
            radioButton1.Text = "Псевдовипадково";
            radioButton1.UseVisualStyleBackColor = true;
            // 
            // buttonClearTable
            // 
            buttonClearTable.Location = new Point(20, 575);
            buttonClearTable.Name = "buttonClearTable";
            buttonClearTable.Size = new Size(121, 44);
            buttonClearTable.TabIndex = 10;
            buttonClearTable.Text = "Очистити поле";
            buttonClearTable.UseVisualStyleBackColor = true;
            buttonClearTable.Click += buttonClearTable_Click;
            // 
            // buttonNextGeneration
            // 
            buttonNextGeneration.Location = new Point(20, 515);
            buttonNextGeneration.Name = "buttonNextGeneration";
            buttonNextGeneration.Size = new Size(121, 44);
            buttonNextGeneration.TabIndex = 9;
            buttonNextGeneration.Text = "Нове покоління";
            buttonNextGeneration.UseVisualStyleBackColor = true;
            buttonNextGeneration.Click += NextGeneration_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(23, 140);
            label3.Name = "label3";
            label3.Size = new Size(54, 15);
            label3.TabIndex = 8;
            label3.Text = "Інтервал";
            // 
            // Speed
            // 
            Speed.Location = new Point(22, 158);
            Speed.Maximum = new decimal(new int[] { 500, 0, 0, 0 });
            Speed.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            Speed.Name = "Speed";
            Speed.Size = new Size(120, 23);
            Speed.TabIndex = 7;
            Speed.TextAlign = HorizontalAlignment.Right;
            Speed.Value = new decimal(new int[] { 25, 0, 0, 0 });
            // 
            // buttonStop
            // 
            buttonStop.Location = new Point(20, 396);
            buttonStop.Name = "buttonStop";
            buttonStop.Size = new Size(121, 44);
            buttonStop.TabIndex = 6;
            buttonStop.Text = "Запустити";
            buttonStop.UseVisualStyleBackColor = true;
            buttonStop.Click += buttonStop_Click;
            // 
            // BStop
            // 
            BStop.Location = new Point(20, 458);
            BStop.Name = "BStop";
            BStop.Size = new Size(121, 44);
            BStop.TabIndex = 5;
            BStop.Text = "Зупинити";
            BStop.UseVisualStyleBackColor = true;
            BStop.Click += BStop_Click;
            // 
            // BStart
            // 
            BStart.Location = new Point(21, 336);
            BStart.Name = "BStart";
            BStart.Size = new Size(121, 44);
            BStart.TabIndex = 4;
            BStart.Text = "Згенерувати";
            BStart.UseVisualStyleBackColor = true;
            BStart.Click += BStart_Click;
            // 
            // NUDDensity
            // 
            NUDDensity.Location = new Point(22, 104);
            NUDDensity.Maximum = new decimal(new int[] { 25, 0, 0, 0 });
            NUDDensity.Minimum = new decimal(new int[] { 2, 0, 0, 0 });
            NUDDensity.Name = "NUDDensity";
            NUDDensity.Size = new Size(120, 23);
            NUDDensity.TabIndex = 3;
            NUDDensity.TextAlign = HorizontalAlignment.Right;
            NUDDensity.Value = new decimal(new int[] { 25, 0, 0, 0 });
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(21, 86);
            label2.Name = "label2";
            label2.Size = new Size(123, 15);
            label2.TabIndex = 2;
            label2.Text = "Щільність населення";
            // 
            // NUDResolution
            // 
            NUDResolution.Location = new Point(23, 51);
            NUDResolution.Maximum = new decimal(new int[] { 25, 0, 0, 0 });
            NUDResolution.Minimum = new decimal(new int[] { 2, 0, 0, 0 });
            NUDResolution.Name = "NUDResolution";
            NUDResolution.Size = new Size(120, 23);
            NUDResolution.TabIndex = 1;
            NUDResolution.TextAlign = HorizontalAlignment.Right;
            NUDResolution.Value = new decimal(new int[] { 3, 0, 0, 0 });
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(22, 33);
            label1.Name = "label1";
            label1.Size = new Size(113, 15);
            label1.TabIndex = 0;
            label1.Text = "Роздільна здатність";
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { файлиToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(168, 24);
            menuStrip1.TabIndex = 16;
            menuStrip1.Text = "menuStrip1";
            // 
            // файлиToolStripMenuItem
            // 
            файлиToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { записатиToolStripMenuItem, прочитатиToolStripMenuItem });
            файлиToolStripMenuItem.Name = "файлиToolStripMenuItem";
            файлиToolStripMenuItem.Size = new Size(55, 20);
            файлиToolStripMenuItem.Text = "Файли";
            // 
            // записатиToolStripMenuItem
            // 
            записатиToolStripMenuItem.Name = "записатиToolStripMenuItem";
            записатиToolStripMenuItem.Size = new Size(134, 22);
            записатиToolStripMenuItem.Text = "Записати";
            записатиToolStripMenuItem.Click += записатиToolStripMenuItem_Click;
            // 
            // прочитатиToolStripMenuItem
            // 
            прочитатиToolStripMenuItem.Name = "прочитатиToolStripMenuItem";
            прочитатиToolStripMenuItem.Size = new Size(134, 22);
            прочитатиToolStripMenuItem.Text = "Прочитати";
            прочитатиToolStripMenuItem.Click += прочитатиToolStripMenuItem_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Dock = DockStyle.Fill;
            pictureBox1.Location = new Point(0, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(1083, 719);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            pictureBox1.MouseMove += pictureBox1_MouseMove;
            // 
            // timer1
            // 
            timer1.Interval = 30;
            timer1.Tick += timer1_Tick;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1263, 723);
            Controls.Add(splitContainer1);
            MainMenuStrip = menuStrip1;
            Name = "Form1";
            Text = "GameOfLife";
            WindowState = FormWindowState.Maximized;
            splitContainer1.Panel1.ResumeLayout(false);
            splitContainer1.Panel1.PerformLayout();
            splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainer1).EndInit();
            splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)Speed).EndInit();
            ((System.ComponentModel.ISupportInitialize)NUDDensity).EndInit();
            ((System.ComponentModel.ISupportInitialize)NUDResolution).EndInit();
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private SplitContainer splitContainer1;
        private NumericUpDown NUDResolution;
        private Label label1;
        private PictureBox pictureBox1;
        private NumericUpDown NUDDensity;
        private Label label2;
        private Button BStop;
        private Button BStart;
        private System.Windows.Forms.Timer timer1;
        private Button buttonStop;
        private NumericUpDown Speed;
        private Label label3;
        private Button buttonNextGeneration;
        private Button buttonClearTable;
        private RadioButton radioButton4;
        private RadioButton radioButton3;
        private RadioButton radioButton2;
        private RadioButton radioButton1;
        private Label label4;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem файлиToolStripMenuItem;
        private ToolStripMenuItem записатиToolStripMenuItem;
        private ToolStripMenuItem прочитатиToolStripMenuItem;
    }
}