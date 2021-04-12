using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsLiner
{
    class Liner: Vehicle
    {
        protected readonly int _linerWidth = 100;

        protected readonly int _linerHeight = 100;

        public Liner(int maxSpeed, float weight, Color mainColor)
        {
            MaxSpeed = maxSpeed;
            Weight = weight;
            MainColor = mainColor;
        }

        protected Liner(int maxSpeed, float weight, Color mainColor, int linerWidth, int linerHeight)
        {
            MaxSpeed = maxSpeed;
            Weight = weight;
            MainColor = mainColor;
            _linerWidth = linerWidth;
            _linerHeight = linerHeight;
        }

        public override void MoveTransport(Direction direction)
        {
            if (!_pictureWidth.HasValue || !_pictureHeight.HasValue)
            {
                return;
            }
            float step = MaxSpeed * 100 / Weight;
            switch (direction)
            {
                case Direction.Right:
                    if (_startPositionX + step < _pictureWidth - _linerWidth)
                    {
                        _startPositionX += step;
                    }
                    break;
                case Direction.Left:
                    _startPositionX -= step;
                    break;
                case Direction.Up:
                    _startPositionY -= step;
                    break;
                case Direction.Down:
                    if (_startPositionY + step < _pictureHeight - _linerHeight)
                    {
                        _startPositionY += step;
                    }
                    break;
            }
        }

        public override void DrawTransport(Graphics g)
        {
            Pen pen = new Pen(Color.Black);
            g.DrawRectangle(pen, _startPositionX.Value + 80, _startPositionY.Value - 6, 100, 15);

        }
    }
}
