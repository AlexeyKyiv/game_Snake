using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CCSnake
{
    struct PointStruct
    {
        public int sx;
        public int sy;
        public int dirX;
        public int dirY;

        public PointStruct(int sx, int sy, int dirX, int dirY)
        {
            this.sx = sx;
            this.sy = sy;
            this.dirX = dirX;
            this.dirY = dirY;
        }
    }
}
