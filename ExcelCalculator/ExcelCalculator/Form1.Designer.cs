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
            this.label3.Location = new System.Drawing.Point(654, 93);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 13);
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
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1377, 623);
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
            this.Text = "Form1";
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
    }
}

