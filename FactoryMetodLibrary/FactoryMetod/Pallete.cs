using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace FactoryMetodLibrary
{

    public abstract class IFigure
    {
        public static Graphics g;
        public Size size;
        public Point point;
        public Point lastP;
        public Color color;
        abstract public void draw(Color cl);
        abstract public void hide();
        abstract public void move(int dx, int dy);
    }
      public abstract class FactoryMethod
        {
            public IFigure f;
            abstract public IFigure CreateFigure();
            abstract public void Create();
    }


    }
