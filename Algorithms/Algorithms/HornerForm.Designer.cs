namespace Algorithms
{
    partial class HornerForm
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
            this.generateArray = new System.Windows.Forms.Button();
            this.richTextBox2 = new System.Windows.Forms.RichTextBox();
            this.hornerFormula = new System.Windows.Forms.Label();
            this.calBtn = new System.Windows.Forms.Button();
            this.hornerResult = new System.Windows.Forms.Label();
            this.xValue = new System.Windows.Forms.Label();
            this.shapeContainer1 = new Microsoft.VisualBasic.PowerPacks.ShapeContainer();
            this.rectangleShape1 = new Microsoft.VisualBasic.PowerPacks.RectangleShape();
            this.xValueInput = new System.Windows.Forms.TextBox();
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
            this.headPanel.Size = new System.Drawing.Size(779, 51);
            this.headPanel.TabIndex = 3;
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
            this.algorithmName.Size = new System.Drawing.Size(632, 37);
            this.algorithmName.TabIndex = 2;
            this.algorithmName.Text = "Horner";
            this.algorithmName.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // timePanel
            // 
            this.timePanel.BackColor = System.Drawing.Color.WhiteSmoke;
            this.timePanel.Controls.Add(this.timeLabel);
            this.timePanel.Location = new System.Drawing.Point(0, 354);
            this.timePanel.Name = "timePanel";
            this.timePanel.Size = new System.Drawing.Size(779, 36);
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
            // generateArray
            // 
            this.generateArray.FlatAppearance.BorderColor = System.Drawing.Color.DimGray;
            this.generateArray.FlatAppearance.MouseDownBackColor = System.Drawing.Color.WhiteSmoke;
            this.generateArray.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.generateArray.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.generateArray.Font = new System.Drawing.Font("Open Sans", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.generateArray.ForeColor = System.Drawing.Color.Black;
            this.generateArray.Location = new System.Drawing.Point(12, 141);
            this.generateArray.Name = "generateArray";
            this.generateArray.Size = new System.Drawing.Size(99, 31);
            this.generateArray.TabIndex = 1;
            this.generateArray.TabStop = false;
            this.generateArray.Text = "GENERATE";
            this.generateArray.UseVisualStyleBackColor = true;
            this.generateArray.Click += new System.EventHandler(this.generateArray_Click);
            // 
            // richTextBox2
            // 
            this.richTextBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(223)))), ((int)(((byte)(226)))));
            this.richTextBox2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.richTextBox2.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.richTextBox2.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richTextBox2.Location = new System.Drawing.Point(12, 79);
            this.richTextBox2.MaxLength = 100000;
            this.richTextBox2.Name = "richTextBox2";
            this.richTextBox2.ReadOnly = true;
            this.richTextBox2.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None;
            this.richTextBox2.Size = new System.Drawing.Size(669, 27);
            this.richTextBox2.TabIndex = 1;
            this.richTextBox2.Text = "Design a program to find a result of this formula :";
            // 
            // hornerFormula
            // 
            this.hornerFormula.AutoSize = true;
            this.hornerFormula.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hornerFormula.Location = new System.Drawing.Point(127, 147);
            this.hornerFormula.Name = "hornerFormula";
            this.hornerFormula.Size = new System.Drawing.Size(0, 19);
            this.hornerFormula.TabIndex = 8;
            // 
            // calBtn
            // 
            this.calBtn.FlatAppearance.BorderColor = System.Drawing.Color.DimGray;
            this.calBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.WhiteSmoke;
            this.calBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.calBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.calBtn.Font = new System.Drawing.Font("Open Sans", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.calBtn.ForeColor = System.Drawing.Color.Black;
            this.calBtn.Location = new System.Drawing.Point(12, 254);
            this.calBtn.Name = "calBtn";
            this.calBtn.Size = new System.Drawing.Size(99, 31);
            this.calBtn.TabIndex = 1;
            this.calBtn.TabStop = false;
            this.calBtn.Text = "CALCULATE";
            this.calBtn.UseVisualStyleBackColor = true;
            this.calBtn.Click += new System.EventHandler(this.calBtn_Click);
            // 
            // hornerResult
            // 
            this.hornerResult.AutoSize = true;
            this.hornerResult.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hornerResult.Location = new System.Drawing.Point(127, 260);
            this.hornerResult.Name = "hornerResult";
            this.hornerResult.Size = new System.Drawing.Size(0, 19);
            this.hornerResult.TabIndex = 9;
            // 
            // xValue
            // 
            this.xValue.AutoSize = true;
            this.xValue.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.xValue.Location = new System.Drawing.Point(127, 205);
            this.xValue.Name = "xValue";
            this.xValue.Size = new System.Drawing.Size(90, 19);
            this.xValue.TabIndex = 10;
            this.xValue.Text = "Give X = ";
            // 
            // shapeContainer1
            // 
            this.shapeContainer1.Location = new System.Drawing.Point(0, 0);
            this.shapeContainer1.Margin = new System.Windows.Forms.Padding(0);
            this.shapeContainer1.Name = "shapeContainer1";
            this.shapeContainer1.Shapes.AddRange(new Microsoft.VisualBasic.PowerPacks.Shape[] {
            this.rectangleShape1});
            this.shapeContainer1.Size = new System.Drawing.Size(779, 390);
            this.shapeContainer1.TabIndex = 11;
            this.shapeContainer1.TabStop = false;
            // 
            // rectangleShape1
            // 
            this.rectangleShape1.CornerRadius = 10;
            this.rectangleShape1.Location = new System.Drawing.Point(223, 200);
            this.rectangleShape1.Name = "rectangleShape1";
            this.rectangleShape1.SelectionColor = System.Drawing.Color.Transparent;
            this.rectangleShape1.Size = new System.Drawing.Size(122, 28);
            // 
            // xValueInput
            // 
            this.xValueInput.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(223)))), ((int)(((byte)(226)))));
            this.xValueInput.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.xValueInput.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.xValueInput.Location = new System.Drawing.Point(231, 203);
            this.xValueInput.Name = "xValueInput";
            this.xValueInput.Size = new System.Drawing.Size(107, 23);
            this.xValueInput.TabIndex = 12;
            this.xValueInput.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // timerFader
            // 
            this.timerFader.Interval = 10;
            this.timerFader.Tick += new System.EventHandler(this.timerFader_Tick);
            // 
            // HornerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(223)))), ((int)(((byte)(226)))));
            this.ClientSize = new System.Drawing.Size(779, 390);
            this.Controls.Add(this.xValueInput);
            this.Controls.Add(this.xValue);
            this.Controls.Add(this.hornerResult);
            this.Controls.Add(this.hornerFormula);
            this.Controls.Add(this.calBtn);
            this.Controls.Add(this.generateArray);
            this.Controls.Add(this.richTextBox2);
            this.Controls.Add(this.timePanel);
            this.Controls.Add(this.headPanel);
            this.Controls.Add(this.shapeContainer1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "HornerForm";
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
        private System.Windows.Forms.Button generateArray;
        private System.Windows.Forms.RichTextBox richTextBox2;
        private System.Windows.Forms.Label hornerFormula;
        private System.Windows.Forms.Button calBtn;
        private System.Windows.Forms.Label hornerResult;
        private System.Windows.Forms.Label xValue;
        private Microsoft.VisualBasic.PowerPacks.ShapeContainer shapeContainer1;
        private Microsoft.VisualBasic.PowerPacks.RectangleShape rectangleShape1;
        private System.Windows.Forms.TextBox xValueInput;
        private System.Windows.Forms.Timer timerFader;
    }
}