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

        private void Draw()
        {
            Bitmap bmp = new Bitmap(pictureBoxLiners.Width,
            pictureBoxLiners.Height);
            Graphics gr = Graphics.FromImage(bmp);
            _liner?.DrawTransport(gr);
            pictureBoxLiners.Image = bmp;
        }

        private void CreateLiner(bool isBase)
        {
            Random rnd = new Random();
            _liner = isBase ? new Liner(rnd.Next(100, 300), rnd.Next(1000, 2000), Color.Blue) : new PremiumLiner(rnd.Next(100, 300), rnd.Next(1000, 2000), Color.Blue, Color.Yellow, true);
            _liner.SetPosition(rnd.Next(10, 100), rnd.Next(10, 100), pictureBoxLiners.Width, pictureBoxLiners.Height);
            Draw();
        }

        private void ButtonCreateLinerClick(object sender, EventArgs e)
        {
            CreateLiner(true);
        }

        private void ButtonCreatePremiumLinerClick(object sender, EventArgs e)
        {
            CreateLiner(false);
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
