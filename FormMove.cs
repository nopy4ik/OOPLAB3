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
    public partial class FormMove : Form
    {
        private Figure figure;
        private Button btn;
        public FormMove(Figure figure, Button btn)
        {
            InitializeComponent();
            this.figure = figure;
            this.btn = btn;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int x, y;
            try
            {
                x = int.Parse(setX.Text);
                y = int.Parse(setY.Text);
                if(figure is Domik)
                {
                    (figure as Domik).MoveDom(x, y);
                }
                if(figure is Poly)
                {
                    (figure as Poly).AddCord(x, y);
                }
                if(figure is Triangle)
                {
                    (figure as Triangle).AddCord(x, y);
                }
                else
                {
                    figure.MoveTo(x, y);
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            btn.Enabled = true;
            SpecClass.isMoveOpen = false;
            Close();
        }

        private void FormMove_MouseDown(object sender, MouseEventArgs e)
        {
            base.Capture = false;
            Message m = Message.Create(base.Handle, 0xa1, new IntPtr(2), IntPtr.Zero);
            this.WndProc(ref m);
        }
    }
}
