using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace CCSnake
{
    class ImageSnake
    {
        Image up = Properties.Resources.SnakeMoveUp;
        public Image Up
        {
            get { return up; }
        }

        Image down = Properties.Resources.SnakeMoveDown;
        public Image Down
        {
            get { return down; }
        }

        Image right = Properties.Resources.SnakeMoveRight;
        public Image Right
        {
            get { return right; }
        }

        Image left = Properties.Resources.SnakeMoveLeft;
        public Image Left
        {
            get { return left; }
        }
    }
}
