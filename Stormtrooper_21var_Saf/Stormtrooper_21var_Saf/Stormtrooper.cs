﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Stormtrooper_21var_Saf
{
    public class Stormtrooper : Plane
    {
        /// <summary>
        /// Дополнительный цвет
        /// </summary>
        public Color DopColor { private set; get; }
        public bool Rockets { private set; get; }
        public bool Window { private set; get; }
        /// Конструктор
        /// </summary>
        /// <param name="maxSpeed">Максимальная скорость</param>
        /// <param name="weight">Вес штурмовика</param>
        /// /// <param name="mainColor">Основной цвет штурмовика</param>
        /// <param name="dopColor">Дополнительный цвет</param>
        public Stormtrooper(int maxSpeed, float weight, Color mainColor, Color dopColor, bool rockets, bool window) :
        base(maxSpeed, weight, mainColor, 85, 110)
        {
            DopColor = dopColor;
            Rockets = rockets;
            Window = window;
        }
        public Stormtrooper(string info) : base(info)
        {
            string[] strs = info.Split(separator);
            if (strs.Length == 6)
            {
                MaxSpeed = Convert.ToInt32(strs[0]);
                Weight = Convert.ToInt32(strs[1]);
                MainColor = Color.FromName(strs[2]);
                DopColor = Color.FromName(strs[3]);
                Rockets = Convert.ToBoolean(strs[4]);
                Window = Convert.ToBoolean(strs[5]);
            }
        }
        public override void DrawTransport(Graphics g)
        {
            Pen pen = new Pen(Color.Black);
            Brush Dop = new SolidBrush(DopColor);
            //ракеты
            if (Rockets)
            {
                g.FillRectangle(Dop, _startPosX + 10, _startPosY + 20, 50, 5);
                g.FillRectangle(Dop, _startPosX + 10, _startPosY + 30, 50, 5);
                g.FillRectangle(Dop, _startPosX + 10, _startPosY + 80, 50, 5);
                g.FillRectangle(Dop, _startPosX + 10, _startPosY + 90, 50, 5);
            }
            if (Window)
            {
                g.DrawEllipse(pen, _startPosX + 15, _startPosY + 51, 8, 8);
                g.FillEllipse(Dop, _startPosX + 15, _startPosY + 51, 8, 8);
            }
            base.DrawTransport(g);
        }
        public void SetDopColor(Color color)
        {
            DopColor = color;
        }
        public override string ToString()
        {
            return $"{base.ToString()}{separator}{DopColor.Name}{separator}{Rockets}{separator}{Window}";
        }
    }
}
