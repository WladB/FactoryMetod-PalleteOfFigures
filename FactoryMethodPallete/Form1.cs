using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FactoryMetodLibrary;

namespace FactoryMethodPallete
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            IFigure.g = this.CreateGraphics();
        }
       
        FactoryMethod paint;
        FactoryMethod msWord;
        FactoryMethod draw_io; 
        IFigure fig;
        bool move;
        List<IFigure> list = new List<IFigure>();
        public Point mousePoint;

        private void button1_Click(object sender, EventArgs e)
        {
            paint = new FactoryMethoPaint();
            paint.Create();
            list.Add(paint.f);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            msWord = new FactoryMethodMsWord();
            msWord.Create();
            list.Add(msWord.f);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            draw_io = new FactoryMethodDraw_io();
            draw_io.Create();
            list.Add(draw_io.f);
        }

        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            fig = null;
            foreach (IFigure f in list)
            {

                if (f.point.X < e.X && f.size.Width + f.point.X > e.X && f.point.Y < e.Y && f.size.Height + f.point.Y > e.Y)
                {
                    f.lastP.X = e.X;
                    f.lastP.Y = e.Y;
                    fig = f;
                    move = true;
                }
               

            }
            
        }

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            if (move)
            {
                fig.move(e.X - fig.lastP.X, e.Y - fig.lastP.Y);
                fig.lastP.X = e.X;
                fig.lastP.Y = e.Y;
                fig.draw(fig.color);
                for(int i =0; i<list.Count;i++){
                    list[i].draw(list[i].color);
                }
            }
        }

        private void Form1_MouseUp(object sender, MouseEventArgs e)
        {
            if (move)
            {
                fig.draw(fig.color);
            }

            move = false;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (fig != null)
            {
                fig.hide();
                list.Remove(fig);
                fig = null;
                MessageBox.Show("Фігугру видалено");
            }
            else {
                MessageBox.Show("Фігура не обрана");
            }
        }
    }
}
