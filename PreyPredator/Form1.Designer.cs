namespace PreyPredator
{
    partial class Form1
    {
        /// <summary>
        /// Требуется переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Обязательный метод для поддержки конструктора - не изменяйте
        /// содержимое данного метода при помощи редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.buttonStart = new System.Windows.Forms.Button();
            this.numericUpDownGrass = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownPreys = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownPredators = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.buttonPause = new System.Windows.Forms.Button();
            this.trackBarSpeed = new System.Windows.Forms.TrackBar();
            this.timerMain = new System.Windows.Forms.Timer(this.components);
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownGrass)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownPreys)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownPredators)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarSpeed)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(11, 22);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(500, 500);
            this.panel1.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.buttonStart);
            this.groupBox1.Controls.Add(this.numericUpDownGrass);
            this.groupBox1.Controls.Add(this.numericUpDownPreys);
            this.groupBox1.Controls.Add(this.numericUpDownPredators);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(537, 22);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(243, 263);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Исходные данные";
            // 
            // buttonStart
            // 
            this.buttonStart.Location = new System.Drawing.Point(10, 221);
            this.buttonStart.Name = "buttonStart";
            this.buttonStart.Size = new System.Drawing.Size(70, 26);
            this.buttonStart.TabIndex = 7;
            this.buttonStart.Text = "Старт";
            this.buttonStart.UseVisualStyleBackColor = true;
            this.buttonStart.Click += new System.EventHandler(this.buttonStart_Click);
            // 
            // numericUpDownGrass
            // 
            this.numericUpDownGrass.Location = new System.Drawing.Point(10, 179);
            this.numericUpDownGrass.Maximum = new decimal(new int[] {
            250,
            0,
            0,
            0});
            this.numericUpDownGrass.Name = "numericUpDownGrass";
            this.numericUpDownGrass.Size = new System.Drawing.Size(120, 22);
            this.numericUpDownGrass.TabIndex = 6;
            this.numericUpDownGrass.Value = new decimal(new int[] {
            30,
            0,
            0,
            0});
            // 
            // numericUpDownPreys
            // 
            this.numericUpDownPreys.Location = new System.Drawing.Point(10, 116);
            this.numericUpDownPreys.Name = "numericUpDownPreys";
            this.numericUpDownPreys.Size = new System.Drawing.Size(120, 22);
            this.numericUpDownPreys.TabIndex = 5;
            this.numericUpDownPreys.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            // 
            // numericUpDownPredators
            // 
            this.numericUpDownPredators.Location = new System.Drawing.Point(10, 52);
            this.numericUpDownPredators.Name = "numericUpDownPredators";
            this.numericUpDownPredators.Size = new System.Drawing.Size(120, 22);
            this.numericUpDownPredators.TabIndex = 4;
            this.numericUpDownPredators.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 159);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(117, 17);
            this.label3.TabIndex = 3;
            this.label3.Text = "Трава (зеленая)";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 96);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(146, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Травоядные (белые)";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(122, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Хищники (серые)";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.buttonPause);
            this.groupBox2.Controls.Add(this.trackBarSpeed);
            this.groupBox2.Location = new System.Drawing.Point(537, 309);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(243, 155);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Скорость симуляции";
            // 
            // buttonPause
            // 
            this.buttonPause.Location = new System.Drawing.Point(10, 99);
            this.buttonPause.Name = "buttonPause";
            this.buttonPause.Size = new System.Drawing.Size(70, 28);
            this.buttonPause.TabIndex = 1;
            this.buttonPause.Text = "Пауза";
            this.buttonPause.UseVisualStyleBackColor = true;
            this.buttonPause.Click += new System.EventHandler(this.buttonPause_Click);
            // 
            // trackBarSpeed
            // 
            this.trackBarSpeed.Location = new System.Drawing.Point(10, 47);
            this.trackBarSpeed.Maximum = 1499;
            this.trackBarSpeed.Name = "trackBarSpeed";
            this.trackBarSpeed.Size = new System.Drawing.Size(206, 56);
            this.trackBarSpeed.TabIndex = 0;
            this.trackBarSpeed.Value = 750;
            this.trackBarSpeed.Scroll += new System.EventHandler(this.trackBarSpeed_Scroll);
            // 
            // timerMain
            // 
            this.timerMain.Tick += new System.EventHandler(this.timerMain_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(801, 550);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Multi-agent based simulation prey-predator";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownGrass)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownPreys)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownPredators)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarSpeed)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button buttonStart;
        private System.Windows.Forms.NumericUpDown numericUpDownGrass;
        private System.Windows.Forms.NumericUpDown numericUpDownPreys;
        private System.Windows.Forms.NumericUpDown numericUpDownPredators;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button buttonPause;
        private System.Windows.Forms.TrackBar trackBarSpeed;
        private System.Windows.Forms.Timer timerMain;
    }
}

