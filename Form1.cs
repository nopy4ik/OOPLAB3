global using FLib;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OOPLAB3
{
    public partial class Form1 : Form
    {
        private Bitmap bmp;
        private int selectedIndex = int.MaxValue;
        public Form1()
        {
            InitializeComponent();
            bmp = new Bitmap(pictureBox1.ClientSize.Width, pictureBox1.ClientSize.Height);
        }

        private void buttonRE_Click(object sender, EventArgs e)
        {
            FormRect re = new FormRect(pictureBox1, bmp, buttonRE, comboBox1);
            re.Show();
            buttonRE.Enabled = false;
        }

        private void buttonCI_Click(object sender, EventArgs e)
        {
            FormCircle ci = new FormCircle(pictureBox1, bmp, buttonCI, comboBox1);
            ci.Show();
            buttonCI.Enabled = false;
        }

        private void buttonSQ_Click(object sender, EventArgs e)
        {
            FormSquare sq = new FormSquare(pictureBox1, bmp, buttonSQ, comboBox1);
            sq.Show();
            buttonSQ.Enabled = false;
        }

        private void buttonChange_Click(object sender, EventArgs e)
        {
            if (Flist.figures[comboBox1.SelectedIndex] is Triangle || Flist.figures[comboBox1.SelectedIndex] is Poly)
            {
                MessageBox.Show("Многоугольник и треугольник нельзя изменить");
            }
            else
            {
                FormResize resize = new FormResize(Flist.figures[comboBox1.SelectedIndex], buttonResize);
                resize.Show();
                buttonResize.Enabled = false;
                SpecClass.isResizeOpen = true;
            }
        }

        private void buttonEL_Click(object sender, EventArgs e)
        {
            FormEllipse el = new FormEllipse(pictureBox1, bmp, buttonEL, comboBox1);
            el.Show();
            buttonEL.Enabled = false;
        }

        private void buttonPoly_Click(object sender, EventArgs e)
        {
            FormPoly poly = new FormPoly(pictureBox1, bmp, buttonPoly, comboBox1);
            poly.Show();
            buttonPoly.Enabled = false;
        }

        private void buttonTR_Click(object sender, EventArgs e)
        {
            FormTriangle tri = new FormTriangle(pictureBox1, bmp, buttonTR, comboBox1);
            tri.Show();
            buttonTR.Enabled = false;
        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            Counters.Reset();
            Flist.figures.Clear();
            Graphics g = Graphics.FromImage(bmp);
            g.Clear(Color.White);
            pictureBox1.Image = bmp;
            comboBox1.Items.Clear();
        }

        private void buttonMove_Click(object sender, EventArgs e)
        {
            FormMove move = new FormMove(Flist.figures[comboBox1.SelectedIndex], buttonMove);
            move.Show();
            buttonMove.Enabled = false;
            SpecClass.isMoveOpen = true;
        }

        private void buttonCF_Click(object sender, EventArgs e)
        {
            FormComFig dom = new FormComFig(pictureBox1, bmp, buttonCF, comboBox1);
            dom.Show();
            buttonCF.Enabled = false;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(comboBox1.Items.Count > 0 && !SpecClass.isMoveOpen && !SpecClass.isResizeOpen)
            {
                selectedIndex = comboBox1.SelectedIndex;
                Figure.Select(Flist.figures[comboBox1.SelectedIndex]);
                buttonMove.Enabled = true;
                buttonResize.Enabled = true;
            }
            else if(comboBox1.Items.Count > 0 && !SpecClass.isResizeOpen)
            {
                selectedIndex = comboBox1.SelectedIndex;
                buttonMove.Enabled = false;
                buttonResize.Enabled = true;
            }
            else if(comboBox1.Items.Count > 0 && !SpecClass.isMoveOpen)
            {
                selectedIndex = comboBox1.SelectedIndex;
                buttonMove.Enabled = true;
                buttonResize.Enabled = false;
            }
            else
            {
                selectedIndex = comboBox1.SelectedIndex;
                buttonMove.Enabled = false;
                buttonResize.Enabled = false;
            }
        }
    }
}
