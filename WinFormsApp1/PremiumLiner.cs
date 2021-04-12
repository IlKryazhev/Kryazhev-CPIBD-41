using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsLiner
{
    class PremiumLiner : Liner
    {
        public Color DopColor { private set; get; }

        public bool Helipad { private set; get; }

        public void Init(int maxSpeed, float weight, Color mainColor, Color
            dopColor, bool helipad)
        {
            MaxSpeed = maxSpeed;
            Weight = weight;
            MainColor = mainColor;
            DopColor = dopColor;
            Helipad = helipad;
        }

        public PremiumLiner(int maxSpeed, float weight, Color mainColor, Color
            dopColor, bool helipad) :
            base(maxSpeed, weight, mainColor, 100, 100)
        {
            DopColor = dopColor;
            Helipad = helipad;
        }

        public override void DrawTransport(Graphics g)
        {
            Pen pen = new Pen(Color.Black);
            g.DrawRectangle(pen, _startPositionX.Value + 80, _startPositionY.Value - 6, 100, 15);
           
        }
    }
}
