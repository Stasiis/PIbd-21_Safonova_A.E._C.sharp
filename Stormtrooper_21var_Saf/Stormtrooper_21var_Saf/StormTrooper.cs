using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Stormtrooper_21var_Saf
{
    //отрисовка штурмовика
    class StormTrooper
    {
        /// <summary>
        /// Левая координата отрисовки штурмовика
        /// </summary>
        private float _startPosX;
        /// <summary>
        /// Правая кооридната отрисовки штурмовика
        /// </summary>
        private float _startPosY;
        /// <summary>
        /// Ширина окна отрисовки
        /// </summary>
        private int _pictureWidth;
        /// <summary>
        /// Высота окна отрисовки
        /// </summary>
        private int _pictureHeight;
        /// <summary>
        /// Ширина отрисовки штурмовика
        /// </summary>
        private readonly int StormtrooperWidth = 85;
        /// <summary>
        /// Высота отрисовки штурмовика
        /// </summary>
        private readonly int StormtrooperHeight = 110;
        /// <summary>
        /// Максимальная скорость
        /// </summary>
        public int MaxSpeed { private set; get; }
        /// <summary>
        /// Вес штурмовика
        /// </summary>
        public float Weight { private set; get; }
        /// <summary>
        /// Основной цвет
        /// </summary>
        public Color MainColor { private set; get; }
        /// <summary>
        /// Дополнительный цвет
        /// </summary>
        public Color DopColor { private set; get; }
        public bool Rockets { private set; get; }
        public bool Window { private set; get; }
        /// <summary>
        /// Инициализация свойств
        /// </summary>
        /// <param name="maxSpeed">Максимальная скорость</param>
        /// <param name="weight">Вес штурмовика</param>
        /// <param name="mainColor">Основной цвет штурмовика</param>
        /// <param name="dopColor">Дополнительный цвет</param>
        /// <param name="rockets">Признак наличия ракет</param>
        public void Init(int maxSpeed, float weight, Color mainColor, Color dopColor, bool rockets, bool window)
        {
            MaxSpeed = maxSpeed;
            Weight = weight;
            MainColor = mainColor;
            DopColor = dopColor;
            Rockets = rockets;
            Window = window;
        }
        /// <summary>
        /// Установка позиции штурмовика
        /// </summary>
        /// <param name="x">Координата X</param>
        /// <param name="y">Координата Y</param>
        /// <param name="width">Ширина картинки</param>
        /// <param name="height">Высота картинки</param>
        public void SetPosition(int x, int y, int width, int height)
        {
            _startPosX = x;
            _startPosY = y;
            _pictureHeight = height;
            _pictureWidth = width;
        }
        /// <summary>
        /// Изменение направления пермещения
        /// </summary>
        /// <param name="direction">Направление</param>
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
        /// Отрисовка штурмовика
        /// </summary>
        /// <param name="g"></param>
        public void DrawTransport(Graphics g)
        {
            Pen pen = new Pen(Color.Black);
            Brush Dop = new SolidBrush(DopColor);
            //отрисуем "тело" самолета, все основание
            g.DrawRectangle(pen, _startPosX + 10, _startPosY + 50, 75, 10);
            //окно
            if (Window) 
            { 
                g.DrawEllipse(pen, _startPosX + 15, _startPosY + 51, 8, 8);
                g.FillEllipse(Dop, _startPosX + 15, _startPosY + 51, 8, 8);
            }
            //ракеты
            if (Rockets)
            {
                g.FillRectangle(Dop, _startPosX + 10, _startPosY + 20, 50, 5);
                g.FillRectangle(Dop, _startPosX + 10, _startPosY + 30, 50, 5);
                g.FillRectangle(Dop, _startPosX + 10, _startPosY + 80, 50, 5);
                g.FillRectangle(Dop, _startPosX + 10, _startPosY + 90, 50, 5);
            }            
            //нос
            g.DrawLine(pen, _startPosX+10, _startPosY+50, _startPosX, _startPosY + 55);
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
