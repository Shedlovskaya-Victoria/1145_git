using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1145_git.Funcs
{
    public class Sbka : IDraw
    {
        public void Draw(Graphics graphics)
        {
            Bitmap bitmap = new Bitmap("sbka.jpg");
            graphics.DrawImage(bitmap, new Point(1000,250));
        }
    }
}
