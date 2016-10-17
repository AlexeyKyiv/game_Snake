using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace CCSnake
{
    class Snake
    {
        ImageSnake imageSnake;
        Image imageSnakeNow;

        static Random r;
        int x, y;                         // координаты змейки
        int directX, directY;             // направление змейки
        int nextDirectX, nextDirectY;     // следующее направление змейки (управл с клавы)

        public int X
        {
            get { return x; }
            //set { x = value; }
        }
        public int Y
        {
            get { return y; }
            //set { y = value; }
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
        public Image ImageSnakeNow
        {
            get { return imageSnakeNow; }
        }
        public int NextDirectX
        {
            get { return nextDirectX; }
            set { if (value == -1 || value == 0 || value == 1) nextDirectX = value; /**/ else nextDirectX = 0; }
        }
        public int NextDirectY
        {
            get { return nextDirectY; }
            set { if (value == -1 || value == 0 || value == 1) nextDirectY = value; /**/ else nextDirectY = 0; }
        }

        public Snake()
        {
            imageSnake = new ImageSnake();
            r = new Random();
            StartSnakeDirection();              // выбор направления Змейки (DirectXY-ов) random
            SnakeImageDirection();              // присвоение кортинки соотвотственно направлению
            StartSnakeCoordinate();             // задание стартовых координат змейке (по центру)
        }
        public void Run()
        {
            x += DirectX;
            y += DirectY;

            if ((Math.IEEERemainder(x, 20) == 0) && (Math.IEEERemainder(y, 20) == 0))         // IEEERemainder - метод вычисляющий Остаток от деления первого числа на второе
                Turn();

            if (x > 480) x = 0;       // "прозрачные стены"
            if (y > 480) y = 0;
            if (x < 0) x = 480;
            if (y < 0) y = 480;
        }
        void Turn()
        {
            if (DirectX == -1 * NextDirectX || DirectY == -1 * NextDirectY)             // предотвращает разворот змейки
                return;

            DirectX = nextDirectX;
            DirectY = nextDirectY;

            SnakeImageDirection();
        }
        void StartSnakeDirection()
        {
            if (r.Next(10000) > 5000)
                if(r.Next(10000) > 5000)            // выбор направления движения по вертикали
                {
                    DirectX = 0; DirectY = -1;
                }
                else
                {
                    DirectX = 0; DirectY = 1;
                }
            else
                if (r.Next(10000) > 5000)           // выбор направления движения по горизонтали
                {
                    DirectX = 1; DirectY = 0;
                }
                else
                {
                    DirectX = -1; DirectY = 0;
                }
        }
        void SnakeImageDirection()
        {
            if (DirectY == -1) imageSnakeNow = imageSnake.Up;
            if (DirectY == 1) imageSnakeNow = imageSnake.Down;
            if (DirectX == 1) imageSnakeNow = imageSnake.Right;
            if (DirectX == -1) imageSnakeNow = imageSnake.Left;
        }
        void StartSnakeCoordinate()
        {
            x = 240; y = 240;
        }
    }
}
