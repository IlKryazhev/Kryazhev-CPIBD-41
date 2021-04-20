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

        private readonly PierCollection _pierCollection;
        public FormPier()
        {
            InitializeComponent();

            _pierCollection = new PierCollection(pictureBoxPier.Width, pictureBoxPier.Height);

            pier = new Pier<ITransport>(pictureBoxPier.Width, pictureBoxPier.Height);
            Draw();
        }

        private void ReloadLevels()
        {
            int index = listBoxPiers.SelectedIndex;

            listBoxPiers.Items.Clear();
            for (int i = 0; i < _pierCollection.Keys.Count; i++)
            {
                listBoxPiers.Items.Add(_pierCollection.Keys[i]);
            }
            if (listBoxPiers.Items.Count > 0 && (index == -1 || index >=
                listBoxPiers.Items.Count))
            {
                listBoxPiers.SelectedIndex = 0;
            }
            else if (listBoxPiers.Items.Count > 0 && index > -1 && index <
            listBoxPiers.Items.Count)
            {
                listBoxPiers.SelectedIndex = index;
            }

        }

        private void Draw()
        {
            if (listBoxPiers.SelectedIndex > -1)
            {
                Bitmap bmp = new Bitmap(pictureBoxPier.Width,
                pictureBoxPier.Height);
                Graphics gr = Graphics.FromImage(bmp);
                _pierCollection[listBoxPiers.SelectedItem.ToString()].Draw(gr);
                pictureBoxPier.Image = bmp;
            }
        }

        private void buttonAddPier_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBoxNewLevelName.Text))
            {
                MessageBox.Show("Введите название парковки", "Ошибка",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            _pierCollection.AddPier(textBoxNewLevelName.Text);
            ReloadLevels();
        }

        private void buttonDelPier_Click(object sender, EventArgs e)
        {
            if (listBoxPiers.SelectedIndex > -1)
            {
                if (MessageBox.Show($"Удалить парковку { listBoxPiers.SelectedItem}?", "Удаление", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
{
                    _pierCollection.DelPier(listBoxPiers.SelectedItem.ToString());
                    ReloadLevels();
                }
            }

        }

        private void buttonSetLiner_Click(object sender, EventArgs e)
        {
            if (listBoxPiers.SelectedIndex > -1)
            {
                ColorDialog dialog = new ColorDialog();
                if (dialog.ShowDialog() == DialogResult.OK)
                {
                    AddToPier(new Liner(100, 1000, dialog.Color));
                }
            }
        }

        private void buttonSetPremiumLiner_Click(object sender, EventArgs e)
        {
            if (listBoxPiers.SelectedIndex > -1)
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
        }

        private void buttonPickUp_Click(object sender, EventArgs e)
        {
            if (listBoxPiers.SelectedIndex > -1 && maskedTextBox.Text !="")
            {
                var liner = _pierCollection[listBoxPiers.SelectedItem.ToString()] - Convert.ToInt32(maskedTextBox.Text);
                if (liner != null)
                {
                    FormLiner form = new FormLiner();
                    form.SetLiner(liner);
                    form.ShowDialog();
                }
                Draw();
            }
        }

        private void ListBoxPiers_SelectedIndexChanged(object sender, EventArgs e) => Draw();

        private void AddToPier(Liner liner)
        {
            if (listBoxPiers.SelectedIndex > -1)
            {
                if (_pierCollection[listBoxPiers.SelectedItem.ToString()] + liner)
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
}
