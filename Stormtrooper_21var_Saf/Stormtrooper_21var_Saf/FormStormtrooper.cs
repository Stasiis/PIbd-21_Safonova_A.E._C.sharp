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
    public partial class FormStormtrooper : Form
    {
        private StormTrooper ST;
        public FormStormtrooper()
        {
            InitializeComponent();
        }
        /// <summary>
        /// Метод отрисовки штурмовика
        /// </summary>
        private void Draw()
        {
            Bitmap bmp = new Bitmap(pictureBoxStormtroopers.Width, pictureBoxStormtroopers.Height);
            Graphics gr = Graphics.FromImage(bmp);
            ST.DrawTransport(gr);
            pictureBoxStormtroopers.Image = bmp;
        }
        /// <summary>
        /// Обработка нажатия кнопки "Создать"
        /// </summary>
        /// /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonCreate_Click(object sender, EventArgs e)
        {
            Random rnd = new Random();
            ST = new StormTrooper();
            ST.Init(rnd.Next(100, 300), rnd.Next(1000, 2000), Color.Black, Color.Red, true, true); 
            ST.SetPosition(rnd.Next(50, 150), rnd.Next(100, 150), pictureBoxStormtroopers.Width, pictureBoxStormtroopers.Height);
            Draw();
        }
        /// <summary>
        /// Обработка нажатия кнопок управления
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonMove_Click(object sender, EventArgs e)
        {
            //получаем имя кнопки
            string name = (sender as Button).Name;
            switch (name)
            {
                case "buttonUp":
                    ST.MoveTransport(Direction.Up);
                    break;
                case "buttonDown":
                    ST.MoveTransport(Direction.Down);
                    break;
                case "buttonLeft":
                    ST.MoveTransport(Direction.Left);
                    break;
                case "buttonRight":
                    ST.MoveTransport(Direction.Right);
                    break;
            }
            Draw();
        }
    }
}
