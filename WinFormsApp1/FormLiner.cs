using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WinFormsLiner;

namespace WinFormsApp1
{
    public partial class FormLiner : Form
    {
        private ITransport _liner;
        public FormLiner()
        {
            InitializeComponent();
        }

        public void SetLiner(ITransport liner)
        {
            _liner = liner;
            Draw();
        }

        private void Draw()
        {
            Bitmap bmp = new Bitmap(pictureBoxLiners.Width,
            pictureBoxLiners.Height);
            Graphics gr = Graphics.FromImage(bmp);
            _liner?.DrawTransport(gr);
            pictureBoxLiners.Image = bmp;
        }

        private void ButtonMove_Click(object sender, EventArgs e)
        {
            string name = (sender as Button).Name;
            switch (name)
            {
                case "buttonUp":
                    _liner?.MoveTransport(Direction.Up);
                    break;
                case "buttonDown":
                    _liner?.MoveTransport(Direction.Down);
                    break;
                case "buttonLeft":
                    _liner?.MoveTransport(Direction.Left);
                    break;
                case "buttonRight":
                    _liner?.MoveTransport(Direction.Right);
                    break;
            }
            Draw();
        }

    }
}
