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
            if (!_startPositionX.HasValue || !_startPositionY.HasValue)
            {
                return;
            }
            Pen pen = new Pen(Color.Black);
            Brush brBlue = new SolidBrush(Color.LightBlue);
            Brush brGreen = new SolidBrush(Color.LightGreen);
            g.FillRectangle(brBlue, _startPositionX.Value + 20, _startPositionY.Value + 20, 100, 15);

            g.FillPolygon(brGreen, new Point[] {
                new Point((int)(_startPositionX.Value), (int)(_startPositionY.Value + 35)),
                new Point((int)(_startPositionX.Value + 140), (int)(_startPositionY.Value + 35)),
                new Point((int)(_startPositionX.Value + 120), (int)(_startPositionY.Value + 65)),
                new Point((int)(_startPositionX.Value + 20), (int)(_startPositionY.Value + 65)),
            });

            g.DrawRectangle(pen, _startPositionX.Value + 20, _startPositionY.Value + 20, 100, 15);
            

            g.DrawLine(pen, _startPositionX.Value, _startPositionY.Value + 35, _startPositionX.Value + 140, _startPositionY.Value + 35);
            g.DrawLine(pen, _startPositionX.Value + 20, _startPositionY.Value + 65, _startPositionX.Value + 120, _startPositionY.Value + 65);

            g.DrawLine(pen, _startPositionX.Value, _startPositionY.Value + 35, _startPositionX.Value + 20, _startPositionY.Value + 65);
            g.DrawLine(pen, _startPositionX.Value + 120, _startPositionY.Value + 65, _startPositionX.Value + 140, _startPositionY.Value + 35);

            g.DrawLine(pen, _startPositionX.Value + 20, _startPositionY.Value + 40, _startPositionX.Value + 20, _startPositionY.Value + 55);
            g.DrawLine(pen, _startPositionX.Value + 15, _startPositionY.Value + 49, _startPositionX.Value + 25, _startPositionY.Value + 49);


        }
    }
}
