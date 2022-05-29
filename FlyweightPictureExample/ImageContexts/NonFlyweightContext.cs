using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlyweightPictureExample.ImageContexts
{
    public class NonFlyweightContext : ImageContext
    {
        private Image _img;

        public NonFlyweightContext(Image img, int X, int Y)
        {
            _img = img;
            X = X;
        }

        public override void Draw(Graphics g)
        {
            g.DrawImage(_img, X, Y);
        }
    }
}
