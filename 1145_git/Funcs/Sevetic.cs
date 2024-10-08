using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1145_git.Funcs
{
    public class Sevetic: IDraw
    {
        public void Draw(Graphics graphics)
        {
            Bitmap bitmap = new Bitmap("filter.jpeg");
            graphics.DrawImage(bitmap, new Point(500, 150));
        }
    }
}
