using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace FactoryMetodLibrary
{
    public class CircleDraw_io : IFigure
    {
        public override void draw(Color cl)
        {
            g.DrawEllipse(new Pen(cl, 2), point.X, point.Y, size.Width, size.Width);
        }
        public override void move(int dx, int dy)
        {
            hide();
            point.X += dx;
            point.Y += dy;
            draw(color);
        }
        public override void hide()
        {
            draw(Color.WhiteSmoke);
        }
    }
    public class FactoryMethodDraw_io : FactoryMethod
    {
        public override IFigure CreateFigure()
        {
            return new CircleDraw_io();
        }
        public override void Create()
        {
            f = CreateFigure();
            Random rand = new Random();
            f.point = new Point(rand.Next(0,898), rand.Next(150, 432 - (f.size.Height + 10)));
            f.size = new Size(150, 150);
            f.color = Color.Black;
            f.draw(f.color);
        }
    }
}

