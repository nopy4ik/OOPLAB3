namespace OOPLAB3
{
    partial class FormPoly
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
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.setY = new System.Windows.Forms.TextBox();
            this.setX = new System.Windows.Forms.TextBox();
            this.labelXY = new System.Windows.Forms.Label();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxCount = new System.Windows.Forms.TextBox();
            this.buttonDraw = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(200, 18);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(139, 20);
            this.label3.TabIndex = 63;
            this.label3.Text = "МНОГОУГОЛЬНИК";
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
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(117, 138);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(17, 20);
            this.label2.TabIndex = 55;
            this.label2.Text = "Y";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 138);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(18, 20);
            this.label1.TabIndex = 54;
            this.label1.Text = "X";
            // 
            // setY
            // 
            this.setY.Location = new System.Drawing.Point(117, 161);
            this.setY.Name = "setY";
            this.setY.Size = new System.Drawing.Size(99, 27);
            this.setY.TabIndex = 53;
            // 
            // setX
            // 
            this.setX.Location = new System.Drawing.Point(12, 161);
            this.setX.Name = "setX";
            this.setX.Size = new System.Drawing.Size(99, 27);
            this.setX.TabIndex = 52;
            // 
            // labelXY
            // 
            this.labelXY.AutoSize = true;
            this.labelXY.Location = new System.Drawing.Point(12, 109);
            this.labelXY.Name = "labelXY";
            this.labelXY.Size = new System.Drawing.Size(227, 20);
            this.labelXY.TabIndex = 51;
            this.labelXY.Text = "Введите координаты 1-й точки:";
            // 
            // buttonAdd
            // 
            this.buttonAdd.Location = new System.Drawing.Point(222, 159);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(94, 29);
            this.buttonAdd.TabIndex = 64;
            this.buttonAdd.Text = "Добавить";
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 56);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(178, 20);
            this.label4.TabIndex = 65;
            this.label4.Text = "Введите кол-во вершин:";
            // 
            // textBoxCount
            // 
            this.textBoxCount.Location = new System.Drawing.Point(12, 79);
            this.textBoxCount.Name = "textBoxCount";
            this.textBoxCount.Size = new System.Drawing.Size(62, 27);
            this.textBoxCount.TabIndex = 66;
            this.textBoxCount.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBoxCount_KeyDown);
            // 
            // buttonDraw
            // 
            this.buttonDraw.Location = new System.Drawing.Point(439, 159);
            this.buttonDraw.Name = "buttonDraw";
            this.buttonDraw.Size = new System.Drawing.Size(104, 29);
            this.buttonDraw.TabIndex = 67;
            this.buttonDraw.Text = "Нарисовать";
            this.buttonDraw.UseVisualStyleBackColor = true;
            this.buttonDraw.Click += new System.EventHandler(this.buttonDraw_Click);
            // 
            // FormPoly
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Blue;
            this.ClientSize = new System.Drawing.Size(555, 200);
            this.Controls.Add(this.buttonDraw);
            this.Controls.Add(this.textBoxCount);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.setY);
            this.Controls.Add(this.setX);
            this.Controls.Add(this.labelXY);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormPoly";
            this.Text = "FormPooly";
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.FormPoly_MouseDown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label3;
        private Button button1;
        private Label label2;
        private Label label1;
        private TextBox setY;
        private TextBox setX;
        private Label labelXY;
        private Button buttonAdd;
        private Label label4;
        private TextBox textBoxCount;
        private Button buttonDraw;
    }
}