namespace OOPLAB3
{
    partial class FormTriangle
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
            this.buttonDraw = new System.Windows.Forms.Button();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.setY = new System.Windows.Forms.TextBox();
            this.setX = new System.Windows.Forms.TextBox();
            this.labelXY = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // buttonDraw
            // 
            this.buttonDraw.Location = new System.Drawing.Point(437, 161);
            this.buttonDraw.Name = "buttonDraw";
            this.buttonDraw.Size = new System.Drawing.Size(104, 29);
            this.buttonDraw.TabIndex = 78;
            this.buttonDraw.Text = "Нарисовать";
            this.buttonDraw.UseVisualStyleBackColor = true;
            this.buttonDraw.Click += new System.EventHandler(this.buttonDraw_Click);
            // 
            // buttonAdd
            // 
            this.buttonAdd.Location = new System.Drawing.Point(220, 161);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(94, 29);
            this.buttonAdd.TabIndex = 75;
            this.buttonAdd.Text = "Добавить";
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(198, 20);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(110, 20);
            this.label3.TabIndex = 74;
            this.label3.Text = "ТРЕУГОЛЬНИК";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(450, 11);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(94, 29);
            this.button1.TabIndex = 73;
            this.button1.Text = "Выйти";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(115, 140);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(17, 20);
            this.label2.TabIndex = 72;
            this.label2.Text = "Y";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 140);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(18, 20);
            this.label1.TabIndex = 71;
            this.label1.Text = "X";
            // 
            // setY
            // 
            this.setY.Location = new System.Drawing.Point(115, 163);
            this.setY.Name = "setY";
            this.setY.Size = new System.Drawing.Size(99, 27);
            this.setY.TabIndex = 70;
            // 
            // setX
            // 
            this.setX.Location = new System.Drawing.Point(10, 163);
            this.setX.Name = "setX";
            this.setX.Size = new System.Drawing.Size(99, 27);
            this.setX.TabIndex = 69;
            // 
            // labelXY
            // 
            this.labelXY.AutoSize = true;
            this.labelXY.Location = new System.Drawing.Point(10, 111);
            this.labelXY.Name = "labelXY";
            this.labelXY.Size = new System.Drawing.Size(227, 20);
            this.labelXY.TabIndex = 68;
            this.labelXY.Text = "Введите координаты 1-й точки:";
            // 
            // FormTriangle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Fuchsia;
            this.ClientSize = new System.Drawing.Size(555, 200);
            this.Controls.Add(this.buttonDraw);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.setY);
            this.Controls.Add(this.setX);
            this.Controls.Add(this.labelXY);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormTriangle";
            this.Text = "FormTriangle";
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.FormTriangle_MouseDown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button buttonDraw;
        private Button buttonAdd;
        private Label label3;
        private Button button1;
        private Label label2;
        private Label label1;
        private TextBox setY;
        private TextBox setX;
        private Label labelXY;
    }
}