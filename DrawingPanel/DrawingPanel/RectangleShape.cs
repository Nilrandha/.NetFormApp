using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DrawingPanel
{

    public class RectangleShape : Shape
    {
        public override void Draw(Graphics g)
        {
            using (Brush brush = new SolidBrush(FillColor))
                g.FillRectangle(brush, Bounds);

            using (Pen pen = new Pen(BorderColor, BorderWidth))
                g.DrawRectangle(pen, Bounds);
        }
    }
}
