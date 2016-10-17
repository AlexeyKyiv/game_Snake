using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace CCSnake
{
    class Body
    {
        ImageBody imageBody;
        Image imageNow;

        int x, y, directX, directY;
        int l;

        public int X
        {
            get { return x; }
        }
        public int Y
        {
            get { return y; }
        }
        public int DirectX
        {
            get { return directX; }
            set { if (value == -1 || value == 0 || value == 1) directX = value; /**/ else directX = 0; }
        }
        public int DirectY
        {
            get { return directY; }
            set { if (value == -1 || value == 0 || value == 1) directY = value; /**/ else directY = 0; }
        }
        public Image ImageNow
        {
            get { return imageNow; }
            set { imageNow = value; }
        }
        public ImageBody ImageBody
        {
            get { return imageBody; }
        }
        public Body(int x, int y, int l)
        {
            this.x = x; this.y = y; this.l = l;
            imageBody = new ImageBody();

            BodyDirection();
        }
        public void Run()
        {
            x += DirectX;
            y += DirectY;
                                    // "прозрачные стены"
            if (x > 480) x = 0;       
            if (y > 480) y = 0;
            if (x < 0) x = 480;
            if (y < 0) y = 480;
        }
        public void BodyDirection()
        {
            if (l == 1)          //  движение вверх
            {
                imageNow = imageBody.BodyY;
                DirectX = 0;
                DirectY = -1;
            }
            if (l == 2)          //  движение вниз
            {
                imageNow = imageBody.BodyY;
                DirectX = 0;
                DirectY = 1;
            }
            if (l == 3)          //  движение вправо
            {
                imageNow = imageBody.BodyX;
                DirectX = 1;
                DirectY = 0;
            }
            if (l == 4)          //  движение влево
            {
                imageNow = imageBody.BodyX;
                DirectX = -1;
                DirectY = 0;
            }
        }
    }
}
