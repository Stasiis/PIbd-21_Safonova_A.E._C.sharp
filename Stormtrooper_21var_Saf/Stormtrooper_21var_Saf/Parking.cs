using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Stormtrooper_21var_Saf
{
    public class Parking<T> where T : class, ITransport
    {
        private readonly List<T> _places;
        private readonly int _maxCount;
        /// <summary>
        /// Ширина окна отрисовки
        /// </summary>
        private readonly int pictureWidth;
        /// <summary>
        /// Высота окна отрисовки
        /// </summary>
        private readonly int pictureHeight;
        /// <summary>
        /// Размер парковочного места (ширина)
        /// </summary>
        private readonly int _placeSizeWidth = 150;
        /// <summary>
        /// Размер парковочного места (высота)
        /// </summary>
        private readonly int _placeSizeHeight = 120;
        /// <summary>
        /// Конструктор
        /// </summary>
        /// <param name="picWidth">Рамзер ангара - ширина</param>
        /// <param name="picHeight">Рамзер ангара - высота</param>
        public Parking(int picWidth, int picHeight)
        {
            int width = picWidth / _placeSizeWidth;
            int height = picHeight / _placeSizeHeight;
            _maxCount = width * height;
            pictureWidth = picWidth;
            pictureHeight = picHeight;
            _places = new List<T>();
        }
        public static int operator +(Parking<T> p, T Plane)
        {
            if (p._places.Count < p._maxCount)
            {
                p._places.Add(Plane);
                return 1;
            }
            return -1;
        }
        public static T operator -(Parking<T> p, int index)
        {
            if (index <= -1 || index >= p._places.Count)
            {
                return null;
            }
            T ship = p._places[index];
            p._places.RemoveAt(index);
            return ship;            
        }
        /// <summary>
        /// Метод отрисовки ангара
        /// </summary>
        /// <param name="g"></param>
        public void Draw(Graphics g)
        {
            DrawMarking(g);
            for (int i = 0; i < _places.Count; i++)
            {
                int width = pictureWidth / _placeSizeWidth;
                int height = pictureHeight / _placeSizeHeight;
                int column = i / height;
                int row = i % width;
                _places[i].SetPosition(row * _placeSizeWidth + _placeSizeWidth / 8, column * _placeSizeHeight + _placeSizeHeight / 18, pictureWidth, pictureHeight);
                _places[i].DrawTransport(g);
            }
        }
        /// <summary>
        /// Метод отрисовки разметки парковочных мест
        /// </summary>
        /// <param name="g"></param>
        private void DrawMarking(Graphics g)
        {
            Pen pen = new Pen(Color.Black, 3);
            for (int i = 0; i < pictureWidth / _placeSizeWidth; i++)
            {
                for (int j = 0; j < pictureHeight / _placeSizeHeight + 1; ++j)
                {//линия рамзетки места
                    g.DrawLine(pen, i * _placeSizeWidth, j * _placeSizeHeight, i * _placeSizeWidth + _placeSizeWidth / 2, j * _placeSizeHeight);
                }
                g.DrawLine(pen, i * _placeSizeWidth, 0, i * _placeSizeWidth, (pictureHeight / _placeSizeHeight) * _placeSizeHeight);
            }
        }
    }
}
