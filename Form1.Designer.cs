namespace OOPLAB3
{
    partial class Form1
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.buttonTR = new System.Windows.Forms.Button();
            this.buttonPoly = new System.Windows.Forms.Button();
            this.buttonCF = new System.Windows.Forms.Button();
            this.buttonSQ = new System.Windows.Forms.Button();
            this.buttonCI = new System.Windows.Forms.Button();
            this.buttonRE = new System.Windows.Forms.Button();
            this.buttonEL = new System.Windows.Forms.Button();
            this.buttonClear = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.labelSelect = new System.Windows.Forms.Label();
            this.buttonResize = new System.Windows.Forms.Button();
            this.buttonMove = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.White;
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(552, 529);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.buttonTR);
            this.groupBox1.Controls.Add(this.buttonPoly);
            this.groupBox1.Controls.Add(this.buttonCF);
            this.groupBox1.Controls.Add(this.buttonSQ);
            this.groupBox1.Controls.Add(this.buttonCI);
            this.groupBox1.Controls.Add(this.buttonRE);
            this.groupBox1.Controls.Add(this.buttonEL);
            this.groupBox1.Location = new System.Drawing.Point(570, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(461, 96);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Нарисовать:";
            // 
            // buttonTR
            // 
            this.buttonTR.Location = new System.Drawing.Point(282, 60);
            this.buttonTR.Name = "buttonTR";
            this.buttonTR.Size = new System.Drawing.Size(112, 29);
            this.buttonTR.TabIndex = 6;
            this.buttonTR.Text = "Треугольник";
            this.buttonTR.UseVisualStyleBackColor = true;
            this.buttonTR.Click += new System.EventHandler(this.buttonTR_Click);
            // 
            // buttonPoly
            // 
            this.buttonPoly.Location = new System.Drawing.Point(145, 60);
            this.buttonPoly.Name = "buttonPoly";
            this.buttonPoly.Size = new System.Drawing.Size(131, 29);
            this.buttonPoly.TabIndex = 6;
            this.buttonPoly.Text = "Многоугольник";
            this.buttonPoly.UseVisualStyleBackColor = true;
            this.buttonPoly.Click += new System.EventHandler(this.buttonPoly_Click);
            // 
            // buttonCF
            // 
            this.buttonCF.Location = new System.Drawing.Point(6, 60);
            this.buttonCF.Name = "buttonCF";
            this.buttonCF.Size = new System.Drawing.Size(133, 29);
            this.buttonCF.TabIndex = 5;
            this.buttonCF.Text = "Сложная фигура";
            this.buttonCF.UseVisualStyleBackColor = true;
            this.buttonCF.Click += new System.EventHandler(this.buttonCF_Click);
            // 
            // buttonSQ
            // 
            this.buttonSQ.Location = new System.Drawing.Point(359, 25);
            this.buttonSQ.Name = "buttonSQ";
            this.buttonSQ.Size = new System.Drawing.Size(94, 29);
            this.buttonSQ.TabIndex = 3;
            this.buttonSQ.Text = "Квадрат";
            this.buttonSQ.UseVisualStyleBackColor = true;
            this.buttonSQ.Click += new System.EventHandler(this.buttonSQ_Click);
            // 
            // buttonCI
            // 
            this.buttonCI.Location = new System.Drawing.Point(245, 25);
            this.buttonCI.Name = "buttonCI";
            this.buttonCI.Size = new System.Drawing.Size(108, 29);
            this.buttonCI.TabIndex = 2;
            this.buttonCI.Text = "Окружность";
            this.buttonCI.UseVisualStyleBackColor = true;
            this.buttonCI.Click += new System.EventHandler(this.buttonCI_Click);
            // 
            // buttonRE
            // 
            this.buttonRE.Location = new System.Drawing.Point(106, 25);
            this.buttonRE.Name = "buttonRE";
            this.buttonRE.Size = new System.Drawing.Size(133, 29);
            this.buttonRE.TabIndex = 1;
            this.buttonRE.Text = "Прямоугольник";
            this.buttonRE.UseVisualStyleBackColor = true;
            this.buttonRE.Click += new System.EventHandler(this.buttonRE_Click);
            // 
            // buttonEL
            // 
            this.buttonEL.Location = new System.Drawing.Point(6, 25);
            this.buttonEL.Name = "buttonEL";
            this.buttonEL.Size = new System.Drawing.Size(94, 29);
            this.buttonEL.TabIndex = 0;
            this.buttonEL.Text = "Эллипс";
            this.buttonEL.UseVisualStyleBackColor = true;
            this.buttonEL.Click += new System.EventHandler(this.buttonEL_Click);
            // 
            // buttonClear
            // 
            this.buttonClear.Location = new System.Drawing.Point(1037, 54);
            this.buttonClear.Name = "buttonClear";
            this.buttonClear.Size = new System.Drawing.Size(114, 29);
            this.buttonClear.TabIndex = 2;
            this.buttonClear.Text = "Очистить все";
            this.buttonClear.UseVisualStyleBackColor = true;
            this.buttonClear.Click += new System.EventHandler(this.buttonClear_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(576, 134);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(151, 28);
            this.comboBox1.TabIndex = 3;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // labelSelect
            // 
            this.labelSelect.AutoSize = true;
            this.labelSelect.Location = new System.Drawing.Point(576, 111);
            this.labelSelect.Name = "labelSelect";
            this.labelSelect.Size = new System.Drawing.Size(121, 20);
            this.labelSelect.TabIndex = 4;
            this.labelSelect.Text = "Выбрать фигуру";
            // 
            // buttonResize
            // 
            this.buttonResize.Enabled = false;
            this.buttonResize.Location = new System.Drawing.Point(576, 168);
            this.buttonResize.Name = "buttonResize";
            this.buttonResize.Size = new System.Drawing.Size(151, 29);
            this.buttonResize.TabIndex = 5;
            this.buttonResize.Text = "Изменить размер";
            this.buttonResize.UseVisualStyleBackColor = true;
            this.buttonResize.Click += new System.EventHandler(this.buttonChange_Click);
            // 
            // buttonMove
            // 
            this.buttonMove.Enabled = false;
            this.buttonMove.Location = new System.Drawing.Point(733, 168);
            this.buttonMove.Name = "buttonMove";
            this.buttonMove.Size = new System.Drawing.Size(113, 29);
            this.buttonMove.TabIndex = 6;
            this.buttonMove.Text = "Переместить";
            this.buttonMove.UseVisualStyleBackColor = true;
            this.buttonMove.Click += new System.EventHandler(this.buttonMove_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1182, 553);
            this.Controls.Add(this.buttonMove);
            this.Controls.Add(this.buttonResize);
            this.Controls.Add(this.labelSelect);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.buttonClear);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private PictureBox pictureBox1;
        private GroupBox groupBox1;
        private Button buttonEL;
        private Button buttonSQ;
        private Button buttonCI;
        private Button buttonRE;
        private Button buttonClear;
        private ComboBox comboBox1;
        private Button buttonCF;
        private Label labelSelect;
        private Button buttonResize;
        private Button buttonTR;
        private Button buttonPoly;
        private Button buttonMove;
    }
}