namespace Algorithms
{
    partial class SelectionSortForm
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
            this.headPanel = new System.Windows.Forms.Panel();
            this.backBtn = new System.Windows.Forms.Button();
            this.algorithmName = new System.Windows.Forms.Label();
            this.timePanel = new System.Windows.Forms.Panel();
            this.timeLabel = new System.Windows.Forms.Label();
            this.selectionSortPanel = new System.Windows.Forms.Panel();
            this.underline = new System.Windows.Forms.Button();
            this.arrayResult = new System.Windows.Forms.RichTextBox();
            this.arrayContainer = new System.Windows.Forms.RichTextBox();
            this.generateArray = new System.Windows.Forms.Button();
            this.sortArrayBtn = new System.Windows.Forms.Button();
            this.arraySubsortShow = new System.Windows.Forms.Label();
            this.richTextBox2 = new System.Windows.Forms.RichTextBox();
            this.timerFader = new System.Windows.Forms.Timer(this.components);
            this.headPanel.SuspendLayout();
            this.timePanel.SuspendLayout();
            this.selectionSortPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // headPanel
            // 
            this.headPanel.BackColor = System.Drawing.Color.WhiteSmoke;
            this.headPanel.Controls.Add(this.backBtn);
            this.headPanel.Controls.Add(this.algorithmName);
            this.headPanel.Location = new System.Drawing.Point(0, 0);
            this.headPanel.Name = "headPanel";
            this.headPanel.Size = new System.Drawing.Size(748, 51);
            this.headPanel.TabIndex = 2;
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
            this.algorithmName.Size = new System.Drawing.Size(606, 37);
            this.algorithmName.TabIndex = 2;
            this.algorithmName.Text = "Selection Sort";
            this.algorithmName.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // timePanel
            // 
            this.timePanel.BackColor = System.Drawing.Color.WhiteSmoke;
            this.timePanel.Controls.Add(this.timeLabel);
            this.timePanel.Location = new System.Drawing.Point(0, 427);
            this.timePanel.Name = "timePanel";
            this.timePanel.Size = new System.Drawing.Size(748, 36);
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
            // selectionSortPanel
            // 
            this.selectionSortPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(223)))), ((int)(((byte)(226)))));
            this.selectionSortPanel.Controls.Add(this.underline);
            this.selectionSortPanel.Controls.Add(this.arrayResult);
            this.selectionSortPanel.Controls.Add(this.arrayContainer);
            this.selectionSortPanel.Controls.Add(this.generateArray);
            this.selectionSortPanel.Controls.Add(this.sortArrayBtn);
            this.selectionSortPanel.Controls.Add(this.arraySubsortShow);
            this.selectionSortPanel.Controls.Add(this.richTextBox2);
            this.selectionSortPanel.Location = new System.Drawing.Point(12, 66);
            this.selectionSortPanel.Name = "selectionSortPanel";
            this.selectionSortPanel.Size = new System.Drawing.Size(724, 346);
            this.selectionSortPanel.TabIndex = 1;
            // 
            // underline
            // 
            this.underline.BackColor = System.Drawing.Color.Black;
            this.underline.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.underline.Location = new System.Drawing.Point(406, 30);
            this.underline.Name = "underline";
            this.underline.Size = new System.Drawing.Size(217, 1);
            this.underline.TabIndex = 8;
            this.underline.UseVisualStyleBackColor = false;
            // 
            // arrayResult
            // 
            this.arrayResult.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.arrayResult.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.arrayResult.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.arrayResult.Location = new System.Drawing.Point(108, 213);
            this.arrayResult.Name = "arrayResult";
            this.arrayResult.ReadOnly = true;
            this.arrayResult.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical;
            this.arrayResult.Size = new System.Drawing.Size(612, 108);
            this.arrayResult.TabIndex = 7;
            this.arrayResult.Text = "";
            // 
            // arrayContainer
            // 
            this.arrayContainer.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.arrayContainer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.arrayContainer.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.arrayContainer.Location = new System.Drawing.Point(108, 66);
            this.arrayContainer.Name = "arrayContainer";
            this.arrayContainer.ReadOnly = true;
            this.arrayContainer.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical;
            this.arrayContainer.Size = new System.Drawing.Size(612, 108);
            this.arrayContainer.TabIndex = 7;
            this.arrayContainer.Text = "";
            // 
            // generateArray
            // 
            this.generateArray.FlatAppearance.BorderColor = System.Drawing.Color.DimGray;
            this.generateArray.FlatAppearance.MouseDownBackColor = System.Drawing.Color.WhiteSmoke;
            this.generateArray.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.generateArray.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.generateArray.Font = new System.Drawing.Font("Open Sans", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.generateArray.ForeColor = System.Drawing.Color.Black;
            this.generateArray.Location = new System.Drawing.Point(3, 66);
            this.generateArray.Name = "generateArray";
            this.generateArray.Size = new System.Drawing.Size(99, 50);
            this.generateArray.TabIndex = 1;
            this.generateArray.TabStop = false;
            this.generateArray.Text = "GENERATE";
            this.generateArray.UseVisualStyleBackColor = true;
            this.generateArray.Click += new System.EventHandler(this.generateArray_Click);
            // 
            // sortArrayBtn
            // 
            this.sortArrayBtn.FlatAppearance.BorderColor = System.Drawing.Color.DimGray;
            this.sortArrayBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.WhiteSmoke;
            this.sortArrayBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.sortArrayBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.sortArrayBtn.Font = new System.Drawing.Font("Open Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sortArrayBtn.ForeColor = System.Drawing.Color.Black;
            this.sortArrayBtn.Location = new System.Drawing.Point(3, 213);
            this.sortArrayBtn.Name = "sortArrayBtn";
            this.sortArrayBtn.Size = new System.Drawing.Size(99, 50);
            this.sortArrayBtn.TabIndex = 1;
            this.sortArrayBtn.TabStop = false;
            this.sortArrayBtn.Text = "Sort array";
            this.sortArrayBtn.UseVisualStyleBackColor = true;
            this.sortArrayBtn.Click += new System.EventHandler(this.sortArrayBtn_Click);
            // 
            // arraySubsortShow
            // 
            this.arraySubsortShow.AutoSize = true;
            this.arraySubsortShow.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.arraySubsortShow.ForeColor = System.Drawing.Color.MediumBlue;
            this.arraySubsortShow.Location = new System.Drawing.Point(-4, 162);
            this.arraySubsortShow.Name = "arraySubsortShow";
            this.arraySubsortShow.Size = new System.Drawing.Size(0, 19);
            this.arraySubsortShow.TabIndex = 3;
            // 
            // richTextBox2
            // 
            this.richTextBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(223)))), ((int)(((byte)(226)))));
            this.richTextBox2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.richTextBox2.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.richTextBox2.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richTextBox2.Location = new System.Drawing.Point(0, 8);
            this.richTextBox2.MaxLength = 100000;
            this.richTextBox2.Name = "richTextBox2";
            this.richTextBox2.ReadOnly = true;
            this.richTextBox2.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None;
            this.richTextBox2.Size = new System.Drawing.Size(715, 27);
            this.richTextBox2.TabIndex = 1;
            this.richTextBox2.Text = "Design a program to sort an array which uses selection sort algorithm";
            // 
            // timerFader
            // 
            this.timerFader.Interval = 10;
            this.timerFader.Tick += new System.EventHandler(this.timerFader_Tick);
            // 
            // SelectionSortForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(223)))), ((int)(((byte)(226)))));
            this.ClientSize = new System.Drawing.Size(748, 463);
            this.Controls.Add(this.selectionSortPanel);
            this.Controls.Add(this.timePanel);
            this.Controls.Add(this.headPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "SelectionSortForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.headPanel.ResumeLayout(false);
            this.timePanel.ResumeLayout(false);
            this.timePanel.PerformLayout();
            this.selectionSortPanel.ResumeLayout(false);
            this.selectionSortPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel headPanel;
        private System.Windows.Forms.Button backBtn;
        public System.Windows.Forms.Label algorithmName;
        private System.Windows.Forms.Panel timePanel;
        private System.Windows.Forms.Label timeLabel;
        public System.Windows.Forms.Panel selectionSortPanel;
        private System.Windows.Forms.Button sortArrayBtn;
        private System.Windows.Forms.Label arraySubsortShow;
        private System.Windows.Forms.RichTextBox richTextBox2;
        private System.Windows.Forms.Timer timerFader;
        private System.Windows.Forms.RichTextBox arrayContainer;
        private System.Windows.Forms.Button underline;
        private System.Windows.Forms.RichTextBox arrayResult;
        private System.Windows.Forms.Button generateArray;
    }
}