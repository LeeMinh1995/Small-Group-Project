namespace Algorithms
{
    partial class LargestProductInASeriesForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LargestProductInASeriesForm));
            this.headPanel = new System.Windows.Forms.Panel();
            this.algorithmName = new System.Windows.Forms.Label();
            this.timePanel = new System.Windows.Forms.Panel();
            this.timeLabel = new System.Windows.Forms.Label();
            this.richTextBox2 = new System.Windows.Forms.RichTextBox();
            this.series = new System.Windows.Forms.RichTextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.findBtn = new System.Windows.Forms.Button();
            this.answer = new System.Windows.Forms.Label();
            this.backBtn = new System.Windows.Forms.Button();
            this.timerFader = new System.Windows.Forms.Timer(this.components);
            this.headPanel.SuspendLayout();
            this.timePanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // headPanel
            // 
            this.headPanel.BackColor = System.Drawing.Color.WhiteSmoke;
            this.headPanel.Controls.Add(this.backBtn);
            this.headPanel.Controls.Add(this.algorithmName);
            this.headPanel.Location = new System.Drawing.Point(0, 0);
            this.headPanel.Name = "headPanel";
            this.headPanel.Size = new System.Drawing.Size(728, 51);
            this.headPanel.TabIndex = 3;
            // 
            // algorithmName
            // 
            this.algorithmName.Font = new System.Drawing.Font("Open Sans", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.algorithmName.Location = new System.Drawing.Point(135, 7);
            this.algorithmName.Name = "algorithmName";
            this.algorithmName.Size = new System.Drawing.Size(581, 37);
            this.algorithmName.TabIndex = 2;
            this.algorithmName.Text = "Largest Product In A Series";
            this.algorithmName.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // timePanel
            // 
            this.timePanel.BackColor = System.Drawing.Color.WhiteSmoke;
            this.timePanel.Controls.Add(this.timeLabel);
            this.timePanel.Location = new System.Drawing.Point(0, 631);
            this.timePanel.Name = "timePanel";
            this.timePanel.Size = new System.Drawing.Size(728, 36);
            this.timePanel.TabIndex = 7;
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
            // richTextBox2
            // 
            this.richTextBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(223)))), ((int)(((byte)(226)))));
            this.richTextBox2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.richTextBox2.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.richTextBox2.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richTextBox2.Location = new System.Drawing.Point(12, 70);
            this.richTextBox2.MaxLength = 100000;
            this.richTextBox2.Name = "richTextBox2";
            this.richTextBox2.ReadOnly = true;
            this.richTextBox2.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None;
            this.richTextBox2.Size = new System.Drawing.Size(704, 30);
            this.richTextBox2.TabIndex = 1;
            this.richTextBox2.Text = "Find the thirteen adjacent digits in the number below having the largest value";
            // 
            // series
            // 
            this.series.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(223)))), ((int)(((byte)(226)))));
            this.series.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.series.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.series.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.series.Location = new System.Drawing.Point(131, 108);
            this.series.MaxLength = 100000;
            this.series.Name = "series";
            this.series.ReadOnly = true;
            this.series.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None;
            this.series.Size = new System.Drawing.Size(456, 384);
            this.series.TabIndex = 1;
            this.series.Text = resources.GetString("series.Text");
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Black;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(0, 518);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(727, 1);
            this.button1.TabIndex = 8;
            this.button1.UseVisualStyleBackColor = false;
            // 
            // findBtn
            // 
            this.findBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.findBtn.Font = new System.Drawing.Font("Open Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.findBtn.Location = new System.Drawing.Point(131, 555);
            this.findBtn.Name = "findBtn";
            this.findBtn.Size = new System.Drawing.Size(80, 35);
            this.findBtn.TabIndex = 9;
            this.findBtn.Text = "FIND";
            this.findBtn.UseVisualStyleBackColor = true;
            this.findBtn.Click += new System.EventHandler(this.findBtn_Click);
            // 
            // answer
            // 
            this.answer.AutoSize = true;
            this.answer.Font = new System.Drawing.Font("Consolas", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.answer.Location = new System.Drawing.Point(241, 562);
            this.answer.Name = "answer";
            this.answer.Size = new System.Drawing.Size(144, 20);
            this.answer.TabIndex = 10;
            this.answer.Text = "The value is : ";
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
            // timerFader
            // 
            this.timerFader.Interval = 10;
            this.timerFader.Tick += new System.EventHandler(this.timerFader_Tick);
            // 
            // LargestProductInASeriesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(223)))), ((int)(((byte)(226)))));
            this.ClientSize = new System.Drawing.Size(728, 666);
            this.Controls.Add(this.answer);
            this.Controls.Add(this.findBtn);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.series);
            this.Controls.Add(this.richTextBox2);
            this.Controls.Add(this.timePanel);
            this.Controls.Add(this.headPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "LargestProductInASeriesForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "HornerForm";
            this.headPanel.ResumeLayout(false);
            this.timePanel.ResumeLayout(false);
            this.timePanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel headPanel;
        private System.Windows.Forms.Button backBtn;
        public System.Windows.Forms.Label algorithmName;
        private System.Windows.Forms.Panel timePanel;
        private System.Windows.Forms.Label timeLabel;
        private System.Windows.Forms.RichTextBox richTextBox2;
        private System.Windows.Forms.RichTextBox series;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button findBtn;
        private System.Windows.Forms.Label answer;
        private System.Windows.Forms.Timer timerFader;
    }
}