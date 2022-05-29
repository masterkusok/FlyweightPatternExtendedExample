using System;
using System.Collections.Generic;
using FlyweightPictureExample.ImageContexts;

namespace FlyweightPictureExample.ImageInsertProcessor
{
    public class NonFlyweightInsertProcessor : ImageInsertProcessor
    {
        public NonFlyweightInsertProcessor(Graphics g, Image img) : base(g, img)
        {
        }

        protected override void CreateNeccessaryContext()
        {
            _imageContexts.Add(new NonFlyweightContext(_img, _lastX, _lastY));
        }
    }
}
