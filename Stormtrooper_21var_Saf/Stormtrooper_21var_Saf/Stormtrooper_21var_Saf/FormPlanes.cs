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
    public partial class FormPlanes : System.Windows.Forms.Form
    {
        private ITransport plane;
        public FormPlanes()
        {
            InitializeComponent();
        }
        private void Draw()
        {
            Bitmap bmp = new Bitmap(pictureBoxStormtroopers.Width, pictureBoxStormtroopers.Height);
            Graphics gr = Graphics.FromImage(bmp);
            plane.DrawTransport(gr);
            pictureBoxStormtroopers.Image = bmp;
        }
        private void buttonMove_Click(object sender, EventArgs e)
        {
            string name = (sender as Button).Name;
            switch (name)
            {
                case "buttonUp":
                    plane.MoveTransport(Direction.Up);
                    break;
                case "buttonDown":
                    plane.MoveTransport(Direction.Down);
                    break;
                case "buttonLeft":
                    plane.MoveTransport(Direction.Left);
                    break;
                case "buttonRight":
                    plane.MoveTransport(Direction.Right);
                    break;
            }
            Draw();
        }
        private void buttonCreatePlane_Click(object sender, EventArgs e)
        {
            Random rnd = new Random();
            plane = new Plane(rnd.Next(100, 300), rnd.Next(1000, 2000), Color.Black);
            plane.SetPosition(rnd.Next(60, 150), rnd.Next(60, 150), pictureBoxStormtroopers.Width,
           pictureBoxStormtroopers.Height);
            Draw();
        }
        private void buttonCreateStormtrooper_Click(object sender, EventArgs e)
        {
            Random rnd = new Random();
            plane = new Stormtrooper(rnd.Next(100, 300), rnd.Next(1000, 2000), Color.Black, Color.Red, true, true);
            plane.SetPosition(rnd.Next(60, 150), rnd.Next(60, 150), pictureBoxStormtroopers.Width,
           pictureBoxStormtroopers.Height);
            Draw();
        }
    }
}
