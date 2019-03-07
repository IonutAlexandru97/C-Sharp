namespace ExcelCalculator
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
            this.dateTimeStartInterval = new System.Windows.Forms.DateTimePicker();
            this.dateEndTimeInterval = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.progress = new System.Windows.Forms.ProgressBar();
            this.label4 = new System.Windows.Forms.Label();
            this.btnLoadExcel = new System.Windows.Forms.Button();
            this.excelLoader = new System.Windows.Forms.OpenFileDialog();
            this.processWorker = new System.ComponentModel.BackgroundWorker();
            this.sum1Text = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.sum2Text = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.resetResultsBtn = new System.Windows.Forms.Button();
            this.computeBtn = new System.Windows.Forms.Button();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.textBox8 = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.textBox9 = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.textBox10 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // dateTimeStartInterval
            // 
            this.dateTimeStartInterval.Location = new System.Drawing.Point(55, 13);
            this.dateTimeStartInterval.Name = "dateTimeStartInterval";
            this.dateTimeStartInterval.Size = new System.Drawing.Size(200, 20);
            this.dateTimeStartInterval.TabIndex = 0;
            // 
            // dateEndTimeInterval
            // 
            this.dateEndTimeInterval.Location = new System.Drawing.Point(55, 39);
            this.dateEndTimeInterval.Name = "dateEndTimeInterval";
            this.dateEndTimeInterval.Size = new System.Drawing.Size(200, 20);
            this.dateEndTimeInterval.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(33, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "From:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 46);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(23, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "To:";
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(86, 127);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.textBox1.Size = new System.Drawing.Size(1252, 343);
            this.textBox1.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(578, 88);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(118, 20);
            this.label3.TabIndex = 5;
            this.label3.Text = "Detailed Result";
            // 
            // progress
            // 
            this.progress.Location = new System.Drawing.Point(86, 476);
            this.progress.Name = "progress";
            this.progress.Size = new System.Drawing.Size(1252, 23);
            this.progress.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(16, 486);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(51, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Progress:";
            // 
            // btnLoadExcel
            // 
            this.btnLoadExcel.Location = new System.Drawing.Point(86, 506);
            this.btnLoadExcel.Name = "btnLoadExcel";
            this.btnLoadExcel.Size = new System.Drawing.Size(75, 23);
            this.btnLoadExcel.TabIndex = 8;
            this.btnLoadExcel.Text = "Load Excel";
            this.btnLoadExcel.UseVisualStyleBackColor = true;
            this.btnLoadExcel.Click += new System.EventHandler(this.btnLoadExcel_Click);
            // 
            // excelLoader
            // 
            this.excelLoader.FileName = "excelLoader";
            this.excelLoader.FileOk += new System.ComponentModel.CancelEventHandler(this.excelLoader_FileOk);
            // 
            // processWorker
            // 
            this.processWorker.WorkerReportsProgress = true;
            this.processWorker.DoWork += new System.ComponentModel.DoWorkEventHandler(this.processWorker_DoWork);
            this.processWorker.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.processWorker_ProgressChanged);
            this.processWorker.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.processWorker_RunWorkerCompleted);
            // 
            // sum1Text
            // 
            this.sum1Text.Location = new System.Drawing.Point(427, 530);
            this.sum1Text.Name = "sum1Text";
            this.sum1Text.Size = new System.Drawing.Size(116, 20);
            this.sum1Text.TabIndex = 9;
            this.sum1Text.Text = "0";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(462, 514);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(46, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "F < 0.65";
            // 
            // sum2Text
            // 
            this.sum2Text.Location = new System.Drawing.Point(617, 530);
            this.sum2Text.Name = "sum2Text";
            this.sum2Text.Size = new System.Drawing.Size(116, 20);
            this.sum2Text.TabIndex = 11;
            this.sum2Text.Text = "0";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(634, 514);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(76, 13);
            this.label6.TabIndex = 12;
            this.label6.Text = " 0.65 < F < 0.9";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(827, 514);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(43, 13);
            this.label7.TabIndex = 13;
            this.label7.Text = " F > 0.9";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(786, 530);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(116, 20);
            this.textBox2.TabIndex = 14;
            this.textBox2.Text = "0";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(371, 530);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(39, 13);
            this.label8.TabIndex = 15;
            this.label8.Text = "Totals:";
            // 
            // resetResultsBtn
            // 
            this.resetResultsBtn.Location = new System.Drawing.Point(168, 505);
            this.resetResultsBtn.Name = "resetResultsBtn";
            this.resetResultsBtn.Size = new System.Drawing.Size(106, 23);
            this.resetResultsBtn.TabIndex = 16;
            this.resetResultsBtn.Text = "Reset Results";
            this.resetResultsBtn.UseVisualStyleBackColor = true;
            this.resetResultsBtn.Click += new System.EventHandler(this.resetResultsBtn_Click);
            // 
            // computeBtn
            // 
            this.computeBtn.Location = new System.Drawing.Point(168, 591);
            this.computeBtn.Name = "computeBtn";
            this.computeBtn.Size = new System.Drawing.Size(106, 23);
            this.computeBtn.TabIndex = 17;
            this.computeBtn.Text = "Compute";
            this.computeBtn.UseVisualStyleBackColor = true;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(427, 591);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(116, 20);
            this.textBox3.TabIndex = 18;
            this.textBox3.Text = "Tarif1 ";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(462, 572);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(28, 13);
            this.label9.TabIndex = 19;
            this.label9.Text = "Tarif";
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(617, 591);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(116, 20);
            this.textBox4.TabIndex = 20;
            this.textBox4.Text = "Tarif 2";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(647, 572);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(28, 13);
            this.label10.TabIndex = 21;
            this.label10.Text = "Tarif";
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(526, 712);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(100, 20);
            this.textBox5.TabIndex = 22;
            this.textBox5.Text = "Tarif 1 + Tarif 2";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(553, 693);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(31, 13);
            this.label11.TabIndex = 23;
            this.label11.Text = "Total";
            // 
            // textBox6
            // 
            this.textBox6.Location = new System.Drawing.Point(427, 651);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(116, 20);
            this.textBox6.TabIndex = 24;
            this.textBox6.Text = " Tarif 1 * 3 * 0.0656 * Total 1";
            // 
            // textBox7
            // 
            this.textBox7.Location = new System.Drawing.Point(617, 651);
            this.textBox7.Name = "textBox7";
            this.textBox7.Size = new System.Drawing.Size(116, 20);
            this.textBox7.TabIndex = 25;
            this.textBox7.Text = "Tarif 2 * 0.0656 * Total 2";
            // 
            // textBox8
            // 
            this.textBox8.Location = new System.Drawing.Point(956, 530);
            this.textBox8.Name = "textBox8";
            this.textBox8.Size = new System.Drawing.Size(116, 20);
            this.textBox8.TabIndex = 26;
            this.textBox8.Text = "Casuta 7 excel = Suma";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(987, 514);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(56, 13);
            this.label12.TabIndex = 27;
            this.label12.Text = "Wa [kWh]";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(986, 572);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(28, 13);
            this.label13.TabIndex = 29;
            this.label13.Text = "Tarif";
            // 
            // textBox9
            // 
            this.textBox9.Location = new System.Drawing.Point(956, 591);
            this.textBox9.Name = "textBox9";
            this.textBox9.Size = new System.Drawing.Size(116, 20);
            this.textBox9.TabIndex = 28;
            this.textBox9.Text = "Tarif 3";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(983, 632);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(31, 13);
            this.label14.TabIndex = 31;
            this.label14.Text = "Total";
            // 
            // textBox10
            // 
            this.textBox10.Location = new System.Drawing.Point(956, 651);
            this.textBox10.Name = "textBox10";
            this.textBox10.Size = new System.Drawing.Size(116, 20);
            this.textBox10.TabIndex = 30;
            this.textBox10.Text = "Tarif 3  * Wa";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1361, 754);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.textBox10);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.textBox9);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.textBox8);
            this.Controls.Add(this.textBox7);
            this.Controls.Add(this.textBox6);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.computeBtn);
            this.Controls.Add(this.resetResultsBtn);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.sum2Text);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.sum1Text);
            this.Controls.Add(this.btnLoadExcel);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.progress);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dateEndTimeInterval);
            this.Controls.Add(this.dateTimeStartInterval);
            this.Name = "Form1";
            this.Text = "Excel Calculator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dateTimeStartInterval;
        private System.Windows.Forms.DateTimePicker dateEndTimeInterval;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ProgressBar progress;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnLoadExcel;
        private System.Windows.Forms.OpenFileDialog excelLoader;
        private System.ComponentModel.BackgroundWorker processWorker;
        private System.Windows.Forms.TextBox sum1Text;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox sum2Text;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button resetResultsBtn;
        private System.Windows.Forms.Button computeBtn;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.TextBox textBox7;
        private System.Windows.Forms.TextBox textBox8;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox textBox9;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox textBox10;
    }
}

