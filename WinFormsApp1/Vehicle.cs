using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsLiner
{
    public abstract class Vehicle: ITransport
    {
        protected float? _startPositionX = null;

        protected float? _startPositionY = null;

        protected int? _pictureWidth = null;

        protected int? _pictureHeight = null;

        public int MaxSpeed { protected set; get; }

        public float Weight { protected set; get; }

        public Color MainColor { protected set; get; }

        public void SetPosition(int x, int y, int width, int height)
        {
            _startPositionX = x;
            _startPositionY = y;
            _pictureWidth = width;
            _pictureHeight = height;
        }

        public abstract void DrawTransport(Graphics g);
        public abstract void MoveTransport(Direction direction);
    }
}
