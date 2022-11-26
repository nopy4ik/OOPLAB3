namespace OOPLAB3
{
    partial class FormResize
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
            this.label1 = new System.Windows.Forms.Label();
            this.labelW = new System.Windows.Forms.Label();
            this.labelH = new System.Windows.Forms.Label();
            this.labelR = new System.Windows.Forms.Label();
            this.setW = new System.Windows.Forms.TextBox();
            this.setH = new System.Windows.Forms.TextBox();
            this.setR = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(198, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(159, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "ИЗМЕНИТЬ РАЗМЕРЫ";
            // 
            // labelW
            // 
            this.labelW.AutoSize = true;
            this.labelW.ForeColor = System.Drawing.SystemColors.Control;
            this.labelW.Location = new System.Drawing.Point(12, 73);
            this.labelW.Name = "labelW";
            this.labelW.Size = new System.Drawing.Size(67, 20);
            this.labelW.TabIndex = 1;
            this.labelW.Text = "Ширина";
            // 
            // labelH
            // 
            this.labelH.AutoSize = true;
            this.labelH.ForeColor = System.Drawing.SystemColors.Control;
            this.labelH.Location = new System.Drawing.Point(143, 73);
            this.labelH.Name = "labelH";
            this.labelH.Size = new System.Drawing.Size(59, 20);
            this.labelH.TabIndex = 2;
            this.labelH.Text = "Высота";
            // 
            // labelR
            // 
            this.labelR.AutoSize = true;
            this.labelR.ForeColor = System.Drawing.SystemColors.Control;
            this.labelR.Location = new System.Drawing.Point(274, 73);
            this.labelR.Name = "labelR";
            this.labelR.Size = new System.Drawing.Size(56, 20);
            this.labelR.TabIndex = 3;
            this.labelR.Text = "Радиус";
            // 
            // setW
            // 
            this.setW.Location = new System.Drawing.Point(12, 96);
            this.setW.Name = "setW";
            this.setW.Size = new System.Drawing.Size(125, 27);
            this.setW.TabIndex = 4;
            this.setW.Text = "0";
            // 
            // setH
            // 
            this.setH.Location = new System.Drawing.Point(143, 96);
            this.setH.Name = "setH";
            this.setH.Size = new System.Drawing.Size(125, 27);
            this.setH.TabIndex = 5;
            this.setH.Text = "0";
            // 
            // setR
            // 
            this.setR.Location = new System.Drawing.Point(274, 96);
            this.setR.Name = "setR";
            this.setR.Size = new System.Drawing.Size(125, 27);
            this.setR.TabIndex = 6;
            this.setR.Text = "0";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(230, 159);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(94, 29);
            this.button1.TabIndex = 7;
            this.button1.Text = "Изменить";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(449, 12);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(94, 29);
            this.button2.TabIndex = 8;
            this.button2.Text = "Выйти";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // FormResize
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(555, 200);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.setR);
            this.Controls.Add(this.setH);
            this.Controls.Add(this.setW);
            this.Controls.Add(this.labelR);
            this.Controls.Add(this.labelH);
            this.Controls.Add(this.labelW);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormResize";
            this.Text = "FormResize";
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.FormResize_MouseDown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Label labelW;
        private Label labelH;
        private Label labelR;
        private TextBox setW;
        private TextBox setH;
        private TextBox setR;
        private Button button1;
        private Button button2;
    }
}