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
    public partial class FormRect : Form
    {
        private PictureBox pb;
        private Bitmap bmp;
        private Button btn;
        private ComboBox box;
        public FormRect(PictureBox pb, Bitmap bmp, Button btn, ComboBox box)
        {
            InitializeComponent();
            this.pb = pb;
            this.bmp = bmp;
            this.btn = btn;
            this.box = box;
        }

        private void BDraw_Click(object sender, EventArgs e)
        {
            int x = 0, y = 0, w = 0, h = 0;
            try
            {
                x = int.Parse(setX.Text);
                y = int.Parse(setY.Text);
                w = int.Parse(setW.Text);
                h = int.Parse(setH.Text);
                if (IsInBounds(x, y, w, h))
                {
                    FLib.Rectangle rectangle = new FLib.Rectangle(x, y, w, h, pb, bmp);
                    rectangle.Draw(rectangle.pen);
                    box.Items.Add(rectangle.Name);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private bool IsInBounds(int x, int y, int w, int h)
        {
            if ((y < 0) || (y + h > pb.Height) || (x < 0) || (x + w > pb.Width))
            {
                throw new Exception("Нарушены границы или что-то не так");
            }
            else return true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            btn.Enabled = true;
            Close();
        }

        private void FormRect_MouseDown(object sender, MouseEventArgs e)
        {
            base.Capture = false;
            Message m = Message.Create(base.Handle, 0xa1, new IntPtr(2), IntPtr.Zero);
            this.WndProc(ref m);
        }
    }
}
