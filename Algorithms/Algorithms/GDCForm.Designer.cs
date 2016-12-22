namespace Algorithms
{
    partial class GDCForm
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
            this.sumPanel = new System.Windows.Forms.Panel();
            this.executeBtn = new System.Windows.Forms.Button();
            this.outputLabel = new System.Windows.Forms.Label();
            this.intTwo = new System.Windows.Forms.Label();
            this.intOne = new System.Windows.Forms.Label();
            this.sumInfo = new System.Windows.Forms.RichTextBox();
            this.timerFader = new System.Windows.Forms.Timer(this.components);
            this.panel1.SuspendLayout();
            this.timePanel.SuspendLayout();
            this.sumPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel1.Controls.Add(this.backBtn);
            this.panel1.Controls.Add(this.algorithmName);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(696, 51);
            this.panel1.TabIndex = 2;
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
            this.algorithmName.Size = new System.Drawing.Size(554, 37);
            this.algorithmName.TabIndex = 2;
            this.algorithmName.Text = "Least Common Multiple (LCM)";
            this.algorithmName.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // timePanel
            // 
            this.timePanel.BackColor = System.Drawing.Color.WhiteSmoke;
            this.timePanel.Controls.Add(this.timeLabel);
            this.timePanel.Location = new System.Drawing.Point(0, 383);
            this.timePanel.Name = "timePanel";
            this.timePanel.Size = new System.Drawing.Size(696, 36);
            this.timePanel.TabIndex = 6;
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
            // sumPanel
            // 
            this.sumPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(223)))), ((int)(((byte)(226)))));
            this.sumPanel.Controls.Add(this.executeBtn);
            this.sumPanel.Controls.Add(this.outputLabel);
            this.sumPanel.Controls.Add(this.intTwo);
            this.sumPanel.Controls.Add(this.intOne);
            this.sumPanel.Controls.Add(this.sumInfo);
            this.sumPanel.Location = new System.Drawing.Point(12, 82);
            this.sumPanel.Name = "sumPanel";
            this.sumPanel.Size = new System.Drawing.Size(672, 274);
            this.sumPanel.TabIndex = 7;
            // 
            // executeBtn
            // 
            this.executeBtn.FlatAppearance.BorderColor = System.Drawing.Color.DimGray;
            this.executeBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.executeBtn.Font = new System.Drawing.Font("Open Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.executeBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.executeBtn.Location = new System.Drawing.Point(0, 46);
            this.executeBtn.Name = "executeBtn";
            this.executeBtn.Size = new System.Drawing.Size(96, 34);
            this.executeBtn.TabIndex = 3;
            this.executeBtn.Text = "EXECUTE";
            this.executeBtn.UseVisualStyleBackColor = true;
            this.executeBtn.Click += new System.EventHandler(this.executeBtn_Click);
            // 
            // outputLabel
            // 
            this.outputLabel.AutoSize = true;
            this.outputLabel.Font = new System.Drawing.Font("Consolas", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.outputLabel.Location = new System.Drawing.Point(113, 146);
            this.outputLabel.Name = "outputLabel";
            this.outputLabel.Size = new System.Drawing.Size(153, 20);
            this.outputLabel.TabIndex = 3;
            this.outputLabel.Text = "=> GCD(a , b) = ";
            // 
            // intTwo
            // 
            this.intTwo.AutoSize = true;
            this.intTwo.Font = new System.Drawing.Font("Consolas", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.intTwo.Location = new System.Drawing.Point(158, 100);
            this.intTwo.Name = "intTwo";
            this.intTwo.Size = new System.Drawing.Size(108, 20);
            this.intTwo.TabIndex = 3;
            this.intTwo.Text = "Number b = ";
            // 
            // intOne
            // 
            this.intOne.AutoSize = true;
            this.intOne.Font = new System.Drawing.Font("Consolas", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.intOne.Location = new System.Drawing.Point(158, 53);
            this.intOne.Name = "intOne";
            this.intOne.Size = new System.Drawing.Size(108, 20);
            this.intOne.TabIndex = 3;
            this.intOne.Text = "Number a = ";
            // 
            // sumInfo
            // 
            this.sumInfo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(223)))), ((int)(((byte)(226)))));
            this.sumInfo.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.sumInfo.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.sumInfo.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sumInfo.Location = new System.Drawing.Point(0, 0);
            this.sumInfo.MaxLength = 2000;
            this.sumInfo.Name = "sumInfo";
            this.sumInfo.ReadOnly = true;
            this.sumInfo.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None;
            this.sumInfo.Size = new System.Drawing.Size(695, 36);
            this.sumInfo.TabIndex = 1;
            this.sumInfo.Text = "Design a program to find a least common multiple of two integer numbers";
            // 
            // timerFader
            // 
            this.timerFader.Interval = 10;
            this.timerFader.Tick += new System.EventHandler(this.timerFader_Tick);
            // 
            // GDCForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(223)))), ((int)(((byte)(226)))));
            this.ClientSize = new System.Drawing.Size(696, 419);
            this.Controls.Add(this.sumPanel);
            this.Controls.Add(this.timePanel);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "GDCForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "GDCForm";
            this.panel1.ResumeLayout(false);
            this.timePanel.ResumeLayout(false);
            this.timePanel.PerformLayout();
            this.sumPanel.ResumeLayout(false);
            this.sumPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button backBtn;
        public System.Windows.Forms.Label algorithmName;
        private System.Windows.Forms.Panel timePanel;
        private System.Windows.Forms.Label timeLabel;
        public System.Windows.Forms.Panel sumPanel;
        private System.Windows.Forms.Button executeBtn;
        private System.Windows.Forms.Label outputLabel;
        private System.Windows.Forms.Label intOne;
        private System.Windows.Forms.RichTextBox sumInfo;
        private System.Windows.Forms.Label intTwo;
        private System.Windows.Forms.Timer timerFader;
    }
}