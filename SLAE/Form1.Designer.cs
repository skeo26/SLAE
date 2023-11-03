namespace SLAE
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
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
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.buttonCalculate = new System.Windows.Forms.Button();
            this.dataGridViewMatrix = new System.Windows.Forms.DataGridView();
            this.dataGridViewVector = new System.Windows.Forms.DataGridView();
            this.dataGridViewResult = new System.Windows.Forms.DataGridView();
            this.buttonMinusSize = new System.Windows.Forms.Button();
            this.labelSizeSLAE = new System.Windows.Forms.Label();
            this.labelA = new System.Windows.Forms.Label();
            this.labelVectorB = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonGenerator = new System.Windows.Forms.Button();
            this.checkBoxEquality = new System.Windows.Forms.CheckBox();
            this.labelTimeGauss = new System.Windows.Forms.Label();
            this.labelTimeCramer = new System.Windows.Forms.Label();
            this.labelTimeLU = new System.Windows.Forms.Label();
            this.labelTimeSimpleIteration = new System.Windows.Forms.Label();
            this.labelTimeGaussZeidel = new System.Windows.Forms.Label();
            this.labelTimes = new System.Windows.Forms.Label();
            this.buttonClear = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.buttonPlusSize = new System.Windows.Forms.Button();
            this.labelTimeUpperRelaxation = new System.Windows.Forms.Label();
            this.labelTimeRotation = new System.Windows.Forms.Label();
            this.buttonGauss = new System.Windows.Forms.Button();
            this.buttonCramer = new System.Windows.Forms.Button();
            this.buttonGaussZeidel = new System.Windows.Forms.Button();
            this.buttonUpperRelaxation = new System.Windows.Forms.Button();
            this.buttonSimpleIteration = new System.Windows.Forms.Button();
            this.buttonLU = new System.Windows.Forms.Button();
            this.buttonRotation = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMatrix)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewVector)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewResult)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonCalculate
            // 
            this.buttonCalculate.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.buttonCalculate.Location = new System.Drawing.Point(682, 292);
            this.buttonCalculate.Margin = new System.Windows.Forms.Padding(2);
            this.buttonCalculate.Name = "buttonCalculate";
            this.buttonCalculate.Size = new System.Drawing.Size(88, 33);
            this.buttonCalculate.TabIndex = 0;
            this.buttonCalculate.Text = "Solve";
            this.buttonCalculate.UseVisualStyleBackColor = true;
            this.buttonCalculate.Click += new System.EventHandler(this.button1_Click);
            // 
            // dataGridViewMatrix
            // 
            this.dataGridViewMatrix.AllowUserToAddRows = false;
            this.dataGridViewMatrix.AllowUserToResizeColumns = false;
            this.dataGridViewMatrix.AllowUserToResizeRows = false;
            this.dataGridViewMatrix.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewMatrix.BackgroundColor = System.Drawing.SystemColors.MenuBar;
            this.dataGridViewMatrix.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewMatrix.ColumnHeadersVisible = false;
            this.dataGridViewMatrix.Location = new System.Drawing.Point(15, 32);
            this.dataGridViewMatrix.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridViewMatrix.Name = "dataGridViewMatrix";
            this.dataGridViewMatrix.RowHeadersVisible = false;
            this.dataGridViewMatrix.RowHeadersWidth = 40;
            this.dataGridViewMatrix.RowTemplate.Height = 24;
            this.dataGridViewMatrix.Size = new System.Drawing.Size(264, 243);
            this.dataGridViewMatrix.TabIndex = 1;
            // 
            // dataGridViewVector
            // 
            this.dataGridViewVector.AllowUserToAddRows = false;
            this.dataGridViewVector.AllowUserToResizeColumns = false;
            this.dataGridViewVector.AllowUserToResizeRows = false;
            this.dataGridViewVector.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewVector.BackgroundColor = System.Drawing.SystemColors.MenuBar;
            this.dataGridViewVector.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewVector.ColumnHeadersVisible = false;
            this.dataGridViewVector.Location = new System.Drawing.Point(300, 32);
            this.dataGridViewVector.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridViewVector.Name = "dataGridViewVector";
            this.dataGridViewVector.RowHeadersVisible = false;
            this.dataGridViewVector.RowTemplate.Height = 24;
            this.dataGridViewVector.Size = new System.Drawing.Size(66, 243);
            this.dataGridViewVector.TabIndex = 2;
            // 
            // dataGridViewResult
            // 
            this.dataGridViewResult.AllowUserToResizeColumns = false;
            this.dataGridViewResult.AllowUserToResizeRows = false;
            this.dataGridViewResult.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewResult.BackgroundColor = System.Drawing.SystemColors.MenuBar;
            this.dataGridViewResult.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewResult.ColumnHeadersVisible = false;
            this.dataGridViewResult.Location = new System.Drawing.Point(385, 32);
            this.dataGridViewResult.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridViewResult.Name = "dataGridViewResult";
            this.dataGridViewResult.RowHeadersVisible = false;
            this.dataGridViewResult.RowTemplate.Height = 24;
            this.dataGridViewResult.Size = new System.Drawing.Size(86, 243);
            this.dataGridViewResult.TabIndex = 3;
            // 
            // buttonMinusSize
            // 
            this.buttonMinusSize.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.buttonMinusSize.Location = new System.Drawing.Point(915, 352);
            this.buttonMinusSize.Margin = new System.Windows.Forms.Padding(2);
            this.buttonMinusSize.Name = "buttonMinusSize";
            this.buttonMinusSize.Size = new System.Drawing.Size(10, 12);
            this.buttonMinusSize.TabIndex = 4;
            this.buttonMinusSize.Text = "-";
            this.buttonMinusSize.UseVisualStyleBackColor = true;
            this.buttonMinusSize.Click += new System.EventHandler(this.buttonMinusSize_Click);
            // 
            // labelSizeSLAE
            // 
            this.labelSizeSLAE.AutoSize = true;
            this.labelSizeSLAE.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.labelSizeSLAE.Location = new System.Drawing.Point(11, 291);
            this.labelSizeSLAE.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelSizeSLAE.Name = "labelSizeSLAE";
            this.labelSizeSLAE.Size = new System.Drawing.Size(82, 24);
            this.labelSizeSLAE.TabIndex = 6;
            this.labelSizeSLAE.Text = "Размер:";
            // 
            // labelA
            // 
            this.labelA.AutoSize = true;
            this.labelA.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.labelA.Location = new System.Drawing.Point(11, 6);
            this.labelA.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelA.Name = "labelA";
            this.labelA.Size = new System.Drawing.Size(23, 24);
            this.labelA.TabIndex = 7;
            this.labelA.Text = "A";
            // 
            // labelVectorB
            // 
            this.labelVectorB.AutoSize = true;
            this.labelVectorB.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelVectorB.Location = new System.Drawing.Point(296, 6);
            this.labelVectorB.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelVectorB.Name = "labelVectorB";
            this.labelVectorB.Size = new System.Drawing.Size(21, 24);
            this.labelVectorB.TabIndex = 8;
            this.labelVectorB.Text = "b";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.label1.Location = new System.Drawing.Point(381, 6);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(20, 24);
            this.label1.TabIndex = 9;
            this.label1.Text = "x";
            // 
            // buttonGenerator
            // 
            this.buttonGenerator.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonGenerator.Location = new System.Drawing.Point(262, 291);
            this.buttonGenerator.Margin = new System.Windows.Forms.Padding(2);
            this.buttonGenerator.Name = "buttonGenerator";
            this.buttonGenerator.Size = new System.Drawing.Size(104, 34);
            this.buttonGenerator.TabIndex = 10;
            this.buttonGenerator.Text = "Random";
            this.buttonGenerator.UseVisualStyleBackColor = true;
            this.buttonGenerator.Click += new System.EventHandler(this.buttonGenerator_Click);
            // 
            // checkBoxEquality
            // 
            this.checkBoxEquality.AutoSize = true;
            this.checkBoxEquality.Enabled = false;
            this.checkBoxEquality.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.checkBoxEquality.Location = new System.Drawing.Point(675, 336);
            this.checkBoxEquality.Margin = new System.Windows.Forms.Padding(2);
            this.checkBoxEquality.Name = "checkBoxEquality";
            this.checkBoxEquality.Size = new System.Drawing.Size(225, 28);
            this.checkBoxEquality.TabIndex = 11;
            this.checkBoxEquality.Text = "Совпадение решения";
            this.checkBoxEquality.UseVisualStyleBackColor = true;
            // 
            // labelTimeGauss
            // 
            this.labelTimeGauss.AutoSize = true;
            this.labelTimeGauss.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.labelTimeGauss.Location = new System.Drawing.Point(565, 42);
            this.labelTimeGauss.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelTimeGauss.Name = "labelTimeGauss";
            this.labelTimeGauss.Size = new System.Drawing.Size(146, 24);
            this.labelTimeGauss.TabIndex = 12;
            this.labelTimeGauss.Text = "Метод Гаусса -";
            // 
            // labelTimeCramer
            // 
            this.labelTimeCramer.AutoSize = true;
            this.labelTimeCramer.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.labelTimeCramer.Location = new System.Drawing.Point(565, 75);
            this.labelTimeCramer.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelTimeCramer.Name = "labelTimeCramer";
            this.labelTimeCramer.Size = new System.Drawing.Size(169, 24);
            this.labelTimeCramer.TabIndex = 13;
            this.labelTimeCramer.Text = "Метод Крамера - ";
            // 
            // labelTimeLU
            // 
            this.labelTimeLU.AutoSize = true;
            this.labelTimeLU.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.labelTimeLU.Location = new System.Drawing.Point(565, 214);
            this.labelTimeLU.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelTimeLU.Name = "labelTimeLU";
            this.labelTimeLU.Size = new System.Drawing.Size(229, 24);
            this.labelTimeLU.TabIndex = 14;
            this.labelTimeLU.Text = "Метод LU-разложения - ";
            // 
            // labelTimeSimpleIteration
            // 
            this.labelTimeSimpleIteration.AutoSize = true;
            this.labelTimeSimpleIteration.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.labelTimeSimpleIteration.Location = new System.Drawing.Point(565, 179);
            this.labelTimeSimpleIteration.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelTimeSimpleIteration.Name = "labelTimeSimpleIteration";
            this.labelTimeSimpleIteration.Size = new System.Drawing.Size(257, 24);
            this.labelTimeSimpleIteration.TabIndex = 15;
            this.labelTimeSimpleIteration.Text = "Метод простой итерации - ";
            // 
            // labelTimeGaussZeidel
            // 
            this.labelTimeGaussZeidel.AutoSize = true;
            this.labelTimeGaussZeidel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.labelTimeGaussZeidel.Location = new System.Drawing.Point(565, 112);
            this.labelTimeGaussZeidel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelTimeGaussZeidel.Name = "labelTimeGaussZeidel";
            this.labelTimeGaussZeidel.Size = new System.Drawing.Size(235, 24);
            this.labelTimeGaussZeidel.TabIndex = 16;
            this.labelTimeGaussZeidel.Text = "Метод Гаусса-Зейделя - ";
            // 
            // labelTimes
            // 
            this.labelTimes.AutoSize = true;
            this.labelTimes.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.labelTimes.Location = new System.Drawing.Point(565, 9);
            this.labelTimes.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelTimes.Name = "labelTimes";
            this.labelTimes.Size = new System.Drawing.Size(72, 24);
            this.labelTimes.TabIndex = 17;
            this.labelTimes.Text = "Время:";
            // 
            // buttonClear
            // 
            this.buttonClear.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonClear.Location = new System.Drawing.Point(454, 291);
            this.buttonClear.Margin = new System.Windows.Forms.Padding(2);
            this.buttonClear.Name = "buttonClear";
            this.buttonClear.Size = new System.Drawing.Size(116, 34);
            this.buttonClear.TabIndex = 18;
            this.buttonClear.Text = "Clear";
            this.buttonClear.UseVisualStyleBackColor = true;
            this.buttonClear.Click += new System.EventHandler(this.buttonClear_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12"});
            this.comboBox1.Location = new System.Drawing.Point(98, 294);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(43, 21);
            this.comboBox1.TabIndex = 19;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // buttonPlusSize
            // 
            this.buttonPlusSize.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.buttonPlusSize.Location = new System.Drawing.Point(904, 352);
            this.buttonPlusSize.Margin = new System.Windows.Forms.Padding(2);
            this.buttonPlusSize.Name = "buttonPlusSize";
            this.buttonPlusSize.Size = new System.Drawing.Size(10, 12);
            this.buttonPlusSize.TabIndex = 5;
            this.buttonPlusSize.Text = "+";
            this.buttonPlusSize.UseVisualStyleBackColor = true;
            this.buttonPlusSize.Click += new System.EventHandler(this.buttonPlusSize_Click);
            // 
            // labelTimeUpperRelaxation
            // 
            this.labelTimeUpperRelaxation.AutoSize = true;
            this.labelTimeUpperRelaxation.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.labelTimeUpperRelaxation.Location = new System.Drawing.Point(565, 146);
            this.labelTimeUpperRelaxation.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelTimeUpperRelaxation.Name = "labelTimeUpperRelaxation";
            this.labelTimeUpperRelaxation.Size = new System.Drawing.Size(276, 24);
            this.labelTimeUpperRelaxation.TabIndex = 20;
            this.labelTimeUpperRelaxation.Text = "Метод верхней релаксации - ";
            // 
            // labelTimeRotation
            // 
            this.labelTimeRotation.AutoSize = true;
            this.labelTimeRotation.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.labelTimeRotation.Location = new System.Drawing.Point(565, 248);
            this.labelTimeRotation.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelTimeRotation.Name = "labelTimeRotation";
            this.labelTimeRotation.Size = new System.Drawing.Size(143, 24);
            this.labelTimeRotation.TabIndex = 21;
            this.labelTimeRotation.Text = "Метод Якоби -";
            this.labelTimeRotation.Click += new System.EventHandler(this.labelTimeRotation_Click);
            // 
            // buttonGauss
            // 
            this.buttonGauss.Location = new System.Drawing.Point(485, 45);
            this.buttonGauss.Name = "buttonGauss";
            this.buttonGauss.Size = new System.Drawing.Size(75, 23);
            this.buttonGauss.TabIndex = 22;
            this.buttonGauss.Text = "Solve ->";
            this.buttonGauss.UseVisualStyleBackColor = true;
            this.buttonGauss.Click += new System.EventHandler(this.buttonGauss_Click);
            // 
            // buttonCramer
            // 
            this.buttonCramer.Location = new System.Drawing.Point(485, 78);
            this.buttonCramer.Name = "buttonCramer";
            this.buttonCramer.Size = new System.Drawing.Size(75, 23);
            this.buttonCramer.TabIndex = 23;
            this.buttonCramer.Text = "Solve ->";
            this.buttonCramer.UseVisualStyleBackColor = true;
            this.buttonCramer.Click += new System.EventHandler(this.buttonCramer_Click);
            // 
            // buttonGaussZeidel
            // 
            this.buttonGaussZeidel.Location = new System.Drawing.Point(485, 115);
            this.buttonGaussZeidel.Name = "buttonGaussZeidel";
            this.buttonGaussZeidel.Size = new System.Drawing.Size(75, 23);
            this.buttonGaussZeidel.TabIndex = 24;
            this.buttonGaussZeidel.Text = "Solve ->";
            this.buttonGaussZeidel.UseVisualStyleBackColor = true;
            this.buttonGaussZeidel.Click += new System.EventHandler(this.buttonGaussZeidel_Click);
            // 
            // buttonUpperRelaxation
            // 
            this.buttonUpperRelaxation.Location = new System.Drawing.Point(485, 147);
            this.buttonUpperRelaxation.Name = "buttonUpperRelaxation";
            this.buttonUpperRelaxation.Size = new System.Drawing.Size(75, 23);
            this.buttonUpperRelaxation.TabIndex = 25;
            this.buttonUpperRelaxation.Text = "Solve ->";
            this.buttonUpperRelaxation.UseVisualStyleBackColor = true;
            this.buttonUpperRelaxation.Click += new System.EventHandler(this.buttonUpperRelaxation_Click);
            // 
            // buttonSimpleIteration
            // 
            this.buttonSimpleIteration.Location = new System.Drawing.Point(485, 180);
            this.buttonSimpleIteration.Name = "buttonSimpleIteration";
            this.buttonSimpleIteration.Size = new System.Drawing.Size(75, 23);
            this.buttonSimpleIteration.TabIndex = 26;
            this.buttonSimpleIteration.Text = "Solve ->";
            this.buttonSimpleIteration.UseVisualStyleBackColor = true;
            this.buttonSimpleIteration.Click += new System.EventHandler(this.buttonSimpleIteration_Click);
            // 
            // buttonLU
            // 
            this.buttonLU.Location = new System.Drawing.Point(485, 215);
            this.buttonLU.Name = "buttonLU";
            this.buttonLU.Size = new System.Drawing.Size(75, 23);
            this.buttonLU.TabIndex = 27;
            this.buttonLU.Text = "Solve ->";
            this.buttonLU.UseVisualStyleBackColor = true;
            this.buttonLU.Click += new System.EventHandler(this.buttonLU_Click);
            // 
            // buttonRotation
            // 
            this.buttonRotation.Location = new System.Drawing.Point(485, 249);
            this.buttonRotation.Name = "buttonRotation";
            this.buttonRotation.Size = new System.Drawing.Size(75, 23);
            this.buttonRotation.TabIndex = 28;
            this.buttonRotation.Text = "Solve ->";
            this.buttonRotation.UseVisualStyleBackColor = true;
            this.buttonRotation.Click += new System.EventHandler(this.buttonRotation_Click);
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(147, 285);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(110, 40);
            this.label2.TabIndex = 29;
            this.label2.Text = "Заполнить матрицу случайными значеинями";
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(394, 291);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 34);
            this.label3.TabIndex = 30;
            this.label3.Text = "Очистить матрицу";
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(589, 291);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(88, 37);
            this.label4.TabIndex = 31;
            this.label4.Text = "Решить всеми способами";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(950, 327);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.buttonRotation);
            this.Controls.Add(this.buttonLU);
            this.Controls.Add(this.buttonSimpleIteration);
            this.Controls.Add(this.buttonUpperRelaxation);
            this.Controls.Add(this.buttonGaussZeidel);
            this.Controls.Add(this.buttonCramer);
            this.Controls.Add(this.buttonGauss);
            this.Controls.Add(this.labelTimeRotation);
            this.Controls.Add(this.labelTimeUpperRelaxation);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.buttonClear);
            this.Controls.Add(this.labelTimes);
            this.Controls.Add(this.labelTimeGaussZeidel);
            this.Controls.Add(this.labelTimeSimpleIteration);
            this.Controls.Add(this.labelTimeLU);
            this.Controls.Add(this.labelTimeCramer);
            this.Controls.Add(this.labelTimeGauss);
            this.Controls.Add(this.checkBoxEquality);
            this.Controls.Add(this.buttonGenerator);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.labelVectorB);
            this.Controls.Add(this.labelA);
            this.Controls.Add(this.labelSizeSLAE);
            this.Controls.Add(this.buttonPlusSize);
            this.Controls.Add(this.buttonMinusSize);
            this.Controls.Add(this.dataGridViewResult);
            this.Controls.Add(this.dataGridViewVector);
            this.Controls.Add(this.dataGridViewMatrix);
            this.Controls.Add(this.buttonCalculate);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.Text = "SLAE Calculator";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMatrix)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewVector)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewResult)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonCalculate;
        private System.Windows.Forms.DataGridView dataGridViewMatrix;
        private System.Windows.Forms.DataGridView dataGridViewVector;
        private System.Windows.Forms.DataGridView dataGridViewResult;
        private System.Windows.Forms.Button buttonMinusSize;
        private System.Windows.Forms.Label labelSizeSLAE;
        private System.Windows.Forms.Label labelA;
        private System.Windows.Forms.Label labelVectorB;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonGenerator;
        private System.Windows.Forms.CheckBox checkBoxEquality;
        private System.Windows.Forms.Label labelTimeGauss;
        private System.Windows.Forms.Label labelTimeCramer;
        private System.Windows.Forms.Label labelTimeLU;
        private System.Windows.Forms.Label labelTimeSimpleIteration;
        private System.Windows.Forms.Label labelTimeGaussZeidel;
        private System.Windows.Forms.Label labelTimes;
        private System.Windows.Forms.Button buttonClear;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button buttonPlusSize;
        private System.Windows.Forms.Label labelTimeUpperRelaxation;
        private System.Windows.Forms.Label labelTimeRotation;
        private System.Windows.Forms.Button buttonGauss;
        private System.Windows.Forms.Button buttonCramer;
        private System.Windows.Forms.Button buttonGaussZeidel;
        private System.Windows.Forms.Button buttonUpperRelaxation;
        private System.Windows.Forms.Button buttonSimpleIteration;
        private System.Windows.Forms.Button buttonLU;
        private System.Windows.Forms.Button buttonRotation;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}

