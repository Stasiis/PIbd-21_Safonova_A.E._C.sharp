using Baseline.ImTools;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Stormtrooper_21var_Saf
{
    public partial class FormHangar : Form
    {
        private readonly HangarCollection hangarCollection;
        public FormHangar()
        {
            InitializeComponent();
            hangarCollection = new HangarCollection(pictureBoxHangar.Height, pictureBoxHangar.Width); 
            Draw();
        }
        private void ReloadLevels()
        {
            int index = listBoxHangar.SelectedIndex;
            listBoxHangar.Items.Clear();
            listBoxHangar.Items.AddRange(hangarCollection.Keys.ToArray());
            if (listBoxHangar.Items.Count > 0 && (index == -1 || index >= listBoxHangar.Items.Count))
            {
                listBoxHangar.SelectedIndex = 0;
            }
            else if (listBoxHangar.Items.Count > 0 && index > -1 && index < listBoxHangar.Items.Count)
            {
                listBoxHangar.SelectedIndex = index;
            }
        }
        private void Draw()
        {
            if (listBoxHangar.SelectedIndex > -1)
            {
                Bitmap bmp = new Bitmap(pictureBoxHangar.Height, pictureBoxHangar.Width);
                Graphics gr = Graphics.FromImage(bmp);
                hangarCollection[listBoxHangar.SelectedItem.ToString()].Draw(gr);
                pictureBoxHangar.Image = bmp;
            }
        }
        private void buttonAddPlane_Click(object sender, EventArgs e)
        {
            var FormPlaneConfig = new FormPlaneConfig();
            FormPlaneConfig.AddEvent(AddPlane);
            FormPlaneConfig.Show();
        }
        private void AddPlane(Vehicle plane)
        {
            if (plane != null && listBoxHangar.SelectedIndex > -1)
            {
                if (hangarCollection[listBoxHangar.SelectedItem.ToString()] + plane>-1)
                {
                    Draw();
                }
                else
                {
                    MessageBox.Show("Не удалось поставить самолет");
                }
            }
        }
        private void buttonTakePlane_Click(object sender, EventArgs e)
        {
            if (listBoxHangar.SelectedIndex > -1 && maskedTextBox.Text != "")
            {
                var plane = hangarCollection[listBoxHangar.SelectedItem.ToString()] - Convert.ToInt32(maskedTextBox.Text);
                if (plane != null)
                {
                    FormStormtrooper form = new FormStormtrooper();
                    form.SetPlane(plane);
                    form.ShowDialog();
                }
                Draw();
            }
        }
        private void buttonAddHangar_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(textBoxNewLevelName.Text))
            {
                MessageBox.Show("Введите название ангара", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                hangarCollection.AddHangar(textBoxNewLevelName.Text);
                ReloadLevels();
            }
        }
        private void buttonDelHangar_Click(object sender, EventArgs e)
        {
            if (listBoxHangar.SelectedIndex > -1)
            {
                if (MessageBox.Show($"Удалить ангар {listBoxHangar.SelectedItem.ToString()}?", "Удаление", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    hangarCollection.DelHangar(listBoxHangar.SelectedItem.ToString());
                    ReloadLevels();
                }
            }
        }
        private void listBoxHangar_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBoxHangar.SelectedIndex > -1)
            {
                Draw();
            }
        }
        private void сохранитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                if (hangarCollection.SaveData(saveFileDialog.FileName))
                {
                    MessageBox.Show("Сохранение прошло успешно", "Результат", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Не сохранилось", "Результат", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        private void загрузитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                if (hangarCollection.LoadData(openFileDialog.FileName))
                {
                    MessageBox.Show("Загрузили", "Результат", MessageBoxButtons.OK,
                   MessageBoxIcon.Information);
                    ReloadLevels();
                    Draw();
                }
                else
                {
                    MessageBox.Show("Не загрузили", "Результат", MessageBoxButtons.OK,
                   MessageBoxIcon.Error);
                }
            }
        }
    }
}
