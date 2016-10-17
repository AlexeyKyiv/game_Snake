using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace CCSnake
{
    class Food
    {
        ImageFood imageFood;
        Image[] imageFoodMas;
        Image imageFoodNow;

        int x, y, z;
        static Random r;

        public Image ImageFoodNow
        {
            get { return imageFoodNow; }
        }        
        public int X
        {
            get { return x; }
        }
        public int Y
        {
            get { return y; }
        }        

        public Food(int x, int y)
        {
            this.x = x; this.y = y;
            imageFood = new ImageFood();

            r = new Random();
            if (r.Next(3000) > 2000)
                imageFoodMas = imageFood.RedFood;
            else
                if (r.Next(3000) < 1500)
                    imageFoodMas = imageFood.YellowFood;
                else
                    imageFoodMas = imageFood.BlueFood;

            Run();
        }
        public void Run()                   // меняеться картинка (измен размер еды)
        {
            imageFoodNow = imageFoodMas[z];
            z++;
            if (z == 8) z = 0;
        }

    }
}
