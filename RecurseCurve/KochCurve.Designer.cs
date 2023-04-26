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
            btnStart = new Button();
            groupBox2 = new GroupBox();
            tbLength = new TextBox();
            label2 = new Label();
            label1 = new Label();
            tbDeth = new TextBox();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // btnStart
            // 
            btnStart.Location = new Point(630, 396);
            btnStart.Name = "btnStart";
            btnStart.Size = new Size(94, 34);
            btnStart.TabIndex = 0;
            btnStart.Text = "Start";
            btnStart.TextImageRelation = TextImageRelation.TextBeforeImage;
            btnStart.UseVisualStyleBackColor = true;
            btnStart.Click += btnStart_Click;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(tbLength);
            groupBox2.Controls.Add(label2);
            groupBox2.Controls.Add(label1);
            groupBox2.Controls.Add(tbDeth);
            groupBox2.Location = new Point(12, 235);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(164, 196);
            groupBox2.TabIndex = 2;
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
            // KochCurve
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(736, 443);
            Controls.Add(groupBox2);
            Controls.Add(btnStart);
            Name = "KochCurve";
            Text = "Form1";
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Button btnStart;
        private GroupBox groupBox2;
        private TextBox tbLength;
        private Label label2;
        private Label label1;
        private TextBox tbDeth;
    }
}