using Baseline.ImTools;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using NLog;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Stormtrooper_21var_Saf
{
    public partial class FormHangar : Form
    {
        private readonly HangarCollection hangarCollection;
        private readonly Logger logger;
        public FormHangar()
        {
            InitializeComponent();
            hangarCollection = new HangarCollection(pictureBoxHangar.Height, pictureBoxHangar.Width); 
            logger = LogManager.GetCurrentClassLogger();
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
                 try
                {
                    if (hangarCollection[listBoxHangar.SelectedItem.ToString()] + plane > -1)
                    {
                        Draw();
                        logger.Info($"Добавлен самолет {plane}");
                    }
                    else
                    {
                        MessageBox.Show("Не удалось поставить самолет");
                    }
                }
                catch( HangarOverflowException ex)
                {
                    logger.Warn($"Ангар переполнен");
                    MessageBox.Show(ex.Message, "Переполнение", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Неизвестная ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        private void buttonTakePlane_Click(object sender, EventArgs e)
        {
            if (listBoxHangar.SelectedIndex > -1 && maskedTextBox.Text != "")
            {
                 try
                {
                    var plane = hangarCollection[listBoxHangar.SelectedItem.ToString()] - Convert.ToInt32(maskedTextBox.Text);
                    if (plane != null)
                    {
                        FormStormtrooper form = new FormStormtrooper();
                        form.SetPlane(plane);
                        form.ShowDialog();
                        logger.Info($"Изъят самолет {plane} с места {maskedTextBox.Text}");
                        Draw();
                    }
                }
                catch(HangarNotFoundException ex)
                {
                    MessageBox.Show(ex.Message, "Не найдено", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                catch(Exception ex)
                {
                    MessageBox.Show(ex.Message, "Неизвестная ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        private void buttonAddHangar_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(textBoxNewLevelName.Text))
            {
                MessageBox.Show("Введите название ангара", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else
            {
                logger.Info($"Добавили ангар {textBoxNewLevelName.Text}");
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
                    logger.Info($"Удалить парковку {listBoxHangar.SelectedItem.ToString()}");
                    hangarCollection.DelHangar(listBoxHangar.SelectedItem.ToString());
                    ReloadLevels();
                }
            }
        }
        private void listBoxHangar_SelectedIndexChanged(object sender, EventArgs e)
        {
            logger.Info($"Перешли на парковку {listBoxHangar.SelectedItem.ToString()}");
            Draw();
        }
        private void сохранитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    hangarCollection.SaveData(saveFileDialog.FileName);
                    MessageBox.Show("Сохранение прошло успешно", "Результат", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    logger.Info("Сохранено в файл " + saveFileDialog.FileName);
                }
                catch (Exception ex)
                {
                    logger.Warn($"Неизвестная ошибка при сохранении");
                    MessageBox.Show(ex.Message, "Неизвестная ошибка при сохранении", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        private void загрузитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    hangarCollection.LoadData(openFileDialog.FileName);
                    MessageBox.Show("Загрузили", "Результат", MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
                    logger.Info("Загружено из файла " + openFileDialog.FileName);
                    ReloadLevels();
                    Draw();
                }
                catch (HangarOccupiedPlaceException ex)
                {
                    logger.Warn($"Занятое место");
                    MessageBox.Show(ex.Message, "Занятое место", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                catch (Exception ex)
                {
                    logger.Warn($"Неизвестная ошибка при сохранении");
                    MessageBox.Show(ex.Message, "Неизвестная ошибка при сохранении", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        private void buttonSort_Click(object sender, EventArgs e)
        {
            if (listBoxParking.SelectedIndex > -1)
            {
                parkingCollection[listBoxParking.SelectedItem.ToString()].Sort();
                Draw();
                logger.Info("Сортировка уровней");
            }
        }
    }
}
