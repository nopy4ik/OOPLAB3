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
    public partial class FormPoly : Form
    {
        private int count = 0;
        private int i = 0;
        private Point[] points;
        private PictureBox pb;
        private Bitmap bmp;
        private Button btn;
        private ComboBox box;
        public FormPoly(PictureBox pb, Bitmap bmp, Button btn, ComboBox box)
        {
            InitializeComponent();
            this.pb = pb;
            this.bmp = bmp;
            this.btn = btn;
            this.box = box;
        }
        private void textBoxCount_KeyDown(object sender, KeyEventArgs e)
        {
            int c;
            if(e.KeyCode == Keys.Enter)
            {
                try
                {
                    c = int.Parse(textBoxCount.Text);
                    textBoxCount.Enabled = false;
                    if (c <= 1) throw new Exception("Ошибка кол-ва вершин");
                    count = c;
                    points = new Point[count];
                }
                catch(Exception ex)
                {
                    textBoxCount.Enabled = true;
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            int x, y;
            if (i <= count)
            {
                try
                {
                    x = int.Parse(setX.Text);
                    y = int.Parse(setY.Text);
                    if (((y < 0) || (y > pb.Height) || (x < 0) || (x > pb.Width))) throw new Exception("Ошибка границ");
                    points[i].X = x;
                    points[i].Y = y;
                    i++;
                    labelXY.Text = $"Введите координаты {i + 1}-й точки: ";
                    if(i >= count)
                    {
                        buttonAdd.Enabled = false;
                        buttonDraw.Enabled = true;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    i--;
                    labelXY.Text = $"Введите координаты {i + 1}-й точки: ";
                }
            }
            else
            {
                buttonAdd.Enabled = false;
                buttonDraw.Enabled = true;
            }
        }

        private void buttonDraw_Click(object sender, EventArgs e)
        {
            Poly poly = new Poly(pb, bmp, points);
            poly.Draw(poly.pen);
            box.Items.Add(poly.Name);
            buttonDraw.Enabled = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            btn.Enabled = true;
            Close();
        }

        private void FormPoly_MouseDown(object sender, MouseEventArgs e)
        {
            base.Capture = false;
            Message m = Message.Create(base.Handle, 0xa1, new IntPtr(2), IntPtr.Zero);
            this.WndProc(ref m);
        }
    }
}
