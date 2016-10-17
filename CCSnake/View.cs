using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace CCSnake
{
    partial class View : UserControl
    {
        Model model;
        public View(Model model)
        {
            InitializeComponent();

            this.model = model;
        }
        void Draw(PaintEventArgs e)
        {
            
            foreach(Food f in model.food)
                e.Graphics.DrawImage(f.ImageFoodNow, new Point(f.X, f.Y));            

            foreach (Body b in model.body)
                e.Graphics.DrawImage(b.ImageNow, new Point(b.X, b.Y));

            e.Graphics.DrawImage(model.snake.ImageSnakeNow, new Point(model.snake.X, model.snake.Y));

            if (model.flag)         // не дает перерисовываться контролу при остановке потока
                return;

            Thread.Sleep(model.SpeedGame);
            Invalidate();            
        }
        protected override void OnPaint(PaintEventArgs e)           // СОЗД ПЕРЕГРУЗКА МЕТОДА с UserControl
        {
            Draw(e);
        }
    }
}
