namespace Algorithms
{
    partial class MainForm
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
            this.closeBtn = new DevExpress.XtraEditors.SimpleButton();
            this.navBar = new DevExpress.XtraEditors.PanelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.minBtn = new DevExpress.XtraEditors.SimpleButton();
            this.shapeContainer1 = new Microsoft.VisualBasic.PowerPacks.ShapeContainer();
            this.rectangleShape1 = new Microsoft.VisualBasic.PowerPacks.RectangleShape();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.algorithmList = new DevExpress.XtraEditors.PanelControl();
            this.sum = new DevExpress.XtraEditors.SimpleButton();
            this.presortElementUniqueness = new DevExpress.XtraEditors.SimpleButton();
            this.lcm = new DevExpress.XtraEditors.SimpleButton();
            this.horner = new DevExpress.XtraEditors.SimpleButton();
            this.largestProduct = new DevExpress.XtraEditors.SimpleButton();
            this.bruteForceStringMatch = new DevExpress.XtraEditors.SimpleButton();
            this.countingSunday = new DevExpress.XtraEditors.SimpleButton();
            this.fibonacci = new DevExpress.XtraEditors.SimpleButton();
            this.selectionSort = new DevExpress.XtraEditors.SimpleButton();
            this.closetPair = new DevExpress.XtraEditors.SimpleButton();
            this.mainTitle = new System.Windows.Forms.Label();
            this.timerFader = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.navBar)).BeginInit();
            this.navBar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.algorithmList)).BeginInit();
            this.algorithmList.SuspendLayout();
            this.SuspendLayout();
            // 
            // closeBtn
            // 
            this.closeBtn.AllowFocus = false;
            this.closeBtn.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(87)))), ((int)(((byte)(83)))));
            this.closeBtn.Appearance.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(87)))), ((int)(((byte)(83)))));
            this.closeBtn.Appearance.BorderColor = System.Drawing.Color.Maroon;
            this.closeBtn.Appearance.Font = new System.Drawing.Font("Tahoma", 1F);
            this.closeBtn.Appearance.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.closeBtn.Appearance.Options.UseBackColor = true;
            this.closeBtn.Appearance.Options.UseBorderColor = true;
            this.closeBtn.Appearance.Options.UseFont = true;
            this.closeBtn.AppearanceHovered.BackColor = System.Drawing.Color.Red;
            this.closeBtn.AppearanceHovered.BackColor2 = System.Drawing.Color.Red;
            this.closeBtn.AppearanceHovered.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(52)))), ((int)(((byte)(48)))));
            this.closeBtn.AppearanceHovered.Font = new System.Drawing.Font("Tahoma", 1F);
            this.closeBtn.AppearanceHovered.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.closeBtn.AppearanceHovered.Options.UseBackColor = true;
            this.closeBtn.AppearanceHovered.Options.UseBorderColor = true;
            this.closeBtn.AppearanceHovered.Options.UseFont = true;
            this.closeBtn.AppearancePressed.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.closeBtn.AppearancePressed.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.closeBtn.AppearancePressed.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(52)))), ((int)(((byte)(48)))));
            this.closeBtn.AppearancePressed.Font = new System.Drawing.Font("Tahoma", 1F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.closeBtn.AppearancePressed.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.closeBtn.AppearancePressed.Options.UseBackColor = true;
            this.closeBtn.AppearancePressed.Options.UseBorderColor = true;
            this.closeBtn.AppearancePressed.Options.UseFont = true;
            this.closeBtn.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.closeBtn.Location = new System.Drawing.Point(697, 6);
            this.closeBtn.LookAndFeel.UseDefaultLookAndFeel = false;
            this.closeBtn.LookAndFeel.UseWindowsXPTheme = true;
            this.closeBtn.Name = "closeBtn";
            this.closeBtn.Size = new System.Drawing.Size(19, 21);
            this.closeBtn.TabIndex = 0;
            this.closeBtn.Click += new System.EventHandler(this.closeBtn_Click);
            // 
            // navBar
            // 
            this.navBar.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(223)))), ((int)(((byte)(226)))));
            this.navBar.Appearance.BorderColor = System.Drawing.Color.DarkGray;
            this.navBar.Appearance.Options.UseBackColor = true;
            this.navBar.Appearance.Options.UseBorderColor = true;
            this.navBar.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Office2003;
            this.navBar.Controls.Add(this.labelControl1);
            this.navBar.Controls.Add(this.minBtn);
            this.navBar.Controls.Add(this.closeBtn);
            this.navBar.Controls.Add(this.shapeContainer1);
            this.navBar.Location = new System.Drawing.Point(-3, -2);
            this.navBar.Name = "navBar";
            this.navBar.Size = new System.Drawing.Size(725, 32);
            this.navBar.TabIndex = 1;
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Open Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.labelControl1.Location = new System.Drawing.Point(35, 6);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(200, 21);
            this.labelControl1.TabIndex = 1;
            this.labelControl1.Text = "Analysis and Design Algorithms";
            // 
            // minBtn
            // 
            this.minBtn.AllowFocus = false;
            this.minBtn.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(187)))), ((int)(((byte)(70)))));
            this.minBtn.Appearance.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(187)))), ((int)(((byte)(70)))));
            this.minBtn.Appearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(185)))), ((int)(((byte)(82)))));
            this.minBtn.Appearance.Font = new System.Drawing.Font("Tahoma", 1F);
            this.minBtn.Appearance.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.minBtn.Appearance.Options.UseBackColor = true;
            this.minBtn.Appearance.Options.UseBorderColor = true;
            this.minBtn.Appearance.Options.UseFont = true;
            this.minBtn.AppearanceHovered.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(168)))), ((int)(((byte)(19)))));
            this.minBtn.AppearanceHovered.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(168)))), ((int)(((byte)(19)))));
            this.minBtn.AppearanceHovered.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(185)))), ((int)(((byte)(82)))));
            this.minBtn.AppearanceHovered.Font = new System.Drawing.Font("Tahoma", 1F);
            this.minBtn.AppearanceHovered.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.minBtn.AppearanceHovered.Options.UseBackColor = true;
            this.minBtn.AppearanceHovered.Options.UseBorderColor = true;
            this.minBtn.AppearanceHovered.Options.UseFont = true;
            this.minBtn.AppearancePressed.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(211)))), ((int)(((byte)(139)))), ((int)(((byte)(5)))));
            this.minBtn.AppearancePressed.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(211)))), ((int)(((byte)(139)))), ((int)(((byte)(5)))));
            this.minBtn.AppearancePressed.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(185)))), ((int)(((byte)(82)))));
            this.minBtn.AppearancePressed.Font = new System.Drawing.Font("Tahoma", 1F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.minBtn.AppearancePressed.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.minBtn.AppearancePressed.Options.UseBackColor = true;
            this.minBtn.AppearancePressed.Options.UseBorderColor = true;
            this.minBtn.AppearancePressed.Options.UseFont = true;
            this.minBtn.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.minBtn.Location = new System.Drawing.Point(672, 6);
            this.minBtn.LookAndFeel.UseDefaultLookAndFeel = false;
            this.minBtn.LookAndFeel.UseWindowsXPTheme = true;
            this.minBtn.Name = "minBtn";
            this.minBtn.Size = new System.Drawing.Size(19, 21);
            this.minBtn.TabIndex = 0;
            this.minBtn.Click += new System.EventHandler(this.minBtn_Click);
            // 
            // shapeContainer1
            // 
            this.shapeContainer1.Location = new System.Drawing.Point(2, 2);
            this.shapeContainer1.Margin = new System.Windows.Forms.Padding(0);
            this.shapeContainer1.Name = "shapeContainer1";
            this.shapeContainer1.Shapes.AddRange(new Microsoft.VisualBasic.PowerPacks.Shape[] {
            this.rectangleShape1});
            this.shapeContainer1.Size = new System.Drawing.Size(721, 28);
            this.shapeContainer1.TabIndex = 2;
            this.shapeContainer1.TabStop = false;
            // 
            // rectangleShape1
            // 
            this.rectangleShape1.BackgroundImage = global::Algorithms.Properties.Resources.Algorithmia_Logo;
            this.rectangleShape1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.rectangleShape1.BorderColor = System.Drawing.Color.Transparent;
            this.rectangleShape1.Location = new System.Drawing.Point(8, 7);
            this.rectangleShape1.Name = "rectangleShape1";
            this.rectangleShape1.Size = new System.Drawing.Size(19, 17);
            // 
            // panelControl1
            // 
            this.panelControl1.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(223)))), ((int)(((byte)(226)))));
            this.panelControl1.Appearance.BorderColor = System.Drawing.Color.DarkGray;
            this.panelControl1.Appearance.Options.UseBackColor = true;
            this.panelControl1.Appearance.Options.UseBorderColor = true;
            this.panelControl1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Office2003;
            this.panelControl1.Controls.Add(this.labelControl2);
            this.panelControl1.Location = new System.Drawing.Point(-3, 497);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(724, 32);
            this.panelControl1.TabIndex = 1;
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Open Sans", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl2.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.labelControl2.Appearance.Options.UseFont = true;
            this.labelControl2.Appearance.Options.UseForeColor = true;
            this.labelControl2.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.labelControl2.Location = new System.Drawing.Point(279, 5);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(172, 22);
            this.labelControl2.TabIndex = 1;
            this.labelControl2.Text = "Copyright © 2016 Bùi Lê Minh";
            // 
            // algorithmList
            // 
            this.algorithmList.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.algorithmList.Appearance.Options.UseBackColor = true;
            this.algorithmList.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.algorithmList.Controls.Add(this.sum);
            this.algorithmList.Controls.Add(this.presortElementUniqueness);
            this.algorithmList.Controls.Add(this.lcm);
            this.algorithmList.Controls.Add(this.horner);
            this.algorithmList.Controls.Add(this.largestProduct);
            this.algorithmList.Controls.Add(this.bruteForceStringMatch);
            this.algorithmList.Controls.Add(this.countingSunday);
            this.algorithmList.Controls.Add(this.fibonacci);
            this.algorithmList.Controls.Add(this.selectionSort);
            this.algorithmList.Controls.Add(this.closetPair);
            this.algorithmList.Location = new System.Drawing.Point(32, 90);
            this.algorithmList.Name = "algorithmList";
            this.algorithmList.Size = new System.Drawing.Size(655, 378);
            this.algorithmList.TabIndex = 2;
            // 
            // sum
            // 
            this.sum.AllowDrop = true;
            this.sum.AllowFocus = false;
            this.sum.Appearance.Font = new System.Drawing.Font("Open Sans", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sum.Appearance.Options.UseFont = true;
            this.sum.Location = new System.Drawing.Point(3, 227);
            this.sum.Name = "sum";
            this.sum.ShowFocusRectangle = DevExpress.Utils.DefaultBoolean.False;
            this.sum.Size = new System.Drawing.Size(119, 148);
            this.sum.TabIndex = 0;
            this.sum.Text = "Sum";
            this.sum.Click += new System.EventHandler(this.sum_Click);
            // 
            // presortElementUniqueness
            // 
            this.presortElementUniqueness.AllowDrop = true;
            this.presortElementUniqueness.AllowFocus = false;
            this.presortElementUniqueness.Appearance.Font = new System.Drawing.Font("Open Sans", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.presortElementUniqueness.Appearance.Options.UseFont = true;
            this.presortElementUniqueness.Appearance.Options.UseTextOptions = true;
            this.presortElementUniqueness.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.presortElementUniqueness.Location = new System.Drawing.Point(122, 227);
            this.presortElementUniqueness.Name = "presortElementUniqueness";
            this.presortElementUniqueness.ShowFocusRectangle = DevExpress.Utils.DefaultBoolean.False;
            this.presortElementUniqueness.Size = new System.Drawing.Size(267, 148);
            this.presortElementUniqueness.TabIndex = 0;
            this.presortElementUniqueness.Text = "Presort Element Uniqueness";
            this.presortElementUniqueness.Click += new System.EventHandler(this.presortElementUniqueness_Click);
            // 
            // lcm
            // 
            this.lcm.AllowDrop = true;
            this.lcm.AllowFocus = false;
            this.lcm.Appearance.Font = new System.Drawing.Font("Open Sans", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lcm.Appearance.Options.UseFont = true;
            this.lcm.Location = new System.Drawing.Point(389, 92);
            this.lcm.Name = "lcm";
            this.lcm.ShowFocusRectangle = DevExpress.Utils.DefaultBoolean.False;
            this.lcm.Size = new System.Drawing.Size(74, 164);
            this.lcm.TabIndex = 0;
            this.lcm.Text = "LCM";
            this.lcm.Click += new System.EventHandler(this.lcm_Click);
            // 
            // horner
            // 
            this.horner.AllowDrop = true;
            this.horner.AllowFocus = false;
            this.horner.Appearance.Font = new System.Drawing.Font("Open Sans", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.horner.Appearance.Options.UseFont = true;
            this.horner.Location = new System.Drawing.Point(389, 256);
            this.horner.Name = "horner";
            this.horner.ShowFocusRectangle = DevExpress.Utils.DefaultBoolean.False;
            this.horner.Size = new System.Drawing.Size(118, 119);
            this.horner.TabIndex = 0;
            this.horner.Text = "Horner";
            this.horner.Click += new System.EventHandler(this.horner_Click);
            // 
            // largestProduct
            // 
            this.largestProduct.AllowDrop = true;
            this.largestProduct.AllowFocus = false;
            this.largestProduct.Appearance.Font = new System.Drawing.Font("Open Sans", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.largestProduct.Appearance.Options.UseFont = true;
            this.largestProduct.Location = new System.Drawing.Point(463, 92);
            this.largestProduct.Name = "largestProduct";
            this.largestProduct.ShowFocusRectangle = DevExpress.Utils.DefaultBoolean.False;
            this.largestProduct.Size = new System.Drawing.Size(189, 164);
            this.largestProduct.TabIndex = 0;
            this.largestProduct.Text = "Largest \r\nProduct";
            this.largestProduct.Click += new System.EventHandler(this.largestProduct_Click);
            // 
            // bruteForceStringMatch
            // 
            this.bruteForceStringMatch.AllowDrop = true;
            this.bruteForceStringMatch.AllowFocus = false;
            this.bruteForceStringMatch.Appearance.Font = new System.Drawing.Font("Open Sans", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bruteForceStringMatch.Appearance.Options.UseFont = true;
            this.bruteForceStringMatch.Location = new System.Drawing.Point(345, 3);
            this.bruteForceStringMatch.Name = "bruteForceStringMatch";
            this.bruteForceStringMatch.ShowFocusRectangle = DevExpress.Utils.DefaultBoolean.False;
            this.bruteForceStringMatch.Size = new System.Drawing.Size(307, 89);
            this.bruteForceStringMatch.TabIndex = 0;
            this.bruteForceStringMatch.Text = "Brute Force String Match";
            this.bruteForceStringMatch.Click += new System.EventHandler(this.bruteForceStringMatch_Click);
            // 
            // countingSunday
            // 
            this.countingSunday.AllowDrop = true;
            this.countingSunday.AllowFocus = false;
            this.countingSunday.Appearance.Font = new System.Drawing.Font("Open Sans", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.countingSunday.Appearance.Options.UseFont = true;
            this.countingSunday.Location = new System.Drawing.Point(138, 92);
            this.countingSunday.Name = "countingSunday";
            this.countingSunday.ShowFocusRectangle = DevExpress.Utils.DefaultBoolean.False;
            this.countingSunday.Size = new System.Drawing.Size(251, 135);
            this.countingSunday.TabIndex = 0;
            this.countingSunday.Text = "Counting \r\nSunday";
            this.countingSunday.Click += new System.EventHandler(this.countingSunday_Click);
            // 
            // fibonacci
            // 
            this.fibonacci.AllowDrop = true;
            this.fibonacci.AllowFocus = false;
            this.fibonacci.Appearance.Font = new System.Drawing.Font("Open Sans", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fibonacci.Appearance.Options.UseFont = true;
            this.fibonacci.Location = new System.Drawing.Point(507, 256);
            this.fibonacci.Name = "fibonacci";
            this.fibonacci.ShowFocusRectangle = DevExpress.Utils.DefaultBoolean.False;
            this.fibonacci.Size = new System.Drawing.Size(145, 119);
            this.fibonacci.TabIndex = 0;
            this.fibonacci.Text = "Fibonacci";
            this.fibonacci.Click += new System.EventHandler(this.fibonacci_Click);
            // 
            // selectionSort
            // 
            this.selectionSort.AllowDrop = true;
            this.selectionSort.AllowFocus = false;
            this.selectionSort.Appearance.Font = new System.Drawing.Font("Open Sans", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.selectionSort.Appearance.Options.UseFont = true;
            this.selectionSort.Location = new System.Drawing.Point(138, 3);
            this.selectionSort.Name = "selectionSort";
            this.selectionSort.ShowFocusRectangle = DevExpress.Utils.DefaultBoolean.False;
            this.selectionSort.Size = new System.Drawing.Size(207, 89);
            this.selectionSort.TabIndex = 0;
            this.selectionSort.Text = "Selection Sort";
            this.selectionSort.Click += new System.EventHandler(this.selectionSort_Click);
            // 
            // closetPair
            // 
            this.closetPair.AllowDrop = true;
            this.closetPair.AllowFocus = false;
            this.closetPair.Appearance.Font = new System.Drawing.Font("Open Sans", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.closetPair.Appearance.Options.UseFont = true;
            this.closetPair.Location = new System.Drawing.Point(3, 3);
            this.closetPair.Name = "closetPair";
            this.closetPair.ShowFocusRectangle = DevExpress.Utils.DefaultBoolean.False;
            this.closetPair.Size = new System.Drawing.Size(135, 224);
            this.closetPair.TabIndex = 0;
            this.closetPair.Text = "Brute \r\nForce \r\nClosest \r\nPair";
            this.closetPair.Click += new System.EventHandler(this.closestPair_Click);
            // 
            // mainTitle
            // 
            this.mainTitle.AutoSize = true;
            this.mainTitle.Font = new System.Drawing.Font("Open Sans", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mainTitle.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.mainTitle.Location = new System.Drawing.Point(249, 50);
            this.mainTitle.Name = "mainTitle";
            this.mainTitle.Size = new System.Drawing.Size(227, 26);
            this.mainTitle.TabIndex = 3;
            this.mainTitle.Text = "List of algorithms\' name";
            // 
            // timerFader
            // 
            this.timerFader.Interval = 10;
            this.timerFader.Tick += new System.EventHandler(this.timerFader_Tick);
            // 
            // MainForm
            // 
            this.ActiveGlowColor = System.Drawing.Color.Silver;
            this.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Appearance.ForeColor = System.Drawing.Color.Black;
            this.Appearance.Options.UseBackColor = true;
            this.Appearance.Options.UseForeColor = true;
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(719, 528);
            this.Controls.Add(this.mainTitle);
            this.Controls.Add(this.algorithmList);
            this.Controls.Add(this.panelControl1);
            this.Controls.Add(this.navBar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.LookAndFeel.SkinMaskColor = System.Drawing.Color.Yellow;
            this.LookAndFeel.SkinMaskColor2 = System.Drawing.Color.Yellow;
            this.LookAndFeel.Style = DevExpress.LookAndFeel.LookAndFeelStyle.UltraFlat;
            this.LookAndFeel.UseDefaultLookAndFeel = false;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Analysis and Design Algorithms";
            ((System.ComponentModel.ISupportInitialize)(this.navBar)).EndInit();
            this.navBar.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.algorithmList)).EndInit();
            this.algorithmList.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.SimpleButton closeBtn;
        private DevExpress.XtraEditors.PanelControl navBar;
        private DevExpress.XtraEditors.SimpleButton minBtn;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private Microsoft.VisualBasic.PowerPacks.RectangleShape rectangleShape1;
        private Microsoft.VisualBasic.PowerPacks.ShapeContainer shapeContainer1;
        private DevExpress.XtraEditors.PanelControl algorithmList;
        private DevExpress.XtraEditors.SimpleButton closetPair;
        private DevExpress.XtraEditors.SimpleButton selectionSort;
        private DevExpress.XtraEditors.SimpleButton sum;
        private DevExpress.XtraEditors.SimpleButton presortElementUniqueness;
        private DevExpress.XtraEditors.SimpleButton lcm;
        private DevExpress.XtraEditors.SimpleButton horner;
        private DevExpress.XtraEditors.SimpleButton largestProduct;
        private DevExpress.XtraEditors.SimpleButton bruteForceStringMatch;
        private DevExpress.XtraEditors.SimpleButton countingSunday;
        private DevExpress.XtraEditors.SimpleButton fibonacci;
        private System.Windows.Forms.Label mainTitle;
        private System.Windows.Forms.Timer timerFader;


    }
}