using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsLiner
{
    class Pier<T> where T : class, ITransport
    {
        private readonly List<T> _places;
        private readonly int _maxCount;
        private readonly int _pictureWidth;
        private readonly int _pictureHeight;
        private readonly int _placeSizeWidth = 210;
        private readonly int _placeSizeHeight = 80;

        public Pier(int picWidth, int picHeight)
        {
            int width = picWidth / _placeSizeWidth;
            int height = picHeight / _placeSizeHeight;
            _maxCount = width * height;
            _pictureHeight = picHeight;
            _pictureWidth = picWidth;
            _places = new List<T>();
        }

        public static bool operator +(Pier<T> p, T liner)
        {
            if(p._places.Count == p._maxCount)
            {
                return false;
            }
            var index = p._places.Count;
            p._places.Add(liner);
           
            if (index <= 7)
            {
                liner.SetPosition(0, index * p._placeSizeHeight, p._placeSizeWidth - 30, p._placeSizeHeight - 20);
            }
            if (index > 7 && index <= 14)
            {
                liner.SetPosition(p._placeSizeWidth, (index - 7) * p._placeSizeHeight, p._placeSizeWidth - 30, p._placeSizeHeight - 20);
            }
            if (index > 14)
            {
                liner.SetPosition(p._placeSizeWidth * 2, (index - 14) * p._placeSizeHeight, p._placeSizeWidth - 30, p._placeSizeHeight - 20);
            }
            return true;
        }

        public static T operator -(Pier<T> p, int index)
        {
            var pickupedLiner = p._places[index];
            p._places.RemoveAt(index);
            return pickupedLiner;
        }

        public void Draw(Graphics g)
        {
            DrawMarking(g);
            for (int i = 0; i < _places.Count; i++)
            {
                _places[i].SetPosition(5 + i / 5 * _placeSizeWidth + 5, i %
                    5 * _placeSizeHeight + 15, _pictureWidth, _pictureHeight);
                _places[i].DrawTransport(g);

            }
        }

        private void DrawMarking(Graphics g)
        {
            Pen pen = new Pen(Color.Black, 3);
            for (int i = 0; i < _pictureWidth / _placeSizeWidth; i++)
            {
                for (int j = 0; j < _pictureHeight / _placeSizeHeight + 1;
                ++j)
                {
                    g.DrawLine(pen, i * _placeSizeWidth, j *
                    _placeSizeHeight, i * _placeSizeWidth + _placeSizeWidth / 2, j * _placeSizeHeight);
                }
                g.DrawLine(pen, i * _placeSizeWidth, 0, i *
                _placeSizeWidth, (_pictureHeight / _placeSizeHeight) * _placeSizeHeight);
            }
        }
    }


}
