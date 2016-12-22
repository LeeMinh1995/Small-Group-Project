namespace Algorithms
{
    partial class BruteForceClosestPairForm
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
            this.separatorControl1 = new DevExpress.XtraEditors.SeparatorControl();
            this.answerLabel = new System.Windows.Forms.Label();
            this.answerResult = new System.Windows.Forms.Label();
            this.findBtn = new System.Windows.Forms.Button();
            this.timerFader = new System.Windows.Forms.Timer(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.generateBtn = new System.Windows.Forms.Button();
            this.pointContainer = new System.Windows.Forms.Panel();
            this.totalPointLabel = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.timePanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.separatorControl1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel1.Controls.Add(this.backBtn);
            this.panel1.Controls.Add(this.algorithmName);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(701, 51);
            this.panel1.TabIndex = 3;
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
            this.algorithmName.Size = new System.Drawing.Size(560, 37);
            this.algorithmName.TabIndex = 2;
            this.algorithmName.Text = "Brute Froce Closest Pair";
            this.algorithmName.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // timePanel
            // 
            this.timePanel.BackColor = System.Drawing.Color.WhiteSmoke;
            this.timePanel.Controls.Add(this.timeLabel);
            this.timePanel.Location = new System.Drawing.Point(0, 469);
            this.timePanel.Name = "timePanel";
            this.timePanel.Size = new System.Drawing.Size(701, 36);
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
            // separatorControl1
            // 
            this.separatorControl1.Location = new System.Drawing.Point(12, 384);
            this.separatorControl1.Name = "separatorControl1";
            this.separatorControl1.Size = new System.Drawing.Size(677, 22);
            this.separatorControl1.TabIndex = 10;
            // 
            // answerLabel
            // 
            this.answerLabel.AutoSize = true;
            this.answerLabel.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.answerLabel.Location = new System.Drawing.Point(115, 422);
            this.answerLabel.Name = "answerLabel";
            this.answerLabel.Size = new System.Drawing.Size(207, 19);
            this.answerLabel.TabIndex = 11;
            this.answerLabel.Text = "The closest pair is : ";
            // 
            // answerResult
            // 
            this.answerResult.AutoSize = true;
            this.answerResult.Font = new System.Drawing.Font("Consolas", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.answerResult.Location = new System.Drawing.Point(351, 396);
            this.answerResult.Name = "answerResult";
            this.answerResult.Size = new System.Drawing.Size(0, 24);
            this.answerResult.TabIndex = 11;
            this.answerResult.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // findBtn
            // 
            this.findBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.findBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.findBtn.Location = new System.Drawing.Point(12, 412);
            this.findBtn.Name = "findBtn";
            this.findBtn.Size = new System.Drawing.Size(75, 38);
            this.findBtn.TabIndex = 13;
            this.findBtn.Text = "FIND";
            this.findBtn.UseVisualStyleBackColor = true;
            this.findBtn.Click += new System.EventHandler(this.findBtn_Click);
            // 
            // timerFader
            // 
            this.timerFader.Interval = 10;
            this.timerFader.Tick += new System.EventHandler(this.timerFader_Tick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(8, 67);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(558, 19);
            this.label1.TabIndex = 14;
            this.label1.Text = "Design a program to find the closest pair in a list of points";
            // 
            // generateBtn
            // 
            this.generateBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.generateBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.generateBtn.Location = new System.Drawing.Point(12, 101);
            this.generateBtn.Name = "generateBtn";
            this.generateBtn.Size = new System.Drawing.Size(117, 37);
            this.generateBtn.TabIndex = 13;
            this.generateBtn.Text = "GENERATE";
            this.generateBtn.UseVisualStyleBackColor = true;
            this.generateBtn.MouseClick += new System.Windows.Forms.MouseEventHandler(this.generateBtn_MouseClick);
            // 
            // pointContainer
            // 
            this.pointContainer.Location = new System.Drawing.Point(12, 148);
            this.pointContainer.Name = "pointContainer";
            this.pointContainer.Size = new System.Drawing.Size(677, 230);
            this.pointContainer.TabIndex = 15;
            this.pointContainer.Visible = false;
            this.pointContainer.Paint += new System.Windows.Forms.PaintEventHandler(this.pointContainer_Paint);
            // 
            // totalPointLabel
            // 
            this.totalPointLabel.AutoSize = true;
            this.totalPointLabel.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalPointLabel.Location = new System.Drawing.Point(159, 110);
            this.totalPointLabel.Name = "totalPointLabel";
            this.totalPointLabel.Size = new System.Drawing.Size(0, 19);
            this.totalPointLabel.TabIndex = 11;
            // 
            // BruteForceClosestPairForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(223)))), ((int)(((byte)(226)))));
            this.ClientSize = new System.Drawing.Size(701, 504);
            this.Controls.Add(this.pointContainer);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.generateBtn);
            this.Controls.Add(this.findBtn);
            this.Controls.Add(this.answerResult);
            this.Controls.Add(this.totalPointLabel);
            this.Controls.Add(this.answerLabel);
            this.Controls.Add(this.separatorControl1);
            this.Controls.Add(this.timePanel);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "BruteForceClosestPairForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.panel1.ResumeLayout(false);
            this.timePanel.ResumeLayout(false);
            this.timePanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.separatorControl1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button backBtn;
        public System.Windows.Forms.Label algorithmName;
        private System.Windows.Forms.Panel timePanel;
        private System.Windows.Forms.Label timeLabel;
        private DevExpress.XtraEditors.SeparatorControl separatorControl1;
        private System.Windows.Forms.Label answerLabel;
        private System.Windows.Forms.Label answerResult;
        private System.Windows.Forms.Button findBtn;
        private System.Windows.Forms.Timer timerFader;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button generateBtn;
        private System.Windows.Forms.Panel pointContainer;
        private System.Windows.Forms.Label totalPointLabel;
    }
}