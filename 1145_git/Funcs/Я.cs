using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1145_git.Funcs
{
    public class Я : IDraw
    {
        public void Draw(Graphics graphics)
        {
            for(int i = 0; i  < 10; i++) 
                graphics.DrawString("♥☺☻☺♥", new Font(FontFamily.GenericSerif, 200), new SolidBrush(Color.Red), new PointF(150, 200 * i));
        }
    }
}
