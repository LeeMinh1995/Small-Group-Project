namespace Algorithms
{
    partial class PresortElementUniquenessForm
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
            this.scanBtn = new System.Windows.Forms.Button();
            this.timerFader = new System.Windows.Forms.Timer(this.components);
            this.algorithmRequirement = new System.Windows.Forms.Label();
            this.arrayContainer = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.generateBtn = new System.Windows.Forms.Button();
            this.answerResult = new System.Windows.Forms.Label();
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
            this.algorithmName.Text = "Presort Element Uniqueness";
            this.algorithmName.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // timePanel
            // 
            this.timePanel.BackColor = System.Drawing.Color.WhiteSmoke;
            this.timePanel.Controls.Add(this.timeLabel);
            this.timePanel.Location = new System.Drawing.Point(0, 450);
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
            this.separatorControl1.Location = new System.Drawing.Point(13, 353);
            this.separatorControl1.Name = "separatorControl1";
            this.separatorControl1.Size = new System.Drawing.Size(677, 23);
            this.separatorControl1.TabIndex = 10;
            // 
            // answerLabel
            // 
            this.answerLabel.AutoSize = true;
            this.answerLabel.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.answerLabel.Location = new System.Drawing.Point(8, 392);
            this.answerLabel.Name = "answerLabel";
            this.answerLabel.Size = new System.Drawing.Size(189, 19);
            this.answerLabel.TabIndex = 11;
            this.answerLabel.Text = "Is an array unique ?";
            // 
            // scanBtn
            // 
            this.scanBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.scanBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.scanBtn.Location = new System.Drawing.Point(217, 382);
            this.scanBtn.Name = "scanBtn";
            this.scanBtn.Size = new System.Drawing.Size(85, 39);
            this.scanBtn.TabIndex = 13;
            this.scanBtn.Text = "SCAN";
            this.scanBtn.UseVisualStyleBackColor = true;
            this.scanBtn.Click += new System.EventHandler(this.scanBtn_Click);
            // 
            // timerFader
            // 
            this.timerFader.Interval = 10;
            this.timerFader.Tick += new System.EventHandler(this.timerFader_Tick);
            // 
            // algorithmRequirement
            // 
            this.algorithmRequirement.AutoSize = true;
            this.algorithmRequirement.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.algorithmRequirement.Location = new System.Drawing.Point(9, 74);
            this.algorithmRequirement.Name = "algorithmRequirement";
            this.algorithmRequirement.Size = new System.Drawing.Size(585, 19);
            this.algorithmRequirement.TabIndex = 14;
            this.algorithmRequirement.Text = "Design a program to check an array doesn\'t have the same element";
            // 
            // arrayContainer
            // 
            this.arrayContainer.BackColor = System.Drawing.Color.White;
            this.arrayContainer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.arrayContainer.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.arrayContainer.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.arrayContainer.Location = new System.Drawing.Point(12, 158);
            this.arrayContainer.Name = "arrayContainer";
            this.arrayContainer.ReadOnly = true;
            this.arrayContainer.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical;
            this.arrayContainer.Size = new System.Drawing.Size(677, 189);
            this.arrayContainer.TabIndex = 15;
            this.arrayContainer.Text = "";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(333, 392);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(153, 19);
            this.label1.TabIndex = 11;
            this.label1.Text = "The answer is : ";
            // 
            // generateBtn
            // 
            this.generateBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.generateBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.generateBtn.Location = new System.Drawing.Point(12, 115);
            this.generateBtn.Name = "generateBtn";
            this.generateBtn.Size = new System.Drawing.Size(116, 37);
            this.generateBtn.TabIndex = 13;
            this.generateBtn.Text = "GENERATE";
            this.generateBtn.UseVisualStyleBackColor = true;
            this.generateBtn.Click += new System.EventHandler(this.generateArray_Click);
            // 
            // answerResult
            // 
            this.answerResult.AutoSize = true;
            this.answerResult.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.answerResult.Location = new System.Drawing.Point(479, 390);
            this.answerResult.Name = "answerResult";
            this.answerResult.Size = new System.Drawing.Size(0, 22);
            this.answerResult.TabIndex = 11;
            // 
            // PresortElementUniquenessForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(223)))), ((int)(((byte)(226)))));
            this.ClientSize = new System.Drawing.Size(701, 486);
            this.Controls.Add(this.arrayContainer);
            this.Controls.Add(this.algorithmRequirement);
            this.Controls.Add(this.generateBtn);
            this.Controls.Add(this.scanBtn);
            this.Controls.Add(this.answerResult);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.answerLabel);
            this.Controls.Add(this.separatorControl1);
            this.Controls.Add(this.timePanel);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "PresortElementUniquenessForm";
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
        private System.Windows.Forms.Button scanBtn;
        private System.Windows.Forms.Timer timerFader;
        private System.Windows.Forms.Label algorithmRequirement;
        private System.Windows.Forms.RichTextBox arrayContainer;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button generateBtn;
        private System.Windows.Forms.Label answerResult;
    }
}