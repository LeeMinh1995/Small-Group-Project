namespace Algorithms
{
    partial class BruteForceStringMatchForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BruteForceStringMatchForm));
            this.panel1 = new System.Windows.Forms.Panel();
            this.backBtn = new System.Windows.Forms.Button();
            this.algorithmName = new System.Windows.Forms.Label();
            this.timePanel = new System.Windows.Forms.Panel();
            this.timeLabel = new System.Windows.Forms.Label();
            this.separatorControl1 = new DevExpress.XtraEditors.SeparatorControl();
            this.patternLabel = new System.Windows.Forms.Label();
            this.shapeContainer1 = new Microsoft.VisualBasic.PowerPacks.ShapeContainer();
            this.rectangleShape1 = new Microsoft.VisualBasic.PowerPacks.RectangleShape();
            this.answerLabel = new System.Windows.Forms.Label();
            this.answerResult = new System.Windows.Forms.Label();
            this.findBtn = new System.Windows.Forms.Button();
            this.timerFader = new System.Windows.Forms.Timer(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.textContainer = new System.Windows.Forms.RichTextBox();
            this.patternTxt = new System.Windows.Forms.TextBox();
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
            this.algorithmName.Text = "Brute Froce String Match";
            this.algorithmName.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // timePanel
            // 
            this.timePanel.BackColor = System.Drawing.Color.WhiteSmoke;
            this.timePanel.Controls.Add(this.timeLabel);
            this.timePanel.Location = new System.Drawing.Point(0, 451);
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
            this.separatorControl1.Location = new System.Drawing.Point(12, 300);
            this.separatorControl1.Name = "separatorControl1";
            this.separatorControl1.Size = new System.Drawing.Size(677, 28);
            this.separatorControl1.TabIndex = 10;
            // 
            // patternLabel
            // 
            this.patternLabel.AutoSize = true;
            this.patternLabel.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.patternLabel.Location = new System.Drawing.Point(12, 349);
            this.patternLabel.Name = "patternLabel";
            this.patternLabel.Size = new System.Drawing.Size(144, 18);
            this.patternLabel.TabIndex = 11;
            this.patternLabel.Text = "Patter (string) :";
            // 
            // shapeContainer1
            // 
            this.shapeContainer1.Location = new System.Drawing.Point(0, 0);
            this.shapeContainer1.Margin = new System.Windows.Forms.Padding(0);
            this.shapeContainer1.Name = "shapeContainer1";
            this.shapeContainer1.Shapes.AddRange(new Microsoft.VisualBasic.PowerPacks.Shape[] {
            this.rectangleShape1});
            this.shapeContainer1.Size = new System.Drawing.Size(701, 488);
            this.shapeContainer1.TabIndex = 12;
            this.shapeContainer1.TabStop = false;
            // 
            // rectangleShape1
            // 
            this.rectangleShape1.BorderColor = System.Drawing.Color.DimGray;
            this.rectangleShape1.CornerRadius = 15;
            this.rectangleShape1.FillGradientColor = System.Drawing.Color.Transparent;
            this.rectangleShape1.Location = new System.Drawing.Point(163, 340);
            this.rectangleShape1.Name = "rectangleShape1";
            this.rectangleShape1.SelectionColor = System.Drawing.Color.Transparent;
            this.rectangleShape1.Size = new System.Drawing.Size(265, 37);
            // 
            // answerLabel
            // 
            this.answerLabel.AutoSize = true;
            this.answerLabel.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.answerLabel.Location = new System.Drawing.Point(12, 400);
            this.answerLabel.Name = "answerLabel";
            this.answerLabel.Size = new System.Drawing.Size(333, 19);
            this.answerLabel.TabIndex = 11;
            this.answerLabel.Text = "Does the text contains the pattern ?";
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
            this.findBtn.Location = new System.Drawing.Point(451, 340);
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
            this.label1.Location = new System.Drawing.Point(9, 80);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(585, 19);
            this.label1.TabIndex = 14;
            this.label1.Text = "Design a program to file a pattern or a string in the text below";
            // 
            // textContainer
            // 
            this.textContainer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(223)))), ((int)(((byte)(226)))));
            this.textContainer.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textContainer.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.textContainer.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textContainer.Location = new System.Drawing.Point(12, 122);
            this.textContainer.Name = "textContainer";
            this.textContainer.ReadOnly = true;
            this.textContainer.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None;
            this.textContainer.Size = new System.Drawing.Size(677, 172);
            this.textContainer.TabIndex = 15;
            this.textContainer.Text = resources.GetString("textContainer.Text");
            // 
            // patternTxt
            // 
            this.patternTxt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(223)))), ((int)(((byte)(226)))));
            this.patternTxt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.patternTxt.Font = new System.Drawing.Font("Open Sans", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.patternTxt.Location = new System.Drawing.Point(171, 346);
            this.patternTxt.Name = "patternTxt";
            this.patternTxt.Size = new System.Drawing.Size(250, 26);
            this.patternTxt.TabIndex = 16;
            this.patternTxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // BruteForceStringMatchForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(223)))), ((int)(((byte)(226)))));
            this.ClientSize = new System.Drawing.Size(701, 488);
            this.Controls.Add(this.patternTxt);
            this.Controls.Add(this.textContainer);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.findBtn);
            this.Controls.Add(this.answerResult);
            this.Controls.Add(this.answerLabel);
            this.Controls.Add(this.patternLabel);
            this.Controls.Add(this.separatorControl1);
            this.Controls.Add(this.timePanel);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.shapeContainer1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "BruteForceStringMatchForm";
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
        private System.Windows.Forms.Label patternLabel;
        private Microsoft.VisualBasic.PowerPacks.ShapeContainer shapeContainer1;
        private Microsoft.VisualBasic.PowerPacks.RectangleShape rectangleShape1;
        private System.Windows.Forms.Label answerLabel;
        private System.Windows.Forms.Label answerResult;
        private System.Windows.Forms.Button findBtn;
        private System.Windows.Forms.Timer timerFader;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RichTextBox textContainer;
        private System.Windows.Forms.TextBox patternTxt;
    }
}