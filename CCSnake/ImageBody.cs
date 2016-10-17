using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace CCSnake
{
    class ImageBody
    {
        Image bodyX = Properties.Resources.BodyX;
        Image bodyY = Properties.Resources.BodyY;

        public Image BodyX
        {
            get { return bodyX; }
        }       
        public Image BodyY
        {
            get { return bodyY; }
        }
    }
}
