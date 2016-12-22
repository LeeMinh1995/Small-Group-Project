namespace Algorithms
{
    partial class FibonacciForm
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.backBtn = new System.Windows.Forms.Button();
            this.algorithmName = new System.Windows.Forms.Label();
            this.timePanel = new System.Windows.Forms.Panel();
            this.timeLabel = new System.Windows.Forms.Label();
            this.startBtn = new System.Windows.Forms.Button();
            this.outputLabel = new System.Windows.Forms.Label();
            this.inputLabel = new System.Windows.Forms.Label();
            this.sumInfo = new System.Windows.Forms.RichTextBox();
            this.timerFader = new System.Windows.Forms.Timer(this.components);
            this.fibonacciOutput = new System.Windows.Forms.RichTextBox();
            this.panel1.SuspendLayout();
            this.timePanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel1.Controls.Add(this.backBtn);
            this.panel1.Controls.Add(this.algorithmName);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(720, 51);
            this.panel1.TabIndex = 1;
            // 
            // backBtn
            // 
            this.backBtn.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.backBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.backBtn.Font = new System.Drawing.Font("Open Sans Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.backBtn.Image = global::Algorithms.Properties.Resources.Back_Arrow;
            this.backBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.backBtn.Location = new System.Drawing.Point(12, 7);
            this.backBtn.Name = "backBtn";
            this.backBtn.Size = new System.Drawing.Size(117, 37);
            this.backBtn.TabIndex = 1;
            this.backBtn.TabStop = false;
            this.backBtn.Text = "Main Menu";
            this.backBtn.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.backBtn.UseVisualStyleBackColor = true;
            this.backBtn.Click += new System.EventHandler(this.backBtn_Click);
            // 
            // algorithmName
            // 
            this.algorithmName.Font = new System.Drawing.Font("Open Sans", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.algorithmName.Location = new System.Drawing.Point(135, 7);
            this.algorithmName.Name = "algorithmName";
            this.algorithmName.Size = new System.Drawing.Size(577, 37);
            this.algorithmName.TabIndex = 2;
            this.algorithmName.Text = "Fibonacci";
            this.algorithmName.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // timePanel
            // 
            this.timePanel.BackColor = System.Drawing.Color.WhiteSmoke;
            this.timePanel.Controls.Add(this.timeLabel);
            this.timePanel.Location = new System.Drawing.Point(0, 360);
            this.timePanel.Name = "timePanel";
            this.timePanel.Size = new System.Drawing.Size(720, 36);
            this.timePanel.TabIndex = 5;
            // 
            // timeLabel
            // 
            this.timeLabel.AutoSize = true;
            this.timeLabel.Font = new System.Drawing.Font("Consolas", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.timeLabel.Location = new System.Drawing.Point(8, 8);
            this.timeLabel.Name = "timeLabel";
            this.timeLabel.Size = new System.Drawing.Size(243, 20);
            this.timeLabel.TabIndex = 3;
            this.timeLabel.Text = "Total time of algorithm : ";
            // 
            // startBtn
            // 
            this.startBtn.FlatAppearance.BorderColor = System.Drawing.Color.DimGray;
            this.startBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.startBtn.Font = new System.Drawing.Font("Open Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.startBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.startBtn.Location = new System.Drawing.Point(16, 146);
            this.startBtn.Name = "startBtn";
            this.startBtn.Size = new System.Drawing.Size(117, 41);
            this.startBtn.TabIndex = 3;
            this.startBtn.Text = "START";
            this.startBtn.UseVisualStyleBackColor = true;
            this.startBtn.Click += new System.EventHandler(this.startBtn_Click);
            // 
            // outputLabel
            // 
            this.outputLabel.AutoSize = true;
            this.outputLabel.Font = new System.Drawing.Font("Consolas", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.outputLabel.Location = new System.Drawing.Point(163, 211);
            this.outputLabel.Name = "outputLabel";
            this.outputLabel.Size = new System.Drawing.Size(153, 20);
            this.outputLabel.TabIndex = 3;
            this.outputLabel.Text = "The number is : ";
            // 
            // inputLabel
            // 
            this.inputLabel.AutoSize = true;
            this.inputLabel.Font = new System.Drawing.Font("Consolas", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inputLabel.Location = new System.Drawing.Point(199, 156);
            this.inputLabel.Name = "inputLabel";
            this.inputLabel.Size = new System.Drawing.Size(117, 20);
            this.inputLabel.TabIndex = 3;
            this.inputLabel.Text = "Input (n) : ";
            // 
            // sumInfo
            // 
            this.sumInfo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(223)))), ((int)(((byte)(226)))));
            this.sumInfo.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.sumInfo.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.sumInfo.Font = new System.Drawing.Font("Consolas", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sumInfo.Location = new System.Drawing.Point(12, 83);
            this.sumInfo.MaxLength = 2000;
            this.sumInfo.Name = "sumInfo";
            this.sumInfo.ReadOnly = true;
            this.sumInfo.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None;
            this.sumInfo.Size = new System.Drawing.Size(695, 26);
            this.sumInfo.TabIndex = 1;
            this.sumInfo.Text = "Design a program to find a N fibonacci number (N > 0)";
            // 
            // timerFader
            // 
            this.timerFader.Interval = 10;
            this.timerFader.Tick += new System.EventHandler(this.timerFader_Tick);
            // 
            // fibonacciOutput
            // 
            this.fibonacciOutput.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(223)))), ((int)(((byte)(226)))));
            this.fibonacciOutput.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.fibonacciOutput.Font = new System.Drawing.Font("Consolas", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fibonacciOutput.Location = new System.Drawing.Point(311, 211);
            this.fibonacciOutput.Name = "fibonacciOutput";
            this.fibonacciOutput.Size = new System.Drawing.Size(396, 121);
            this.fibonacciOutput.TabIndex = 6;
            this.fibonacciOutput.Text = "";
            // 
            // FibonacciForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(223)))), ((int)(((byte)(226)))));
            this.ClientSize = new System.Drawing.Size(719, 397);
            this.Controls.Add(this.fibonacciOutput);
            this.Controls.Add(this.outputLabel);
            this.Controls.Add(this.startBtn);
            this.Controls.Add(this.timePanel);
            this.Controls.Add(this.inputLabel);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.sumInfo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FibonacciForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SumForm";
            this.panel1.ResumeLayout(false);
            this.timePanel.ResumeLayout(false);
            this.timePanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        public System.Windows.Forms.Label algorithmName;
        private System.Windows.Forms.Panel timePanel;
        private System.Windows.Forms.Label timeLabel;
        private System.Windows.Forms.Label outputLabel;
        private System.Windows.Forms.Label inputLabel;
        private System.Windows.Forms.RichTextBox sumInfo;
        private System.Windows.Forms.Button backBtn;
        private System.Windows.Forms.Button startBtn;
        private System.Windows.Forms.Timer timerFader;
        private System.Windows.Forms.RichTextBox fibonacciOutput;
    }
}