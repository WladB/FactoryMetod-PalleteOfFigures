using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace FactoryMetodLibrary
{
    public class CircleMsWord : IFigure
    {
        public override void draw(Color cl)
        {
            g.DrawEllipse(new Pen(cl,3), point.X, point.Y, size.Width, size.Height);
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

    public class FactoryMethodMsWord : FactoryMethod
    {
        public override IFigure CreateFigure()
        {
            return new CircleMsWord();
        }
        public override void Create()
        {
            f = CreateFigure();
            Random rand = new Random();
            f.point = new Point(rand.Next(0, 898), rand.Next(150, 432 - (f.size.Height + 10)));
            f.size = new Size(150, 100);
            f.color = Color.CornflowerBlue;
            f.draw(f.color);
        }
    }
}
