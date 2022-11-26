namespace OOPLAB3
{
    partial class FormSquare
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
            this.label3 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.BDraw = new System.Windows.Forms.Button();
            this.setW = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.labelWH = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.setY = new System.Windows.Forms.TextBox();
            this.setX = new System.Windows.Forms.TextBox();
            this.labelXY = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(200, 18);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 20);
            this.label3.TabIndex = 63;
            this.label3.Text = "КВАДРАТ";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(452, 9);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(94, 29);
            this.button1.TabIndex = 62;
            this.button1.Text = "Выйти";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // BDraw
            // 
            this.BDraw.Location = new System.Drawing.Point(176, 163);
            this.BDraw.Name = "BDraw";
            this.BDraw.Size = new System.Drawing.Size(102, 29);
            this.BDraw.TabIndex = 61;
            this.BDraw.Text = "Нарисовать";
            this.BDraw.UseVisualStyleBackColor = true;
            this.BDraw.Click += new System.EventHandler(this.BDraw_Click);
            // 
            // setW
            // 
            this.setW.Location = new System.Drawing.Point(241, 130);
            this.setW.Name = "setW";
            this.setW.Size = new System.Drawing.Size(99, 27);
            this.setW.TabIndex = 59;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(241, 107);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 20);
            this.label4.TabIndex = 57;
            this.label4.Text = "Ширина";
            // 
            // labelWH
            // 
            this.labelWH.AutoSize = true;
            this.labelWH.Location = new System.Drawing.Point(241, 75);
            this.labelWH.Name = "labelWH";
            this.labelWH.Size = new System.Drawing.Size(74, 20);
            this.labelWH.TabIndex = 56;
            this.labelWH.Text = "Размеры:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(114, 107);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(17, 20);
            this.label2.TabIndex = 55;
            this.label2.Text = "Y";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 105);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(18, 20);
            this.label1.TabIndex = 54;
            this.label1.Text = "X";
            // 
            // setY
            // 
            this.setY.Location = new System.Drawing.Point(114, 130);
            this.setY.Name = "setY";
            this.setY.Size = new System.Drawing.Size(99, 27);
            this.setY.TabIndex = 53;
            // 
            // setX
            // 
            this.setX.Location = new System.Drawing.Point(9, 130);
            this.setX.Name = "setX";
            this.setX.Size = new System.Drawing.Size(99, 27);
            this.setX.TabIndex = 52;
            // 
            // labelXY
            // 
            this.labelXY.AutoSize = true;
            this.labelXY.Location = new System.Drawing.Point(9, 75);
            this.labelXY.Name = "labelXY";
            this.labelXY.Size = new System.Drawing.Size(99, 20);
            this.labelXY.TabIndex = 51;
            this.labelXY.Text = "Координаты:";
            // 
            // FormSquare
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Lime;
            this.ClientSize = new System.Drawing.Size(555, 200);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.BDraw);
            this.Controls.Add(this.setW);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.labelWH);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.setY);
            this.Controls.Add(this.setX);
            this.Controls.Add(this.labelXY);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormSquare";
            this.Text = "FormSquare";
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.FormSquare_MouseDown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label3;
        private Button button1;
        private Button BDraw;
        private TextBox setW;
        private Label label4;
        private Label labelWH;
        private Label label2;
        private Label label1;
        private TextBox setY;
        private TextBox setX;
        private Label labelXY;
    }
}