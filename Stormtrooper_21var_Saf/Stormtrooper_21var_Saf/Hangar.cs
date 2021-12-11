using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Collections;

namespace Stormtrooper_21var_Saf
{
    public class Hangar<T> : IEnumerator<T>, IEnumerable<T>  where T : class, ITransport
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
        private int _currentIndex;
        public T Current => _places[_currentIndex];
        object IEnumerator.Current => _places[_currentIndex];
        /// <summary>
        /// Конструктор
        /// </summary>
        /// <param name="picWidth">Рамзер ангара - ширина</param>
        /// <param name="picHeight">Рамзер ангара - высота</param>
        public Hangar(int picWidth, int picHeight)
        {
            int width = picWidth / _placeSizeWidth;
            int height = picHeight / _placeSizeHeight;
            _maxCount = width * height;
            pictureWidth = picWidth;
            pictureHeight = picHeight;
            _places = new List<T>();
            _currentIndex = -1;
        }
        public static int operator +(Hangar<T> p, T Plane)
        {
            if (p._places.Count < p._maxCount)
            {
                if (p._places.Contains(Plane))
                {
                    throw new HangarAlreadyHaveException();
                }
                p._places.Add(Plane);
                return p._places.Count;
            }
            throw new HangarOverflowException();
        }
        public static T operator -(Hangar<T> p, int index)
        {
            if (index <= -1 || index >= p._places.Count)
            {
                throw new HangarNotFoundException(index);
            }
            T plane = p._places[index];
            p._places.RemoveAt(index);
            return plane;            
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
        /// Метод отрисовки разметки
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
        public T GetNext(int index)
        {
            if (index < 0 || index >= _places.Count)
            {
                return null;
            }
            return _places[index];
        }
        public void Sort() => _places.Sort((IComparer<T>)new PlaneComparer());
        public void Dispose()
        {
        }
        public bool MoveNext()
        {
            if (_currentIndex < _places.Count - 1)
            {
                _currentIndex++;
                return true;
            }
            return false;
        }
        public void Reset()
        {
            _currentIndex = -1;
        }
        public IEnumerator<T> GetEnumerator()
        {
            return this;
        }
        IEnumerator IEnumerable.GetEnumerator()
        {
            return this;
        }
    }
}
