using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsPlanes;

namespace Stormtrooper_21var_Saf
{
    public partial class FormPlaneConfig : Form
    {
        Vehicle plane = null;
        private Action<Vehicle> eventAddPlane;
        public FormPlaneConfig()
        {
            InitializeComponent();

            panelRedColor.MouseDown += panelColor_MouseDown;
            panelPinkColor.MouseDown += panelColor_MouseDown;
            panelBlueColor.MouseDown += panelColor_MouseDown;
            panelPurpleColor.MouseDown += panelColor_MouseDown;
            panelBlackColor.MouseDown += panelColor_MouseDown;
            panelWhiteColor.MouseDown += panelColor_MouseDown;
            panelYellowColor.MouseDown += panelColor_MouseDown;
            panelGreenColor.MouseDown += panelColor_MouseDown;

            buttonCancel.Click += (object sender, EventArgs e) => { Close(); };
        }
        private void DrawPlane()
        {
            if (plane != null)
            {
                Bitmap bmp = new Bitmap(pictureBoxConfig.Width, pictureBoxConfig.Height);
                Graphics gr = Graphics.FromImage(bmp);
                plane.SetPosition(5, 5, pictureBoxConfig.Width, pictureBoxConfig.Height);
                plane.DrawTransport(gr);
                pictureBoxConfig.Image = bmp;
            }
        }
        public void AddEvent(Action<Vehicle> ev)
        {
            if (eventAddPlane == null)
            {
                eventAddPlane = new Action<Vehicle>(ev);
            }
            else
            {
                eventAddPlane += ev;
            }
        }
        private void labelPlane_MouseDown(object sender, MouseEventArgs e)
        {
            labelPlane.DoDragDrop(labelPlane.Text, DragDropEffects.Move | DragDropEffects.Copy);
        }
        private void labelStormtrooper_MouseDown(object sender, MouseEventArgs e)
        {
            labelStormtrooper.DoDragDrop(labelStormtrooper.Text, DragDropEffects.Move | DragDropEffects.Copy);
        }
        private void panelConfig_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.Text))
            {
                e.Effect = DragDropEffects.Copy;
            }
            else
            {
                e.Effect = DragDropEffects.None;
            }
        }
        private void panelConfig_DragDrop(object sender, DragEventArgs e)
        {
            switch (e.Data.GetData(DataFormats.Text).ToString())
            {
                case "Обычный самолет":
                    plane = new Plane((int)numericUpDownMaxSpeed.Value, (int)numericUpDownWeigth.Value, Color.White);
                    break;
                case "Штурмовик":
                    plane = new Stormtrooper((int)numericUpDownMaxSpeed.Value, (int)numericUpDownWeigth.Value, Color.Pink, Color.Pink, checkBoxRockets.Checked, checkBoxWindow.Checked);
                    break;
            }
            DrawPlane();
        }
        private void panelColor_MouseDown(object sender, MouseEventArgs e)
        {
            (sender as Control).DoDragDrop((Color)(sender as Control).BackColor, DragDropEffects.Move | DragDropEffects.Copy);
        }
        private void labelBaseColor_DragDrop(object sender, DragEventArgs e)
        {
            if (plane != null)
            {
                plane.SetMainColor((Color)e.Data.GetData(typeof(Color)));
                DrawPlane();
            }
        }
        private void labelBaseColor_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(typeof(Color)))
            {
                e.Effect = DragDropEffects.Copy;
            }
            else
            {
                e.Effect = DragDropEffects.None;
            }
        }
        private void labelDopColor_DragDrop(object sender, DragEventArgs e)
        {
            if (plane != null)
            {
                if (plane is Stormtrooper)
                {
                    (plane as Stormtrooper).SetDopColor((Color)e.Data.GetData(typeof(Color)));
                    DrawPlane();
                }
            }
        }
        private void buttonOk_Click(object sender, EventArgs e)
        {
            eventAddPlane?.Invoke(plane);
            Close();
        }
    }
}
