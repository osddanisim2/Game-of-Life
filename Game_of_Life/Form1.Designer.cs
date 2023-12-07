namespace Game_of_Life
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.button5 = new System.Windows.Forms.Button();
            this.NextGeneration = new System.Windows.Forms.Button();
            this.BStop = new System.Windows.Forms.Button();
            this.buttonStop = new System.Windows.Forms.Button();
            this.BStart = new System.Windows.Forms.Button();
            this.radioButton4 = new System.Windows.Forms.RadioButton();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.label4 = new System.Windows.Forms.Label();
            this.Speed = new System.Windows.Forms.NumericUpDown();
            this.NUDDensity = new System.Windows.Forms.NumericUpDown();
            this.NUDResolution = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.файлиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.записатиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.прочитатиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Speed)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NUDDensity)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NUDResolution)).BeginInit();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // splitContainer1
            // 
            this.splitContainer1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.IsSplitterFixed = true;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.button5);
            this.splitContainer1.Panel1.Controls.Add(this.NextGeneration);
            this.splitContainer1.Panel1.Controls.Add(this.BStop);
            this.splitContainer1.Panel1.Controls.Add(this.buttonStop);
            this.splitContainer1.Panel1.Controls.Add(this.BStart);
            this.splitContainer1.Panel1.Controls.Add(this.radioButton4);
            this.splitContainer1.Panel1.Controls.Add(this.radioButton3);
            this.splitContainer1.Panel1.Controls.Add(this.radioButton2);
            this.splitContainer1.Panel1.Controls.Add(this.radioButton1);
            this.splitContainer1.Panel1.Controls.Add(this.label4);
            this.splitContainer1.Panel1.Controls.Add(this.Speed);
            this.splitContainer1.Panel1.Controls.Add(this.NUDDensity);
            this.splitContainer1.Panel1.Controls.Add(this.NUDResolution);
            this.splitContainer1.Panel1.Controls.Add(this.label3);
            this.splitContainer1.Panel1.Controls.Add(this.label2);
            this.splitContainer1.Panel1.Controls.Add(this.label1);
            this.splitContainer1.Panel1.Controls.Add(this.menuStrip1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.pictureBox1);
            this.splitContainer1.Size = new System.Drawing.Size(1033, 580);
            this.splitContainer1.SplitterDistance = 169;
            this.splitContainer1.TabIndex = 0;
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(25, 517);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(110, 44);
            this.button5.TabIndex = 16;
            this.button5.Text = "Очистити поле";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.buttonClearTable_Click);
            // 
            // NextGeneration
            // 
            this.NextGeneration.Location = new System.Drawing.Point(25, 467);
            this.NextGeneration.Name = "NextGeneration";
            this.NextGeneration.Size = new System.Drawing.Size(110, 44);
            this.NextGeneration.TabIndex = 15;
            this.NextGeneration.Text = "Нове покоління";
            this.NextGeneration.UseVisualStyleBackColor = true;
            this.NextGeneration.Click += new System.EventHandler(this.NextGeneration_Click);
            // 
            // BStop
            // 
            this.BStop.Location = new System.Drawing.Point(25, 417);
            this.BStop.Name = "BStop";
            this.BStop.Size = new System.Drawing.Size(110, 44);
            this.BStop.TabIndex = 14;
            this.BStop.Text = "Зупинити";
            this.BStop.UseVisualStyleBackColor = true;
            this.BStop.Click += new System.EventHandler(this.BStop_Click);
            // 
            // buttonStop
            // 
            this.buttonStop.Location = new System.Drawing.Point(25, 367);
            this.buttonStop.Name = "buttonStop";
            this.buttonStop.Size = new System.Drawing.Size(110, 44);
            this.buttonStop.TabIndex = 13;
            this.buttonStop.Text = "Запустити";
            this.buttonStop.UseVisualStyleBackColor = true;
            this.buttonStop.Click += new System.EventHandler(this.buttonStop_Click);
            // 
            // BStart
            // 
            this.BStart.Location = new System.Drawing.Point(25, 317);
            this.BStart.Name = "BStart";
            this.BStart.Size = new System.Drawing.Size(110, 44);
            this.BStart.TabIndex = 12;
            this.BStart.Text = "Згенерувати";
            this.BStart.UseVisualStyleBackColor = true;
            this.BStart.Click += new System.EventHandler(this.BStart_Click);
            // 
            // radioButton4
            // 
            this.radioButton4.AutoSize = true;
            this.radioButton4.Location = new System.Drawing.Point(15, 281);
            this.radioButton4.Name = "radioButton4";
            this.radioButton4.Size = new System.Drawing.Size(109, 17);
            this.radioButton4.TabIndex = 11;
            this.radioButton4.TabStop = true;
            this.radioButton4.Text = "Безкінечний ріст";
            this.radioButton4.UseVisualStyleBackColor = true;
            // 
            // radioButton3
            // 
            this.radioButton3.AutoSize = true;
            this.radioButton3.Location = new System.Drawing.Point(15, 258);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(148, 17);
            this.radioButton3.TabIndex = 10;
            this.radioButton3.TabStop = true;
            this.radioButton3.Text = "Євангельський пістолет";
            this.radioButton3.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(15, 235);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(67, 17);
            this.radioButton2.TabIndex = 9;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "Глайдер";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Checked = true;
            this.radioButton1.Location = new System.Drawing.Point(15, 212);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(117, 17);
            this.radioButton1.TabIndex = 8;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Псевдовипадково";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 187);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(76, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Тип Генерації";
            // 
            // Speed
            // 
            this.Speed.Location = new System.Drawing.Point(15, 149);
            this.Speed.Maximum = new decimal(new int[] {
            500,
            0,
            0,
            0});
            this.Speed.Minimum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.Speed.Name = "Speed";
            this.Speed.Size = new System.Drawing.Size(120, 20);
            this.Speed.TabIndex = 6;
            this.Speed.Value = new decimal(new int[] {
            25,
            0,
            0,
            0});
            // 
            // NUDDensity
            // 
            this.NUDDensity.Location = new System.Drawing.Point(15, 101);
            this.NUDDensity.Maximum = new decimal(new int[] {
            25,
            0,
            0,
            0});
            this.NUDDensity.Minimum = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.NUDDensity.Name = "NUDDensity";
            this.NUDDensity.Size = new System.Drawing.Size(120, 20);
            this.NUDDensity.TabIndex = 5;
            this.NUDDensity.Value = new decimal(new int[] {
            25,
            0,
            0,
            0});
            // 
            // NUDResolution
            // 
            this.NUDResolution.Location = new System.Drawing.Point(15, 52);
            this.NUDResolution.Maximum = new decimal(new int[] {
            25,
            0,
            0,
            0});
            this.NUDResolution.Minimum = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.NUDResolution.Name = "NUDResolution";
            this.NUDResolution.Size = new System.Drawing.Size(120, 20);
            this.NUDResolution.TabIndex = 4;
            this.NUDResolution.Value = new decimal(new int[] {
            3,
            0,
            0,
            0});
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 133);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Інтервал";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 85);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(113, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Щільність населення";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(109, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Роздільна здатність";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.файлиToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(165, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // файлиToolStripMenuItem
            // 
            this.файлиToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.записатиToolStripMenuItem,
            this.прочитатиToolStripMenuItem});
            this.файлиToolStripMenuItem.Name = "файлиToolStripMenuItem";
            this.файлиToolStripMenuItem.Size = new System.Drawing.Size(55, 20);
            this.файлиToolStripMenuItem.Text = "Файли";
            // 
            // записатиToolStripMenuItem
            // 
            this.записатиToolStripMenuItem.Name = "записатиToolStripMenuItem";
            this.записатиToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.записатиToolStripMenuItem.Text = "Записати";
            this.записатиToolStripMenuItem.Click += new System.EventHandler(this.записатиToolStripMenuItem_Click);
            // 
            // прочитатиToolStripMenuItem
            // 
            this.прочитатиToolStripMenuItem.Name = "прочитатиToolStripMenuItem";
            this.прочитатиToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.прочитатиToolStripMenuItem.Text = "Прочитати";
            this.прочитатиToolStripMenuItem.Click += new System.EventHandler(this.прочитатиToolStripMenuItem_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(856, 576);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseMove);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1033, 580);
            this.Controls.Add(this.splitContainer1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Speed)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NUDDensity)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NUDResolution)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.RadioButton radioButton4;
        private System.Windows.Forms.RadioButton radioButton3;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown Speed;
        private System.Windows.Forms.NumericUpDown NUDDensity;
        private System.Windows.Forms.NumericUpDown NUDResolution;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ToolStripMenuItem файлиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem записатиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem прочитатиToolStripMenuItem;
        private System.Windows.Forms.Button BStart;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button NextGeneration;
        private System.Windows.Forms.Button BStop;
        private System.Windows.Forms.Button buttonStop;
    }
}

