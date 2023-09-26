using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace FactoryMetodLibrary
{
    public class CirclePaint : IFigure
    {
        public override void draw(Color cl)
        {
            g.DrawEllipse(new Pen(cl), point.X, point.Y, size.Width, size.Height);
        }
        public override void move(int dx, int dy)
        {
            
        }
        public override void hide()
        {
            draw(Color.WhiteSmoke);
        }
    }
    public class FactoryMethoPaint : FactoryMethod
    {
        public override IFigure CreateFigure()
        {
            return new CirclePaint();
        }

        public override void Create()
        {
            f = CreateFigure();
            Random rand = new Random();
            f.point = new Point(rand.Next(0, 898), rand.Next(150, 432 - (f.size.Height + 10)));
            f.size = new Size(150, 85);
            f.color = Color.Black;
            f.draw(f.color);
        }
    }
}
