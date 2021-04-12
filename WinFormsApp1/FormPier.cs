using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WinFormsApp1;

namespace WinFormsLiner
{
    public partial class FormPier : Form
    {

        private readonly Pier<ITransport> pier;
        public FormPier()
        {
            InitializeComponent();

            pier = new Pier<ITransport>(pictureBoxPier.Width, pictureBoxPier.Height);
            Draw();
        }

        private void Draw()
        {
            Bitmap bmp = new Bitmap(pictureBoxPier.Width,
                pictureBoxPier.Height);
            Graphics gr = Graphics.FromImage(bmp);
            pier.Draw(gr);
            pictureBoxPier.Image = bmp;
        }

        private void buttonSetLiner_Click(object sender, EventArgs e)
        {
            ColorDialog dialog = new ColorDialog();
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                AddToPier(new Liner(100, 1000, dialog.Color));
            }

        }

        private void buttonSetPremiumLiner_Click(object sender, EventArgs e)
        {
            ColorDialog dialog = new ColorDialog();
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                ColorDialog dialogDop = new ColorDialog();
                if (dialogDop.ShowDialog() == DialogResult.OK)
                {
                    AddToPier(new PremiumLiner(100, 1000, dialog.Color,
                    dialogDop.Color, true));
                }
            }

        }

        private void buttonPickUp_Click(object sender, EventArgs e)
        {
            if (maskedTextBox.Text != "")
            {
                var liner = pier - Convert.ToInt32(maskedTextBox.Text);
                if (liner != null)
                {
                    FormLiner form = new FormLiner();
                    form.SetLiner(liner);
                    form.ShowDialog();
                }
                Draw();
            }
        }

        private void AddToPier(Liner liner)
        {
            if (pier + liner)
            {
                Draw();
            }
            else
            {
                MessageBox.Show("Парковка переполнена");
            }
        }
    }
}
