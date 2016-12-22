namespace Algorithms
{
    partial class CountingSundayForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CountingSundayForm));
            this.panel1 = new System.Windows.Forms.Panel();
            this.algorithmName = new System.Windows.Forms.Label();
            this.timePanel = new System.Windows.Forms.Panel();
            this.timeLabel = new System.Windows.Forms.Label();
            this.sumPanel = new System.Windows.Forms.Panel();
            this.startBtn = new System.Windows.Forms.Button();
            this.answerResult = new System.Windows.Forms.Label();
            this.problemInfo = new System.Windows.Forms.RichTextBox();
            this.timerFader = new System.Windows.Forms.Timer(this.components);
            this.backBtn = new System.Windows.Forms.Button();
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
            this.panel1.Size = new System.Drawing.Size(857, 51);
            this.panel1.TabIndex = 2;
            // 
            // algorithmName
            // 
            this.algorithmName.Font = new System.Drawing.Font("Open Sans", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.algorithmName.Location = new System.Drawing.Point(291, 7);
            this.algorithmName.Name = "algorithmName";
            this.algorithmName.Size = new System.Drawing.Size(554, 37);
            this.algorithmName.TabIndex = 2;
            this.algorithmName.Text = "Counting Sunday";
            this.algorithmName.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // timePanel
            // 
            this.timePanel.BackColor = System.Drawing.Color.WhiteSmoke;
            this.timePanel.Controls.Add(this.timeLabel);
            this.timePanel.Location = new System.Drawing.Point(0, 434);
            this.timePanel.Name = "timePanel";
            this.timePanel.Size = new System.Drawing.Size(857, 36);
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
            this.sumPanel.Controls.Add(this.startBtn);
            this.sumPanel.Controls.Add(this.answerResult);
            this.sumPanel.Controls.Add(this.problemInfo);
            this.sumPanel.Location = new System.Drawing.Point(12, 68);
            this.sumPanel.Name = "sumPanel";
            this.sumPanel.Size = new System.Drawing.Size(833, 349);
            this.sumPanel.TabIndex = 7;
            // 
            // startBtn
            // 
            this.startBtn.FlatAppearance.BorderColor = System.Drawing.Color.DimGray;
            this.startBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.startBtn.Font = new System.Drawing.Font("Open Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.startBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.startBtn.Location = new System.Drawing.Point(32, 267);
            this.startBtn.Name = "startBtn";
            this.startBtn.Size = new System.Drawing.Size(96, 34);
            this.startBtn.TabIndex = 3;
            this.startBtn.Text = "START";
            this.startBtn.UseVisualStyleBackColor = true;
            this.startBtn.Click += new System.EventHandler(this.startBtn_Click);
            // 
            // answerResult
            // 
            this.answerResult.AutoSize = true;
            this.answerResult.Font = new System.Drawing.Font("Consolas", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.answerResult.Location = new System.Drawing.Point(167, 274);
            this.answerResult.Name = "answerResult";
            this.answerResult.Size = new System.Drawing.Size(225, 20);
            this.answerResult.TabIndex = 3;
            this.answerResult.Text = "The number of Sundays : ";
            // 
            // problemInfo
            // 
            this.problemInfo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(223)))), ((int)(((byte)(226)))));
            this.problemInfo.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.problemInfo.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.problemInfo.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.problemInfo.Location = new System.Drawing.Point(0, 0);
            this.problemInfo.MaxLength = 2000;
            this.problemInfo.Name = "problemInfo";
            this.problemInfo.ReadOnly = true;
            this.problemInfo.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None;
            this.problemInfo.Size = new System.Drawing.Size(833, 219);
            this.problemInfo.TabIndex = 1;
            this.problemInfo.Text = resources.GetString("problemInfo.Text");
            // 
            // timerFader
            // 
            this.timerFader.Interval = 10;
            this.timerFader.Tick += new System.EventHandler(this.timerFader_Tick);
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
            // CountingSundayForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(223)))), ((int)(((byte)(226)))));
            this.ClientSize = new System.Drawing.Size(857, 470);
            this.Controls.Add(this.sumPanel);
            this.Controls.Add(this.timePanel);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "CountingSundayForm";
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
        private System.Windows.Forms.Button startBtn;
        private System.Windows.Forms.Label answerResult;
        private System.Windows.Forms.RichTextBox problemInfo;
        private System.Windows.Forms.Timer timerFader;
    }
}