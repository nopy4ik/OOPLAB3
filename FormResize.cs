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
    public partial class FormResize : Form
    {
        private Figure figure;
        private Button btn;
        public FormResize(Figure figure, Button btn)
        {
            InitializeComponent();
            this.figure = figure;
            this.btn = btn;
            if(figure is Ellipse || figure is FLib.Rectangle || figure is Domik)
            {
                labelR.Visible = false;
                setR.Visible = false;
            }
            else if(figure is Circle)
            {
                labelH.Visible = false;
                labelW.Visible = false;
                setH.Visible = false;
                setW.Visible = false;
            }
            else if(figure is Square)
            {
                labelH.Visible = false;
                setH.Visible = false;
                labelR.Visible = false;
                setR.Visible = false;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            btn.Enabled = true;
            SpecClass.isResizeOpen = false;
            Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int w, h, r;
            try
            {
                w = int.Parse(setW.Text);
                h = int.Parse(setH.Text);
                r = int.Parse(setR.Text);
                if (figure is Domik)
                {
                    (figure as Domik).ChangeSizeTo(w, h);
                }
                if (figure is Ellipse)
                {
                    (figure as Ellipse).ChangeSizeTo(w, h);
                }
                if (figure is FLib.Rectangle)
                {
                    (figure as FLib.Rectangle).ChangeSizeTo(w, h);
                }
                if (figure is Circle)
                {
                    (figure as Circle).ChangeRadiusTo(r);
                }
                if (figure is Square)
                {
                    (figure as Square).ChangeSizeTo(w);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void FormResize_MouseDown(object sender, MouseEventArgs e)
        {
            base.Capture = false;
            Message m = Message.Create(base.Handle, 0xa1, new IntPtr(2), IntPtr.Zero);
            this.WndProc(ref m);
        }
    }
}
