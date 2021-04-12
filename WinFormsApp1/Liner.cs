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
            g.FillRectangle(brBlue, _startPositionX.Value + 80, _startPositionY.Value + 100, 100, 15);

            g.FillPolygon(brGreen, new Point[] {
                new Point((int)(_startPositionX.Value + 60), (int)(_startPositionY.Value + 115)),
                new Point((int)(_startPositionX.Value + 200), (int)(_startPositionY.Value + 115)),
                new Point((int)(_startPositionX.Value + 180), (int)(_startPositionY.Value + 145)),
                new Point((int)(_startPositionX.Value + 80), (int)(_startPositionY.Value + 145)),
            });

            g.DrawRectangle(pen, _startPositionX.Value + 80, _startPositionY.Value + 100, 100, 15);
            

            g.DrawLine(pen, _startPositionX.Value + 60, _startPositionY.Value + 115, _startPositionX.Value + 200, _startPositionY.Value + 115);
            g.DrawLine(pen, _startPositionX.Value + 80, _startPositionY.Value + 145, _startPositionX.Value + 180, _startPositionY.Value + 145);

            g.DrawLine(pen, _startPositionX.Value + 60, _startPositionY.Value + 115, _startPositionX.Value + 80, _startPositionY.Value + 145);
            g.DrawLine(pen, _startPositionX.Value + 180, _startPositionY.Value + 145, _startPositionX.Value + 200, _startPositionY.Value + 115);

            g.DrawLine(pen, _startPositionX.Value + 80, _startPositionY.Value + 120, _startPositionX.Value + 80, _startPositionY.Value + 135);
            g.DrawLine(pen, _startPositionX.Value + 75, _startPositionY.Value + 129, _startPositionX.Value + 85, _startPositionY.Value + 129);


        }
    }
}
