using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Stormtrooper_21var_Saf
{
    //отрисовка самолета
    public class Plane : Vehicle
    {
        /// <summary>
        /// Ширина отрисовки самолета
        /// </summary>
        protected readonly int StormtrooperWidth = 85;
        /// <summary>
        /// Высота отрисовки самолета
        /// </summary>
        protected readonly int StormtrooperHeight = 110;
        protected readonly char separator = ';';
        /// <summary>
        /// Конструктор
        /// </summary>
        /// <param name="maxSpeed">Максимальная скорость</param>
        /// <param name="weight">Вес самолета</param>
        /// <param name="mainColor">Основной цвет</param>
        public Plane(int maxSpeed, float weight, Color mainColor)
        {
            MaxSpeed = maxSpeed;
            Weight = weight;
            MainColor = mainColor;
        }
        public Plane(string info)
        {
            string[] strs = info.Split(separator);
            if (strs.Length == 3)
            {
                MaxSpeed = Convert.ToInt32(strs[0]);
                Weight = Convert.ToInt32(strs[1]);
                MainColor = Color.FromName(strs[2]);
            }
        }
        /// <summary>
        /// Конструкторс изменением размеров самолетов
        /// </summary>
        /// <param name="maxSpeed">Максимальная скорость</param>
        /// <param name="weight">Вес самолета</param>
        /// <param name="mainColor">Основной цвет</param>
        /// <param name="planeWidth">Ширина отрисовки самолета</param>
        /// <param name="planeHeight">Высота отрисовки самолета</param>
        protected Plane(int maxSpeed, float weight, Color mainColor, int planeWidth, int planeHeight)
        {
            MaxSpeed = maxSpeed;
            Weight = weight;
            MainColor = mainColor;
            this.StormtrooperWidth = planeWidth;
            this.StormtrooperHeight = planeHeight;
        }
        public void MoveTransport(Direction direction)
        {
            float step = MaxSpeed * 100 / Weight;
            switch (direction)
            {
                // вправо
                case Direction.Right:
                    if (_startPosX + step < _pictureWidth - StormtrooperWidth)
                    {
                        _startPosX += step;
                    }
                    break;
                //влево
                case Direction.Left:
                    if (_startPosX - step > 0)
                    {
                        _startPosX -= step;
                    }
                    break;
                //вверх
                case Direction.Up:
                    if (_startPosY - step > 0)
                    {
                        _startPosY -= step;
                    }
                    break;
                //вниз
                case Direction.Down:
                    if (_startPosY + step < _pictureHeight - StormtrooperHeight)
                    {
                        _startPosY += step;
                    }
                    break;
            }
        }
        /// <summary>
        /// Отрисовка самолета
        /// </summary>
        /// <param name="g"></param>
        public void DrawTransport(Graphics g)
        {
            Pen pen = new Pen(Color.Black);
            //звезды - первая сверху, вторая снизу
            PointF point1 = new PointF(_startPosX + 33, _startPosY + 30);
            PointF point2 = new PointF(_startPosX + 29, _startPosY + 27);
            PointF point3 = new PointF(_startPosX + 31, _startPosY + 32);
            PointF point4 = new PointF(_startPosX + 27, _startPosY + 35);
            PointF point5 = new PointF(_startPosX + 32, _startPosY + 35);
            PointF point6 = new PointF(_startPosX + 33, _startPosY + 39);
            PointF point7 = new PointF(_startPosX + 35, _startPosY + 35);
            PointF point8 = new PointF(_startPosX + 40, _startPosY + 35);
            PointF point9 = new PointF(_startPosX + 36, _startPosY + 32);
            PointF point10 = new PointF(_startPosX + 37, _startPosY + 27);
            PointF[] StarPointsUp =
            {
                 point1,
                 point2,
                 point3,
                 point4,
                 point5,
                 point6,
                 point7,
                 point8,
                 point9,
                 point10
            };
            PointF point11 = new PointF(_startPosX + 33, _startPosY + 70);
            PointF point12 = new PointF(_startPosX + 29, _startPosY + 67);
            PointF point13 = new PointF(_startPosX + 31, _startPosY + 72);
            PointF point14 = new PointF(_startPosX + 27, _startPosY + 75);
            PointF point15 = new PointF(_startPosX + 32, _startPosY + 75);
            PointF point16 = new PointF(_startPosX + 33, _startPosY + 79);
            PointF point17 = new PointF(_startPosX + 35, _startPosY + 75);
            PointF point18 = new PointF(_startPosX + 40, _startPosY + 75);
            PointF point19 = new PointF(_startPosX + 36, _startPosY + 72);
            PointF point20 = new PointF(_startPosX + 37, _startPosY + 67);
            PointF[] StarPointsDown =
            {
                 point11,
                 point12,
                 point13,
                 point14,
                 point15,
                 point16,
                 point17,
                 point18,
                 point19,
                 point20
            };
            g.DrawPolygon(pen, StarPointsUp);
            g.DrawPolygon(pen, StarPointsDown);
            //доп части
            //отрисуем "тело" самолета, все основание
            g.DrawRectangle(pen, _startPosX + 10, _startPosY + 50, 75, 10);
            g.DrawLine(pen, _startPosX + 25, _startPosY + 50, _startPosX+25, _startPosY + 60);
            //нос
            g.DrawLine(pen, _startPosX + 10, _startPosY + 50, _startPosX, _startPosY + 55);
            g.DrawLine(pen, _startPosX, _startPosY + 55, _startPosX + 10, _startPosY + 60);
            //крыло вверх
            g.DrawLine(pen, _startPosX + 25, _startPosY + 50, _startPosX + 25, _startPosY);
            g.DrawLine(pen, _startPosX + 25, _startPosY, _startPosX + 40, _startPosY);
            g.DrawLine(pen, _startPosX + 40, _startPosY, _startPosX + 45, _startPosY + 50);
            //крыло низ
            g.DrawLine(pen, _startPosX + 25, _startPosY + 60, _startPosX + 25, _startPosY + 110);
            g.DrawLine(pen, _startPosX + 25, _startPosY + 110, _startPosX + 40, _startPosY + 110);
            g.DrawLine(pen, _startPosX + 40, _startPosY + 110, _startPosX + 45, _startPosY + 60);
            //хвост вверх
            g.DrawLine(pen, _startPosX + 70, _startPosY + 50, _startPosX + 70, _startPosY + 40);
            g.DrawLine(pen, _startPosX + 70, _startPosY + 40, _startPosX + 85, _startPosY + 30);
            g.DrawLine(pen, _startPosX + 85, _startPosY + 30, _startPosX + 85, _startPosY + 50);
            //хвост низ
            g.DrawLine(pen, _startPosX + 70, _startPosY + 60, _startPosX + 70, _startPosY + 70);
            g.DrawLine(pen, _startPosX + 70, _startPosY + 70, _startPosX + 85, _startPosY + 80);
            g.DrawLine(pen, _startPosX + 85, _startPosY + 80, _startPosX + 85, _startPosY + 60);
        }
    }
}
