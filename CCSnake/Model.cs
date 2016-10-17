using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace CCSnake
{
    class Model //: Form
    {
        public Snake snake;
        public List<Body> body;
        public List<Food> food;
        public List<PointStruct> pointTurnS;

        int sizeField, speedGame, numberFood = 5;
        int x, y, z; 
        public bool flag, flagBody = true;
        static Random r;

        public int SpeedGame
        {
            get { return speedGame; }
            set { speedGame = value;  }
        }

        public Model(int sizeField, int speedGame, bool flag)
        {
            this.sizeField = sizeField;
            this.speedGame = speedGame;
            this.flag = flag;            

            StartGame();            
        }

        public void StartGame()
        {
            z = sizeField / 20;
            r = new Random();
            snake = new Snake();
            body = new List<Body>();
            food = new List<Food>();
            pointTurnS = new List<PointStruct>();

            for (int i = 0; i < numberFood; i++)              // создание еды для змейки
            {
                x = r.Next(z - 1) * 20;
                y = r.Next(z - 1) * 20;
                food.Add(new Food(x, y));
            }
        }

        public void Play()
        {
            while(!flag)                 // создается бесконечный (управляемый) цикл
            {
                Thread.Sleep(speedGame);

                snake.Run();

                for (int i = 0; i < body.Count; i++ )
                    body[i].Run();

                for (int i = 0; i < food.Count; i++ )
                    food[i].Run();

                CreatePointTurnBody();
                
                TurnBody();

                DelPointTurn();

                SnakeEatingFood();      // поедание еды змейкой

                LoseGame();
            }
        }

        void LoseGame()
        {
            for (int i=0; i < body.Count; i++)
            
                if (((Math.Abs(body[i].X - snake.X) < 19) && (body[i].Y == snake.Y)) || ((Math.Abs(body[i].Y - snake.Y) < 19) && (body[i].X == snake.X)))
                { 
                    flag = !flag;
                    MessageBox.Show("ВЫ ПРОИГРАЛИ !", "Snake");
                }
        }

        void CreatePointTurnBody()
        {        
            if (body.Count > 0)
                if ((snake.DirectX != body[0].DirectX) && (Math.IEEERemainder(snake.X, 20) == 0) && (Math.IEEERemainder(snake.Y, 20) == 0))
                    pointTurnS.Add(new PointStruct(snake.X, snake.Y, snake.DirectX, snake.DirectY));
        }

        void TurnBody()
        {
            if (body.Count > 0)
                for (int i = 0; i < body.Count; i++ )                
                    for (int j = 0; j < pointTurnS.Count; j++)                    
                        if (pointTurnS[j].sx == body[i].X && pointTurnS[j].sy == body[i].Y /*&& body.Count > 0*/)
                        {
                            body[i].DirectX = pointTurnS[j].dirX;
                            body[i].DirectY = pointTurnS[j].dirY;

                            if (pointTurnS[j].dirX != 0) body[i].ImageNow = body[i].ImageBody.BodyX;
                            if (pointTurnS[j].dirY != 0) body[i].ImageNow = body[i].ImageBody.BodyY;
                        }
        }

        void DelPointTurn()
        {
            for (int i = 0; i < pointTurnS.Count; i++)
            {
                if (pointTurnS[i].sx == body[body.Count - 1].X && pointTurnS[i].sy == body[body.Count - 1].Y)
                {
                    if (body.Count == 0) return;

                    pointTurnS.RemoveAt(i);
                }
            }
        }

        void SnakeEatingFood()
        {
            //foreach (Food f in food)
            for (int i = 0; i < food.Count; i++ )
                if ((snake.X == food[i].X) & (snake.Y == food[i].Y))
                {
                    food.RemoveAt(i);           // удаление элемента списка (List)
                        loop:
                    x = r.Next(z - 1) * 20;
                    y = r.Next(z - 1) * 20;

                    foreach (Body b in body)                
                        if ((b.X == x) && (b.Y == y))
                            goto loop;
                    
                    food.Add(new Food(x, y));

                    BodySnakeAdd();                // появление Тела змейки (первого и следующих)
                }
        }

        void BodySnakeAdd()
        {
            if (body.Count > 0)
            {
                if (body[body.Count - 1].DirectX == 0 & body[body.Count - 1].DirectY == -1)           // движ вверх
                    body.Add(new Body(body[body.Count - 1].X, body[body.Count - 1].Y + 20, 1));

                if (body[body.Count - 1].DirectX == 0 & body[body.Count - 1].DirectY == 1)           // движ вниз
                    body.Add(new Body(body[body.Count - 1].X, body[body.Count - 1].Y - 20, 2));

                if (body[body.Count - 1].DirectX == 1 & body[body.Count - 1].DirectY == 0)           // движ вправо
                    body.Add(new Body(body[body.Count - 1].X - 20, body[body.Count - 1].Y, 3));

                if (body[body.Count - 1].DirectX == -1 & body[body.Count - 1].DirectY == 0)           // движ влево
                    body.Add(new Body(body[body.Count - 1].X + 20, body[body.Count - 1].Y, 4));
            }

            if (body.Count == 0)
            { 
                if (snake.DirectX == 0 & snake.DirectY == -1)           // движ вверх                
                    body.Add(new Body(snake.X, snake.Y + 20, 1));
                
                if (snake.DirectX == 0 & snake.DirectY == 1)           // движ вниз                
                    body.Add(new Body(snake.X, snake.Y - 20, 2));
                
                if (snake.DirectX == 1 & snake.DirectY == 0)           // движ вправо                
                    body.Add(new Body(snake.X - 20, snake.Y, 3));
                
                if (snake.DirectX == -1 & snake.DirectY == 0)           // движ влево                
                    body.Add(new Body(snake.X + 20, snake.Y, 4));
                
            }
            

        }
    }
}
