namespace OOPLAB3
{
    partial class FormEllipse
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
            this.setH = new System.Windows.Forms.TextBox();
            this.setW = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
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
            this.label3.Location = new System.Drawing.Point(203, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 20);
            this.label3.TabIndex = 37;
            this.label3.Text = "ЭЛЛИПС";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(455, 0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(94, 29);
            this.button1.TabIndex = 36;
            this.button1.Text = "Выйти";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // BDraw
            // 
            this.BDraw.Location = new System.Drawing.Point(179, 154);
            this.BDraw.Name = "BDraw";
            this.BDraw.Size = new System.Drawing.Size(102, 29);
            this.BDraw.TabIndex = 35;
            this.BDraw.Text = "Нарисовать";
            this.BDraw.UseVisualStyleBackColor = true;
            this.BDraw.Click += new System.EventHandler(this.BDraw_Click);
            // 
            // setH
            // 
            this.setH.Location = new System.Drawing.Point(349, 121);
            this.setH.Name = "setH";
            this.setH.Size = new System.Drawing.Size(99, 27);
            this.setH.TabIndex = 34;
            // 
            // setW
            // 
            this.setW.Location = new System.Drawing.Point(244, 121);
            this.setW.Name = "setW";
            this.setW.Size = new System.Drawing.Size(99, 27);
            this.setW.TabIndex = 33;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(349, 98);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(59, 20);
            this.label5.TabIndex = 32;
            this.label5.Text = "Высота";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(244, 98);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 20);
            this.label4.TabIndex = 31;
            this.label4.Text = "Ширина";
            // 
            // labelWH
            // 
            this.labelWH.AutoSize = true;
            this.labelWH.Location = new System.Drawing.Point(244, 66);
            this.labelWH.Name = "labelWH";
            this.labelWH.Size = new System.Drawing.Size(74, 20);
            this.labelWH.TabIndex = 30;
            this.labelWH.Text = "Размеры:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(117, 98);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(17, 20);
            this.label2.TabIndex = 29;
            this.label2.Text = "Y";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 96);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(18, 20);
            this.label1.TabIndex = 28;
            this.label1.Text = "X";
            // 
            // setY
            // 
            this.setY.Location = new System.Drawing.Point(117, 121);
            this.setY.Name = "setY";
            this.setY.Size = new System.Drawing.Size(99, 27);
            this.setY.TabIndex = 27;
            // 
            // setX
            // 
            this.setX.Location = new System.Drawing.Point(12, 121);
            this.setX.Name = "setX";
            this.setX.Size = new System.Drawing.Size(99, 27);
            this.setX.TabIndex = 26;
            // 
            // labelXY
            // 
            this.labelXY.AutoSize = true;
            this.labelXY.Location = new System.Drawing.Point(12, 66);
            this.labelXY.Name = "labelXY";
            this.labelXY.Size = new System.Drawing.Size(99, 20);
            this.labelXY.TabIndex = 25;
            this.labelXY.Text = "Координаты:";
            // 
            // FormEllipse
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Red;
            this.ClientSize = new System.Drawing.Size(555, 193);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.BDraw);
            this.Controls.Add(this.setH);
            this.Controls.Add(this.setW);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.labelWH);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.setY);
            this.Controls.Add(this.setX);
            this.Controls.Add(this.labelXY);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormEllipse";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormEllipse";
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.FormEllipse_MouseDown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label3;
        private Button button1;
        private Button BDraw;
        private TextBox setH;
        private TextBox setW;
        private Label label5;
        private Label label4;
        private Label labelWH;
        private Label label2;
        private Label label1;
        private TextBox setY;
        private TextBox setX;
        private Label labelXY;
    }
}