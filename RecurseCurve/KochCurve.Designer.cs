namespace RecurseCurve
{
    partial class KochCurve
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            kochCurveTab = new TabControl();
            tabPageKochCurve = new TabPage();
            tabPageDragonCurve = new TabPage();
            groupBox2 = new GroupBox();
            tbLength = new TextBox();
            btnStart = new Button();
            label2 = new Label();
            label1 = new Label();
            tbDeth = new TextBox();
            tabPageSierpinskiCurve = new TabPage();
            groupBox1 = new GroupBox();
            kochCurveTab.SuspendLayout();
            tabPageKochCurve.SuspendLayout();
            groupBox2.SuspendLayout();
            tabPageSierpinskiCurve.SuspendLayout();
            SuspendLayout();
            // 
            // kochCurveTab
            // 
            kochCurveTab.Controls.Add(tabPageKochCurve);
            kochCurveTab.Controls.Add(tabPageDragonCurve);
            kochCurveTab.Controls.Add(tabPageSierpinskiCurve);
            kochCurveTab.Location = new Point(3, 12);
            kochCurveTab.Name = "kochCurveTab";
            kochCurveTab.SelectedIndex = 0;
            kochCurveTab.Size = new Size(980, 524);
            kochCurveTab.TabIndex = 0;
            // 
            // tabPageKochCurve
            // 
            tabPageKochCurve.Controls.Add(groupBox2);
            tabPageKochCurve.Location = new Point(4, 29);
            tabPageKochCurve.Name = "tabPageKochCurve";
            tabPageKochCurve.Padding = new Padding(3);
            tabPageKochCurve.Size = new Size(972, 491);
            tabPageKochCurve.TabIndex = 0;
            tabPageKochCurve.Text = "Koch Curve";
            tabPageKochCurve.UseVisualStyleBackColor = true;
            // 
            // tabPageDragonCurve
            // 
            tabPageDragonCurve.Location = new Point(4, 29);
            tabPageDragonCurve.Name = "tabPageDragonCurve";
            tabPageDragonCurve.Padding = new Padding(3);
            tabPageDragonCurve.Size = new Size(972, 491);
            tabPageDragonCurve.TabIndex = 1;
            tabPageDragonCurve.Text = "Dragon Curve";
            tabPageDragonCurve.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(tbLength);
            groupBox2.Controls.Add(btnStart);
            groupBox2.Controls.Add(label2);
            groupBox2.Controls.Add(label1);
            groupBox2.Controls.Add(tbDeth);
            groupBox2.Location = new Point(6, 289);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(296, 196);
            groupBox2.TabIndex = 3;
            groupBox2.TabStop = false;
            groupBox2.Text = "Init Data";
            // 
            // tbLength
            // 
            tbLength.Location = new Point(6, 144);
            tbLength.Name = "tbLength";
            tbLength.Size = new Size(149, 27);
            tbLength.TabIndex = 3;
            // 
            // btnStart
            // 
            btnStart.Location = new Point(192, 144);
            btnStart.Name = "btnStart";
            btnStart.Size = new Size(94, 34);
            btnStart.TabIndex = 0;
            btnStart.Text = "Start";
            btnStart.TextImageRelation = TextImageRelation.TextBeforeImage;
            btnStart.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(6, 112);
            label2.Name = "label2";
            label2.Size = new Size(132, 20);
            label2.TabIndex = 2;
            label2.Text = "Довжина відрізка";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(6, 41);
            label1.Name = "label1";
            label1.Size = new Size(125, 20);
            label1.TabIndex = 1;
            label1.Text = "Глубина рекурсії";
            // 
            // tbDeth
            // 
            tbDeth.Location = new Point(6, 64);
            tbDeth.Name = "tbDeth";
            tbDeth.Size = new Size(149, 27);
            tbDeth.TabIndex = 0;
            // 
            // tabPageSierpinskiCurve
            // 
            tabPageSierpinskiCurve.Controls.Add(groupBox1);
            tabPageSierpinskiCurve.Location = new Point(4, 29);
            tabPageSierpinskiCurve.Name = "tabPageSierpinskiCurve";
            tabPageSierpinskiCurve.Padding = new Padding(3);
            tabPageSierpinskiCurve.Size = new Size(972, 491);
            tabPageSierpinskiCurve.TabIndex = 2;
            tabPageSierpinskiCurve.Text = "Sierpinski Curve";
            tabPageSierpinskiCurve.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            groupBox1.Location = new Point(6, 315);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(301, 170);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "initData Dragon";
            // 
            // KochCurve
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            ClientSize = new Size(999, 541);
            Controls.Add(kochCurveTab);
            Name = "KochCurve";
            Text = "Main";
            kochCurveTab.ResumeLayout(false);
            tabPageKochCurve.ResumeLayout(false);
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            tabPageSierpinskiCurve.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private TabControl kochCurveTab;
        private TabPage tabPageKochCurve;
        private GroupBox groupBox2;
        private TextBox tbLength;
        private Button btnStart;
        private Label label2;
        private Label label1;
        private TextBox tbDeth;
        private TabPage tabPageDragonCurve;
        private TabPage tabPageSierpinskiCurve;
        private GroupBox groupBox1;
    }
}